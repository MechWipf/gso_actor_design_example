using System.Threading;
using Akka.Actor;
using System;

namespace actor_pattern_example
{
    class WorkActor : ReceiveActor
    {
        Action<int,string> setProgress;

        public WorkActor(Func<Action<int,string>> progressBar)
        {
            this.setProgress = progressBar();

            Receive<int>((num) => { DoWork(num); });
        }

        public void DoWork(int num)
        {
            setProgress(0, "" + Self.Path.Uid + " Check: " + num);
            Context.ActorSelection("akka://TheSystem/user/progress").Tell(new ProgressStartMsg(num, 0));

            var time = System.DateTime.UtcNow;
            var max = Math.Pow( num, 2.0 );
            for (int i = 0; i < max; i++)
            {
                for (int k = 0; k < 1000000; k++) ;

                if (time < System.DateTime.UtcNow)
                {
                    setProgress( (int)( i / max * 100 ), "" );
                    time = System.DateTime.UtcNow.AddMilliseconds(250);
                }
            }
            setProgress( 0, "" + Self.Path.Uid );
            Context.ActorSelection("akka://TheSystem/user/progress").Tell(new ProgressFinishMsg(num, 100));
        }
    }
}
