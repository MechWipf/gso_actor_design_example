using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Akka.Routing;
using Akka.Actor;

namespace actor_pattern_example
{
    public partial class MainWindow : Form
    {
        private bool _running = false;
        public bool Running
        {
            get { return _running; }
            set { btnStart.Enabled = !value; _running = value; }
        }

        private ActorSystem TheSystem;

        private delegate Action<int, string> CreateProgressBarCallback();
        private delegate Action<string> AddStatusTextCallback();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            Start();
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            Stop();
        }

        public void Start()
        {
            try
            {
                TheSystem = ActorSystem.Create( "TheSystem" );

                Running = true;

                int MaxActor = Convert.ToInt32( tbActorCount.Text );

                Func<Action<int, string>> callback_CreateProgressBar = () =>
                {
                    var d = new CreateProgressBarCallback( CreateProgressBar );
                    return (Action<int, string>)Invoke( d, new object[] { } );
                };
                var props = Props.Create( () => new WorkActor( callback_CreateProgressBar ) ).WithRouter( new SmallestMailboxPool( MaxActor ) );
                var router = TheSystem.ActorOf( props, "router" );

                Func<Action<string>> callback_AddStatusText = () =>
                {
                    var d = new AddStatusTextCallback( AddStatusText );
                    return (Action<string>)Invoke( d, new object[] { } );
                };

                props = Props.Create( () => new ProgressActor( callback_AddStatusText ) );
                var progress = TheSystem.ActorOf( props, "progress" );

                Console.WriteLine( progress.Path );

                var start = Convert.ToInt32( tbStart.Text );
                var end = Convert.ToInt32( tbEnd.Text );

                for (int i = start; i <= end; i++)
                {
                    router.Tell( i );
                }
            }
            catch (Exception e)
            {
                Running = false;
                MessageBox.Show( e.Message, "Error" );
            }
        }

        public void Stop()
        {
            btnStart.Enabled = true;

            try
            {
                this.flProgress.Controls.Clear();
                this.TheSystem.Terminate();
                Task.WaitAll( this.TheSystem.WhenTerminated );
                Running = false;
            }
            catch (Exception e)
            {
                Running = false;
                MessageBox.Show( e.Message, "Error" );
            }

            btnStop.Enabled = true;
        }

        public Action<int, string> CreateProgressBar()
        {
            var pp = new ProgressControl( "Worker" );
            this.flProgress.Controls.Add( pp );

            return ( i, s ) =>
            {
                Delegate d = (MethodInvoker)( delegate
                {
                    if (s != null && s != "")
                    {
                        pp.Caption = "Worker " + s;
                    }

                    pp.Value = i;
                } );
                
                try
                {
                    Invoke( d );
                }
                catch {}
            };
        }


        public Action<string> AddStatusText()
        {
            return ( text ) =>
            {
                Delegate d = (MethodInvoker)( delegate { this.tbPrimes.AppendText( text ); } );
                Invoke( d );
            };
        }
    }
}
