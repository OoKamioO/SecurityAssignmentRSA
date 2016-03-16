using System;
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
        public RSA_Primes primeOptions = new RSA_Primes();
        public RSA_KEYS keyOptions;
        public RSA_Encrypt encryptOptions;
        public RSA_decrypt decryptOptions;

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if((textBox1.Text.Trim().Length != 0) 
                && (textBox2.Text.Trim().Length != 0))
            {
                primeText.Text = primeOptions.checkNumbers(textBox1.Text, textBox2.Text);
            }
            else
            {
                primeText.Text = primeOptions.noValueText();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if((decrpytBox.Text.Trim().Length != 0) 
                && (encryptionBox.Text.Trim().Length != 0))
            {
                keyOptions = new RSA_KEYS(this);
                KeysText.Text = keyOptions.checkKeys(encryptionBox.Text, decrpytBox.Text);
            }
            else
            {
                KeysText.Text = primeOptions.noValueText();
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptBox.Text.Trim().Length != 0)
            {
                encryptOptions = new RSA_Encrypt(this);
                encryptTextLabel.Text = encryptOptions.encryptText(EncryptBox.Text);
            }
            else
            {
                encryptTextLabel.Text = primeOptions.noValueText();
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if(decryptTextLink.Text.Trim().Length != 0)
            {
                decryptOptions = new RSA_decrypt(this, decryptTextLink.Text);

                decryptIndicatorText.Text = decryptOptions.decryptText();
            }
            else
            {
                decryptIndicatorText.Text = primeOptions.noValueText();
            }
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            primePanel.Visible = true;
            setKeysPanel.Visible = false;
            encryptTextPanel.Visible = false;
            setDecryptPanel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setKeysPanel.Visible = true;
            encryptTextPanel.Visible = false;
            setDecryptPanel.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            encryptTextPanel.Visible = true;
            setDecryptPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            setDecryptPanel.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void setKeysPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void decrpytBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void encryptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void encryptTextPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void EncryptBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click_2(object sender, EventArgs e)
        {

        }

        private void decryptTextLink_TextChanged(object sender, EventArgs e)
        {

        }
    }
}