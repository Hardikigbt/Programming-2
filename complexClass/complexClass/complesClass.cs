using System;
namespace complexClass
{
	public class complesClass
	{
		public complesClass()
		{

            public int Real { get; }
        public int Imaginary { get; }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Argument => Math.Atan2(Imaginary, Real);

        public static Complex Zero => new Complex(0, 0);

        public Complex()
        {
            Real = 1;
            Imaginary = 1;
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

    }
}
}

