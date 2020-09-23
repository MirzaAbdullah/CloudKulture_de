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
