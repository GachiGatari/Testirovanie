using Testirovanie.Lab1;

namespace Testirovanie.Lab3
{
    public class Lab3_Func
    {
        public static double Factorial(int num)
        {
            if (num <= 1)
            {
                return 1d;
            }

            return num * Factorial(num - 1);
        }

        public static double Power(double num, int pow)
        {
            if (pow == 0)
            {
                return 1;
            }

            return num * Power(num, pow - 1);
        }

        public static double Abs(double num)
        {
            if (num >= 0)
            {
                return num;
            }

            return -num;
        }
        public static double Sin(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n + 1) / Factorial((2 * n + 1));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Sin(x, n + 1, precision);
        }
        
        public static double Cos(double x, int n = 0, double precision = 1e-10)
        {
            var t = Power(-1, n) * Power(x, 2 * n) / Factorial((2 * n));
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Cos(x, n + 1, precision);
        }
        
        public static double Ln(double x, int n = 1, double precision = 1e-10)
        {
            var t = Power(-1, n+1) * (Power(x-1,n) / n );
            if (Abs(t) < precision)
            {
                return t;
            }

            return t + Ln(x, n + 1, precision);
        }

        public static double MyFunc(double x)
        {
            if (x >= 0)
            {
                return Ln(Abs(x)) * Cos(x);
            }

            return (Abs(Sin(x) - Cos(x))) / Ln(Abs(x)) + 1;
        }
        
    }
}