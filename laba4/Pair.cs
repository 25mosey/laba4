using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    partial class Pair
    {
        public double A { get; set; }
        public double B { get; set; }
        public Pair(double a, double b)
        {
            A = a;
            B = b;
        }
        public double summ()
        {
            return A + B;
        }
        public double Diff()
        {
            return A - B;
        }
        public double Multi()
        {
            return A * B;
        }
        public double Divis()
        {
            return A / B;
        }
    }
}
