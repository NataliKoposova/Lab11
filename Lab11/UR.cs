using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    internal class UR
    {//0=kx+b
        double k;
        double b;


        public UR(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            double x = (-b) / k;
            if (x == 0 || k <= 0)
                return "Решений нет";
            double r1 = (-b) / k;
            return $"X={r1}";
        }
    }
}
