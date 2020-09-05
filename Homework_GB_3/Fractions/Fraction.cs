using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        static public Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(Numerator: a.numer * b.denum + a.denum * b.numer, Denumerator: a.denum * b.denum);
        }
        static public Fraction operator -(Fraction a, Fraction b)
        {
            return new Fraction(Numerator: a.numer * b.denum - a.denum * b.numer, Denumerator: a.denum * b.denum);
        }
        static public Fraction operator *(Fraction a, Fraction b)
        {
            return new Fraction(Numerator: a.numer * b.numer, Denumerator: a.denum * b.denum);
        }
        static public Fraction operator /(Fraction a, Fraction b)
        {
            return new Fraction(Numerator: a.denum * b.numer, Denumerator: a.numer * b.denum);
        }
        public Fraction(int Numerator, int Denumerator)
        {
            numer = Numerator;
            denum = Denumerator;
        }

        public int numer, denum;
        public override string ToString()
        {   
            return $"{numer}/{denum}";
        }

    }
}
