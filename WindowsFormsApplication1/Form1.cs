using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int prime1;
        int prime2;

        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out prime1))
            {
                Prime checkPrime = new Prime(prime1);

                if (checkPrime.calculateIfPrime())
                {
                    primeText.Text = "Is an Prime Number";
                }
                else
                {
                    primeText.Text = "Is an Even Number";
                }
            }
            else
            {
                primeText.Text = "Please enter numbers";
            }
        }
    }
}
