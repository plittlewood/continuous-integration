using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ci_demo_api
{
    public static class MathHelper
    {
        public static int Multiply(int numA, int numB)
        {
            return numA * numB;
        }

        public static decimal Divide(int numA, int numB)
        {
            return numA / numB;
        }
    }
}