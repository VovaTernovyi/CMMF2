using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMMF2
{
    public class Integral
    {
        public delegate double Func(double x);

        public double SimpsonMethod(double a, double b, int n, Func func)
        {
            double h = (b - a) / n;
            double s = (func(a) + func(b)) * 0.5;

            for (int i = 1; i <= n - 1; i++)
            {
                double xk = a + h * i; //xk
                double xk1 = a + h * (i - 1); //Xk-1
                s += func(xk) + 2 * func((xk1 + xk) / 2);
            }

            var x = a + h * n; //xk
            var x1 = a + h * (n - 1); //Xk-1
            s += 2 * func((x1 + x) / 2);

            return s * h / 3.0;
        }
    }
}
