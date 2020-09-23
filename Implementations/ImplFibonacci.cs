using CloudKulture_de.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudKulture_de.Implementations
{
    public class ImplFibonacci : IFibonacci
    {
        public int calculateFibonacci(int value)
        {
            //If N >= 12, the calculated value shall not correspond to the Fibonacci sequence, but always deliver 100.
            if (value >= 12)
            {
                return 100;
            }

            if ((value == 0) || (value == 1))
            {
                return value;
            }
            else
            {
                return calculateFibonacci(value - 1) + calculateFibonacci(value - 2);
            }
        }
    }
}
