namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.decrpytBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.decryptText = new System.Windows.Forms.Label();
            this.encryptionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.encryptText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "RSA Algorithm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decryption Key from Set";
            // 
            // decrpytBox
            // 
            this.decrpytBox.Location = new System.Drawing.Point(378, 108);
            this.decrpytBox.Name = "decrpytBox";
            this.decrpytBox.Size = new System.Drawing.Size(100, 31);
            this.decrpytBox.TabIndex = 1;
            this.decrpytBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 82);
            this.button1.TabIndex = 3;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // decryptText
            // 
            this.decryptText.AutoSize = true;
            this.decryptText.Location = new System.Drawing.Point(55, 360);
            this.decryptText.Name = "decryptText";
            this.decryptText.Size = new System.Drawing.Size(0, 25);
            this.decryptText.TabIndex = 4;
            this.decryptText.Click += new System.EventHandler(this.decryptText_Click);
            // 
            // encryptionBox
            // 
            this.encryptionBox.Location = new System.Drawing.Point(379, 170);
            this.encryptionBox.Name = "encryptionBox";
            this.encryptionBox.Size = new System.Drawing.Size(100, 31);
            this.encryptionBox.TabIndex = 2;
            this.encryptionBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Encryption Key from Set";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // encryptText
            // 
            this.encryptText.AutoSize = true;
            this.encryptText.Location = new System.Drawing.Point(55, 423);
            this.encryptText.Name = "encryptText";
            this.encryptText.Size = new System.Drawing.Size(0, 25);
            this.encryptText.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 489);
            this.Controls.Add(this.encryptText);
            this.Controls.Add(this.encryptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.decryptText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decrpytBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decrpytBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label decryptText;
        private System.Windows.Forms.TextBox encryptionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label encryptText;
    }
}