using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbersFormApps2
{
    class Complex
    {
        public double Real { get; }  //Karmaşık sayının Real kısmi 
        public double Imaginary { get; }  // Karmaşık sayının İmajiner kısmı
        public Complex(double real, double imaginary)
        {
            Real = real;                    // Karmaşık sayıyı oluşturduk
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex one, Complex two)
        {
            return new Complex(one.Real + two.Real, one.Imaginary + two.Imaginary); // Karmaşık sayı da toplama işlemi
        }

        public static Complex operator -(Complex one, Complex two)
        {
            return new Complex(one.Real - two.Real, one.Imaginary - two.Imaginary); // Karmaşık sayılarda çıkarma işlemi
        }

    }
}
