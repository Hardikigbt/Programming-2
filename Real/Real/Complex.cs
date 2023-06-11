using System;
namespace Real
{
    using System;

    public class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Argument => Math.Atan2(Imaginary, Real);

        public static Complex Zero => new Complex(0, 0);

        public Complex()
        {
            Real = 0;
            Imaginary = 0;
        }

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public override string ToString()
        {
            return $"({Real}, {Imaginary})";
        }

        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);

        }

        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }

        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary;
        }

        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs == rhs);
        }
    }

}