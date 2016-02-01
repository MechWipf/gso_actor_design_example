using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Event;

namespace actor_pattern_example
{
    class CalcPrime
    {
        public ProgressControl Progress { get; private set; }
        public int Prime { get; private set; }

        public CalcPrime(int Prime, ProgressControl Progress)
        {
            this.Prime = Prime;
            this.Progress = Progress;
        }
    }

    class CalculatePrimeActor : ReceiveActor
    {

    }
}
