using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public abstract class FibonacciWriter
    {
        public void Write(uint n)
        {
            uint prev = 0;
            uint next = 1;

            Output(prev);

            uint i = 1;

            while(i++ < n)
            {
                var next2 = prev + next;
                prev = next;
                next = next2;

                Output(prev);
            }
        }

        protected abstract void Output(uint i);
    }

    public class FibonacciConsoleWriter : FibonacciWriter
    {
        protected override void Output(uint i) =>
            Console.Write($"{i} ");
    }
}