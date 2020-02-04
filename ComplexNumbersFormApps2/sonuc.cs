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
    public partial class sonuc : Form
    {
        public sonuc()
        {
            InitializeComponent();

            label1.Text = Form1.a.ToString();

            if (Form1.b<0)
            {
                label2.Text = Form1.b.ToString() + "i";
            }
            else 
            { 
            label2.Text ="+ " + Form1.b.ToString() + "i";    
            }
        }

        private void sonuc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
