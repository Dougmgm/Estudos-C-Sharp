using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova_pasta.Models
{
    public struct Point
    {
        public double X, Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}