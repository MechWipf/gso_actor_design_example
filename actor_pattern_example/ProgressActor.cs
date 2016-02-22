using Akka;
using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actor_pattern_example
{
    public class ProgressMsg
    {
        public ProgressMsg(int WorkId, int Progress)
        {
            this.WorkId = WorkId;
            this.Progress = Progress;
        }

        public int WorkId { get; private set; }
        public int Progress { get; private set; }
    }

    public class ProgressStartMsg : ProgressMsg
    {
        public ProgressStartMsg(int WorkId, int Progress)
            : base(WorkId, Progress)
        { }
    }

    public class ProgressFinishMsg : ProgressMsg
    {
        public ProgressFinishMsg(int WorkId, int Progress)
            : base(WorkId, Progress)
        { }
    }

    class ProgressActor : UntypedActor
    {
        Action<string> textBox;

        public ProgressActor(Func<Action<string>> textBox)
        {
            this.textBox = textBox();
        }

        override protected void OnReceive(object message)
        {
            var progressMsg = message as ProgressMsg;

            if (progressMsg != null)
            {
                progressMsg.Match()
                    .With<ProgressStartMsg>(_ =>
                    {
                        textBox(string.Format("Prime {0} started calculating.\n", progressMsg.WorkId));
                    })
                    .With<ProgressFinishMsg>(_ =>
                    {
                        textBox(string.Format("Prime {0} finished calculating.\n", progressMsg.WorkId));
                    })
                    .Default(_ => { });
            }
        }
    }
}
