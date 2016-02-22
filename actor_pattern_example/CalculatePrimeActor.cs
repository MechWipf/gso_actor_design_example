using System.Threading;
using Akka.Actor;
using System;

namespace actor_pattern_example
{
    class CalculatePrimeActor : ReceiveActor
    {
        Action<int> setProgress;

        public CalculatePrimeActor(Func<Action<int>> progressBar)
        {
            this.setProgress = progressBar();

            Receive<int>((prime) => { CalculatePrime(prime); });
        }

        public void CalculatePrime(int prime)
        {
            setProgress(0);
            Context.ActorSelection("akka://TheSystem/user/progress").Tell(new ProgressStartMsg(prime, 0));
            for (int i = 0; i < 100; i++)
            {
                setProgress(i);
                Thread.Sleep(10 * (int)Math.Pow(prime, 1.01));
            }
            Context.ActorSelection("akka://TheSystem/user/progress").Tell(new ProgressFinishMsg(prime, 100));
        }
    }
}
