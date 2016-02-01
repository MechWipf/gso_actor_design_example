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

        public MainWindow()
        {
            InitializeComponent();

            TheSystem = ActorSystem.Create("TheSystem");
        }
 
        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void Start()
        {
            try
            {
                Running = true;

                int MaxActor = Convert.ToInt32(tbActorCount.Text);

                var props = Props.Create<CalculatePrimeActor>().WithRouter(new SmallestMailboxPool(MaxActor));
                var actor = TheSystem.ActorOf<CalculatePrimeActor>();

                props.Tell();

                for (int i = 0; i < MaxActor; i++)
                {
                    AddProgressBar("Worker: " + (i + 1));
                }
            }
            catch (Exception e)
            {
                Running = false;
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void Stop()
        {
            try
            {
                this.flProgress.Controls.Clear();
                Running = false;
            }
            catch (Exception e)
            {
                Running = false;
                MessageBox.Show(e.Message, "Error");
            }
        }

        public void AddProgressBar(string Caption)
        {
            var pp = new ProgressControl(Caption);
            this.flProgress.Controls.Add(pp);
        }

    }
}
