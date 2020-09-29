using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkGB2
{
    class Complex
    {
        static public Complex operator +(Complex x, Complex y)
        {
            return new Complex(Re: x.a + y.a, Im: x.b + y.b);
        }
        static public Complex operator -(Complex x, Complex y)
        {
            return new Complex(Re: x.a - y.a, Im: x.b - y.b);
        }
        static public Complex operator *(Complex x, Complex y)
        {
            return new Complex(Re: (x.a * y.a - x.b * y.b), Im: (x.a * y.b + y.a * x.b));
        }
        public Complex(double Re, double Im)
        {
            a = Re;
            b = Im;
        }

        public double a, b;
        public override string ToString()
        {
            if (b == 0) return $"{a}";
            else if (a == 0) return $"{b}i";
            else return (b< 0) ? $"{a} - {-b}i": $"{a} + {b}i";
        }

    }
}
