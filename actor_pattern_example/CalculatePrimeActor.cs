using System.Threading;
using Akka.Actor;
using System;

namespace actor_pattern_example
{
    class CalculatePrimeActor : ReceiveActor
    {
        Action<int> setProgress;

        public CalculatePrimeActor( Func<Action<int>> progressBar )
        {
            this.setProgress = progressBar();

            Receive<int>( ( prime ) => { CalculatePrime( prime ); } );
        }

        public void CalculatePrime( int prime )
        {
            setProgress( 0 );
            Thread.Sleep( 1000 );
            setProgress( 50 );
            Thread.Sleep( 2000 );
            setProgress( 100 );
        }
    }
}
