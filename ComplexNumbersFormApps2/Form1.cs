using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexNumbersFormApps2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Complex c1 = new Complex(1.5, 3.3);          Burada denemeler yaptım.
        // Complex c2 = new  Complex(2.2, 3.4);         Burayı dikkate almanıza gerek yok
        // double a = 0, b = 0, c = 0, d = 0;

        public static double a, b;  

        private void button1_Click(object sender, EventArgs e)
        {
           
            Complex c1 = new Complex(Convert.ToDouble(textReal1.Text), Convert.ToDouble(textImag1.Text));
            Complex c2 = new Complex(Convert.ToDouble(textReal2.Text), Convert.ToDouble(textImag2.Text));

            //Textboxtan karmaşık sayıyı aldık

            Complex Toplam = c1 + c2;       // Complex sınıfında oluşturduğumuz toplama operatorü ile toplama

            a = Toplam.Real;                // Complex'leri gönderemediğimiz için iki tana değer oluşturuyoruz
            b = Toplam.Imaginary;           //birisi Real değer tutuyor diğeri ise İmajiner değer

            sonuc cevap = new sonuc();
            cevap.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complex c1 = new Complex(Convert.ToDouble(textReal1.Text), Convert.ToDouble(textImag1.Text));
            Complex c2 = new Complex(Convert.ToDouble(textReal2.Text), Convert.ToDouble(textImag2.Text));

            Complex Cikarma = c1 - c2;    // Complex sınıfında oluşturduğumuz çıkarma operatorü ile çıkarma

            a = Cikarma.Real;           // Complex'leri gönderemediğimiz için iki tana değer oluşturuyoruz
            b = Cikarma.Imaginary;      //birisi Real değer tutuyor diğeri ise İmajiner değer

            sonuc cevap = new sonuc();
            cevap.Show();
        }
    }
}
