using System;

namespace less_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rational number:");

            RationalNumbers rn1 = new RationalNumbers(1, 2);
            Console.WriteLine("number 1: " + rn1.ToString());

            RationalNumbers rn2 = new RationalNumbers(2, 3);
            Console.WriteLine("number 2: " + rn2.ToString());

            Console.WriteLine("\nResult:");

            Console.WriteLine("operator ==:      " + (rn1 == rn2));
            Console.WriteLine("operator !=:      " + (rn1 != rn2));
            Console.WriteLine("method Equals():  " + rn1.Equals(rn2));
            Console.WriteLine("operator <:       " + (rn1 < rn2));
            Console.WriteLine("operator >:       " + (rn1 > rn2));
            Console.WriteLine("operator <=:      " + (rn1 <= rn2));
            Console.WriteLine("operator >=:      " + (rn1 >= rn2));
            Console.WriteLine("operator +:       " + (rn1 + rn2).ToString());
            Console.WriteLine("operator -:       " + (rn1 - rn2).ToString());
            Console.WriteLine("operator ++:      " + (++rn1).ToString());
            Console.WriteLine("operator --:      " + (--rn1).ToString());
            Console.WriteLine("operator *:       " + (rn1 * rn2).ToString());
            Console.WriteLine("operator /:       " + (rn1 / rn2).ToString());
            Console.WriteLine("operator %:       " + (rn1 % rn2).ToString());
            Console.WriteLine("operator (float): " + (float)rn1);
            Console.WriteLine("operator (int):   " + (int)rn1);

            Console.WriteLine("\nComplex number:");

            ComplexNumber cn1 = new ComplexNumber(1, 5);
            Console.WriteLine("number 1: " + cn1.ToString());

            ComplexNumber cn2 = new ComplexNumber(3, 2);
            Console.WriteLine("number 2: " + cn2.ToString());

            Console.WriteLine("\nResult:");

            Console.WriteLine("operator ==:      " + (cn1 == cn2));
            Console.WriteLine("operator +:       " + (cn1 + cn2).ToString());
            Console.WriteLine("operator -:       " + (cn1 - cn2).ToString());
            Console.WriteLine("operator *:       " + (cn1 * cn2).ToString());

            Console.ReadKey();
        }
    }

    class RationalNumbers
    {
        private int _numerator;
        private int _denumerator;
        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }
        public int Denumerator
        {
            get
            {
                return _denumerator;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Denominator parameter error! Denominator set by default!");
                    _denumerator = 1;
                }
                _denumerator = value;
            }
        }
        public double FloatingNumber
        {
            get
            {
                return (double)_numerator / (double)_denumerator;
            }
        }
        public RationalNumbers(int param1, int param2)
        {
            Numerator = param1;
            Denumerator = param2;
        }
        public static bool operator ==(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.Numerator == rn2.Numerator && rn1.Denumerator == rn2.Denumerator);
        }
        public static bool operator !=(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.Numerator != rn2.Numerator || rn1.Denumerator != rn2.Denumerator);
        }
        public static bool operator >(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.FloatingNumber > rn2.FloatingNumber);
        }
        public static bool operator <(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.FloatingNumber < rn2.FloatingNumber);
        }
        public static bool operator >=(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.FloatingNumber >= rn2.FloatingNumber);
        }
        public static bool operator <=(RationalNumbers rn1, RationalNumbers rn2)
        {
            return (rn1.FloatingNumber <= rn2.FloatingNumber);
        }
        public static RationalNumbers operator +(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.Numerator * rn2.Denumerator + rn2.Numerator * rn1.Denumerator, rn1.Denumerator * rn2.Denumerator);
        }
        public static RationalNumbers operator -(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.Numerator * rn2.Denumerator - rn2.Numerator * rn1.Denumerator, rn1.Denumerator * rn2.Denumerator);
        }
        public static RationalNumbers operator ++(RationalNumbers rn1)
        {
            return new RationalNumbers(rn1.Numerator + rn1.Denumerator, rn1.Denumerator);
        }
        public static RationalNumbers operator --(RationalNumbers rn1)
        {
            return new RationalNumbers(rn1.Numerator - rn1.Denumerator, rn1.Denumerator);
        }
        public static RationalNumbers operator *(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.Numerator * rn2.Numerator, rn1.Denumerator * rn2.Denumerator);
        }
        public static RationalNumbers operator /(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers(rn1.Numerator * rn2.Denumerator, rn1.Denumerator * rn2.Numerator);
        }
        public static RationalNumbers operator %(RationalNumbers rn1, RationalNumbers rn2)
        {
            return new RationalNumbers((rn1.Numerator * rn2.Denumerator) % (rn1.Denumerator * rn2.Numerator), rn1.Denumerator * rn2.Numerator);
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}, {FloatingNumber}";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as RationalNumbers);
        }
        public bool Equals(RationalNumbers obj)
        {
            return FloatingNumber == obj.FloatingNumber;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static implicit operator double(RationalNumbers rn)
        {
            return rn.FloatingNumber;
        }
        public static explicit operator float(RationalNumbers rn)
        {
            return (float)rn.FloatingNumber;
        }
        public static explicit operator int(RationalNumbers rn)
        {
            return (int)rn.FloatingNumber;
        }
    }
    class ComplexNumber
    {
        private int _actualPart;
        private int _imaginaryPart;
        public int ActualPart
        {
            get
            {
                return _actualPart;
            }
            set
            {
                _actualPart = value;
            }
        }
        public int ImaginaryPart
        {
            get
            {
                return _imaginaryPart;
            }
            set
            {
                _imaginaryPart = value;
            }
        }
        public ComplexNumber(int param1, int param2)
        {
            ActualPart = param1;
            ImaginaryPart = param2;
        }
        public static ComplexNumber operator +(ComplexNumber cn1, ComplexNumber cn2)
        {
            return new ComplexNumber(cn1.ActualPart + cn2.ActualPart, cn1.ImaginaryPart + cn2.ImaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber cn1, ComplexNumber cn2)
        {
            return new ComplexNumber(cn1.ActualPart - cn2.ActualPart, cn1.ImaginaryPart - cn2.ImaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber cn1, ComplexNumber cn2)
        {
            return new ComplexNumber(cn1.ActualPart * cn2.ActualPart - cn1.ImaginaryPart * cn2.ImaginaryPart, cn1.ActualPart * cn2.ImaginaryPart + cn1.ImaginaryPart * cn2.ActualPart);
        }
        public static bool operator ==(ComplexNumber cn1, ComplexNumber cn2)
        {
            return (cn1.ActualPart == cn2.ActualPart && cn1.ImaginaryPart == cn2.ImaginaryPart);
        }
        public static bool operator !=(ComplexNumber cn1, ComplexNumber cn2)
        {
            return (cn1.ActualPart != cn2.ActualPart || cn1.ImaginaryPart != cn2.ImaginaryPart);
        }
        public override string ToString()
        {
            return $"{ActualPart}{ImaginaryPart.ToString("+#;-#;0")}i";
        }
        public override bool Equals(object obj)
        {
            return Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
