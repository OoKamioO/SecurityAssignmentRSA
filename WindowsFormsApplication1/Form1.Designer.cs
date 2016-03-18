namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.primeText = new System.Windows.Forms.Label();
            this.setPrimes = new System.Windows.Forms.Button();
            this.primePanel = new System.Windows.Forms.Panel();
            this.setKeysPanel = new System.Windows.Forms.Panel();
            this.KeysText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.encryptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SUBMIT_KEYS = new System.Windows.Forms.Button();
            this.decrpytBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.topMenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.encryptTextPanel = new System.Windows.Forms.Panel();
            this.encryptButton = new System.Windows.Forms.Button();
            this.EncryptBox = new System.Windows.Forms.TextBox();
            this.encryptTextLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setDecryptPanel = new System.Windows.Forms.Panel();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptTextLink = new System.Windows.Forms.TextBox();
            this.decryptIndicatorText = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.primePanel.SuspendLayout();
            this.setKeysPanel.SuspendLayout();
            this.topMenuLayout.SuspendLayout();
            this.encryptTextPanel.SuspendLayout();
            this.setDecryptPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(452, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prime 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prime 2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(452, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(28, 320);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(500, 91);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // primeText
            // 
            this.primeText.AutoSize = true;
            this.primeText.Location = new System.Drawing.Point(335, 114);
            this.primeText.Name = "primeText";
            this.primeText.Size = new System.Drawing.Size(172, 25);
            this.primeText.TabIndex = 0;
            this.primeText.Text = "ENTER VALUES";
            // 
            // setPrimes
            // 
            this.setPrimes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setPrimes.Location = new System.Drawing.Point(0, 0);
            this.setPrimes.Margin = new System.Windows.Forms.Padding(0);
            this.setPrimes.Name = "setPrimes";
            this.setPrimes.Size = new System.Drawing.Size(211, 64);
            this.setPrimes.TabIndex = 0;
            this.setPrimes.Text = "PRIMES";
            this.setPrimes.UseVisualStyleBackColor = true;
            this.setPrimes.Click += new System.EventHandler(this.button1_Click);
            // 
            // primePanel
            // 
            this.primePanel.Controls.Add(this.setKeysPanel);
            this.primePanel.Controls.Add(this.label1);
            this.primePanel.Controls.Add(this.primeText);
            this.primePanel.Controls.Add(this.button1);
            this.primePanel.Controls.Add(this.SubmitButton);
            this.primePanel.Controls.Add(this.label3);
            this.primePanel.Controls.Add(this.label2);
            this.primePanel.Controls.Add(this.textBox2);
            this.primePanel.Controls.Add(this.textBox1);
            this.primePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.primePanel.Location = new System.Drawing.Point(0, 64);
            this.primePanel.Margin = new System.Windows.Forms.Padding(0);
            this.primePanel.Name = "primePanel";
            this.primePanel.Size = new System.Drawing.Size(846, 461);
            this.primePanel.TabIndex = 9;
            this.primePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // setKeysPanel
            // 
            this.setKeysPanel.Controls.Add(this.encryptTextPanel);
            this.setKeysPanel.Controls.Add(this.KeysText);
            this.setKeysPanel.Controls.Add(this.label6);
            this.setKeysPanel.Controls.Add(this.encryptionBox);
            this.setKeysPanel.Controls.Add(this.label4);
            this.setKeysPanel.Controls.Add(this.SUBMIT_KEYS);
            this.setKeysPanel.Controls.Add(this.decrpytBox);
            this.setKeysPanel.Controls.Add(this.label5);
            this.setKeysPanel.Location = new System.Drawing.Point(0, 0);
            this.setKeysPanel.Name = "setKeysPanel";
            this.setKeysPanel.Size = new System.Drawing.Size(846, 461);
            this.setKeysPanel.TabIndex = 9;
            this.setKeysPanel.Visible = false;
            this.setKeysPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.setKeysPanel_Paint);
            // 
            // KeysText
            // 
            this.KeysText.AutoSize = true;
            this.KeysText.Location = new System.Drawing.Point(333, 114);
            this.KeysText.Name = "KeysText";
            this.KeysText.Size = new System.Drawing.Size(189, 25);
            this.KeysText.TabIndex = 15;
            this.KeysText.Text = "SET KEYS IN SET";
            this.KeysText.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(696, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "SET ENCRYPT AND DECRYPT KEYS";
            // 
            // encryptionBox
            // 
            this.encryptionBox.Location = new System.Drawing.Point(558, 241);
            this.encryptionBox.Name = "encryptionBox";
            this.encryptionBox.Size = new System.Drawing.Size(100, 31);
            this.encryptionBox.TabIndex = 9;
            this.encryptionBox.TextChanged += new System.EventHandler(this.encryptionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Encryption Key from Set";
            // 
            // SUBMIT_KEYS
            // 
            this.SUBMIT_KEYS.Location = new System.Drawing.Point(289, 330);
            this.SUBMIT_KEYS.Name = "SUBMIT_KEYS";
            this.SUBMIT_KEYS.Size = new System.Drawing.Size(253, 82);
            this.SUBMIT_KEYS.TabIndex = 11;
            this.SUBMIT_KEYS.Text = "SUBMIT";
            this.SUBMIT_KEYS.UseVisualStyleBackColor = true;
            this.SUBMIT_KEYS.Click += new System.EventHandler(this.button6_Click);
            // 
            // decrpytBox
            // 
            this.decrpytBox.Location = new System.Drawing.Point(559, 176);
            this.decrpytBox.Name = "decrpytBox";
            this.decrpytBox.Size = new System.Drawing.Size(100, 31);
            this.decrpytBox.TabIndex = 8;
            this.decrpytBox.TextChanged += new System.EventHandler(this.decrpytBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Decryption Key from Set";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "SET PRIME NUMBERS";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(573, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 91);
            this.button1.TabIndex = 3;
            this.button1.Text = "GEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // topMenuLayout
            // 
            this.topMenuLayout.ColumnCount = 4;
            this.topMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.topMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topMenuLayout.Controls.Add(this.setPrimes, 0, 0);
            this.topMenuLayout.Controls.Add(this.button2, 1, 0);
            this.topMenuLayout.Controls.Add(this.button4, 2, 0);
            this.topMenuLayout.Controls.Add(this.button5, 3, 0);
            this.topMenuLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.topMenuLayout.Location = new System.Drawing.Point(0, 0);
            this.topMenuLayout.Margin = new System.Windows.Forms.Padding(0);
            this.topMenuLayout.Name = "topMenuLayout";
            this.topMenuLayout.RowCount = 1;
            this.topMenuLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topMenuLayout.Size = new System.Drawing.Size(846, 64);
            this.topMenuLayout.TabIndex = 7;
            this.topMenuLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(211, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "SET KEYS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(422, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(211, 64);
            this.button4.TabIndex = 3;
            this.button4.Text = "ENCRYPT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(633, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 64);
            this.button5.TabIndex = 4;
            this.button5.Text = "DECRYPT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // encryptTextPanel
            // 
            this.encryptTextPanel.Controls.Add(this.setDecryptPanel);
            this.encryptTextPanel.Controls.Add(this.encryptButton);
            this.encryptTextPanel.Controls.Add(this.EncryptBox);
            this.encryptTextPanel.Controls.Add(this.encryptTextLabel);
            this.encryptTextPanel.Controls.Add(this.label8);
            this.encryptTextPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.encryptTextPanel.Location = new System.Drawing.Point(0, 0);
            this.encryptTextPanel.Name = "encryptTextPanel";
            this.encryptTextPanel.Size = new System.Drawing.Size(846, 461);
            this.encryptTextPanel.TabIndex = 10;
            this.encryptTextPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.encryptTextPanel_Paint);
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(292, 345);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(236, 67);
            this.encryptButton.TabIndex = 10;
            this.encryptButton.Text = "ENCRYPT";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // EncryptBox
            // 
            this.EncryptBox.Location = new System.Drawing.Point(144, 153);
            this.EncryptBox.Multiline = true;
            this.EncryptBox.Name = "EncryptBox";
            this.EncryptBox.Size = new System.Drawing.Size(526, 161);
            this.EncryptBox.TabIndex = 9;
            this.EncryptBox.TextChanged += new System.EventHandler(this.EncryptBox_TextChanged);
            // 
            // encryptTextLabel
            // 
            this.encryptTextLabel.AutoSize = true;
            this.encryptTextLabel.Location = new System.Drawing.Point(335, 101);
            this.encryptTextLabel.Name = "encryptTextLabel";
            this.encryptTextLabel.Size = new System.Drawing.Size(149, 25);
            this.encryptTextLabel.TabIndex = 8;
            this.encryptTextLabel.Text = "ENTER TEXT ";
            this.encryptTextLabel.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(303, 42);
            this.label8.TabIndex = 7;
            this.label8.Text = "ENCRYPT TEXT";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // setDecryptPanel
            // 
            this.setDecryptPanel.Controls.Add(this.decryptButton);
            this.setDecryptPanel.Controls.Add(this.decryptTextLink);
            this.setDecryptPanel.Controls.Add(this.decryptIndicatorText);
            this.setDecryptPanel.Controls.Add(this.label9);
            this.setDecryptPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.setDecryptPanel.Location = new System.Drawing.Point(0, 0);
            this.setDecryptPanel.Name = "setDecryptPanel";
            this.setDecryptPanel.Size = new System.Drawing.Size(846, 461);
            this.setDecryptPanel.TabIndex = 11;
            this.setDecryptPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(333, 272);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(151, 67);
            this.decryptButton.TabIndex = 10;
            this.decryptButton.Text = "DECRYPT";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptTextLink
            // 
            this.decryptTextLink.Location = new System.Drawing.Point(225, 201);
            this.decryptTextLink.Name = "decryptTextLink";
            this.decryptTextLink.Size = new System.Drawing.Size(366, 31);
            this.decryptTextLink.TabIndex = 9;
            this.decryptTextLink.TextChanged += new System.EventHandler(this.decryptTextLink_TextChanged);
            // 
            // decryptIndicatorText
            // 
            this.decryptIndicatorText.AutoSize = true;
            this.decryptIndicatorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptIndicatorText.Location = new System.Drawing.Point(219, 126);
            this.decryptIndicatorText.Name = "decryptIndicatorText";
            this.decryptIndicatorText.Size = new System.Drawing.Size(376, 33);
            this.decryptIndicatorText.TabIndex = 8;
            this.decryptIndicatorText.Text = "ENTER CIPHER FILEPATH";
            this.decryptIndicatorText.Click += new System.EventHandler(this.label7_Click_2);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(266, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(315, 42);
            this.label9.TabIndex = 7;
            this.label9.Text = "DECRYPT TEXT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 525);
            this.Controls.Add(this.topMenuLayout);
            this.Controls.Add(this.primePanel);
            this.Name = "Form1";
            this.Text = "RSA Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.primePanel.ResumeLayout(false);
            this.primePanel.PerformLayout();
            this.setKeysPanel.ResumeLayout(false);
            this.setKeysPanel.PerformLayout();
            this.topMenuLayout.ResumeLayout(false);
            this.encryptTextPanel.ResumeLayout(false);
            this.encryptTextPanel.PerformLayout();
            this.setDecryptPanel.ResumeLayout(false);
            this.setDecryptPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label primeText;
        private System.Windows.Forms.Button setPrimes;
        private System.Windows.Forms.Panel primePanel;
        private System.Windows.Forms.TableLayoutPanel topMenuLayout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel setKeysPanel;
        private System.Windows.Forms.TextBox encryptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SUBMIT_KEYS;
        private System.Windows.Forms.TextBox decrpytBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label KeysText;
        private System.Windows.Forms.Panel encryptTextPanel;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.TextBox EncryptBox;
        private System.Windows.Forms.Label encryptTextLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel setDecryptPanel;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox decryptTextLink;
        private System.Windows.Forms.Label decryptIndicatorText;
        private System.Windows.Forms.Label label9;
    }
}

