﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        BigInteger prime1;
        BigInteger prime2;
        private BigInteger mod;

        CreateFile primeFile = new CreateFile();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(textBox1.Text, out prime1) && BigInteger.TryParse(textBox2.Text, out prime2))
            {
                if (prime1 != prime2)
                {
                    Prime checkPrime1 = new Prime(prime1);
                    Prime checkPrime2 = new Prime(prime2);

                    if (checkPrime1.calculateIfPrime() && checkPrime2.calculateIfPrime())
                    {
                        /*Numbers are prime*/
                        mod = prime1 * prime2;

                        primeText.Text = mod + " is the public key";

                        primeFile.CreateFilePrime(prime1, prime2, mod);

                        Form2 form = new Form2(this);
                        form.Show();
                    }
                    else
                    {
                        /*Numbers are even*/
                        primeText.Text = "Please enter prime numbers";
                    }
                }
                else
                {
                    primeText.Text = "Please enter unique Numbers";
                }
            }
            else
            {
                primeText.Text = "Please enter numbers";
            }
        }

        public BigInteger getMod()
        {
            return mod;
        }

        public BigInteger getPrime1()
        {
            return prime1;
        }

        public BigInteger getPrime2()
        {
            return prime2;
        }
    }
}