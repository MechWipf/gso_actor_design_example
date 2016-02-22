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

        private List<CalculatePrimeActor> actorPool;
        private Props Pool;
        private ActorSystem TheSystem;

        private delegate Action<int> CreateProgressBarCallback();

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

                Func<Action<int>> callback = () =>
                {
                    var d = new CreateProgressBarCallback(CreateProgressBar);
                    return (Action<int>)Invoke( d, new object[] { } );
                };
                var props = Props.Create( () => new CalculatePrimeActor( callback ) ).WithRouter( new SmallestMailboxPool( MaxActor ) );
                var router = TheSystem.ActorOf( props, "router" );

                for (int i = 0; i < 100000; i++)
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

        public Action<int> CreateProgressBar()
        {
            var pp = new ProgressControl( "Worker" );
            this.flProgress.Controls.Add( pp );

            return ( i ) => { pp.SetValue( i ); };
        }
    }
}
