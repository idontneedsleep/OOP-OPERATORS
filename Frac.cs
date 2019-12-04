using System;
using System.Collections.Generic;
using System.Text;

namespace clowncheck
{
    public class Frac
    {
        protected long Numerator;
        protected long Denominator;
        public Frac(long num, long den)
        {
            Numerator = num;
            Denominator = den;
        }
        public Frac(long numer)
        {
            Numerator = numer;
            Denominator = 1;
        }
        public Frac(double val)
        {

        }
        public void Simlify()
        {

        }
        public void Fix()
        {
            if (Denominator <= 0 && Numerator <= 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
            if (Denominator <= 0 && Numerator >= 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
        public static Frac operator + (Frac a, Frac b)
        {
            Frac res = new Frac(a.Numerator * b.Denominator + 
                a.Denominator * b.Numerator, 
                a.Denominator * b.Numerator);
            res.Simlify();
            res.Fix();
            return res;
        }
        public static Frac operator +(Frac a)
        {
            a.Fix();
            return a;
        }
        public static Frac operator + (Frac a, long b)
        {
            return a + new Frac(b);
        }
        public static Frac operator +(long a, Frac b)
        {
            return new Frac(a) + b;
        }
        public static Frac operator *(Frac a, Frac b)
        {
            Frac res = new Frac(a.Numerator * b.Numerator, b.Denominator * a.Denominator);
            res.Simlify();
            res.Fix();
            return res;
        }
        public static Frac operator -(Frac a)
        {
            return new Frac(-a.Numerator, a.Denominator);
        }
        public static Frac operator !(Frac a)
        {
            Frac res = new Frac(a.Denominator, a.Numerator);
            res.Fix();
            return res;
        }
        public static Frac operator /(Frac a, Frac b)
        {
            Frac res =  a * !b;
            res.Simlify();
            res.Fix();
            return res;
        }
        public static implicit operator double (Frac a)
        {
            return (double)a.Numerator / a.Denominator;
        }
      public static bool operator == (Frac a, Frac b)
        {
            return a == b;
        }
        public static bool operator !=(Frac a, Frac b)
        {
            return a != b;
        }
        public static bool operator >(Frac a, Frac b)
        {
            return a > b;
        }
        public static bool operator <(Frac a, Frac b)
        {
            return a < b;
        }
        public static bool operator >=(Frac a, Frac b)
        {
            return a >= b;
        }
        public static bool operator <=(Frac a, Frac b)
        {
            return a <= b;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
