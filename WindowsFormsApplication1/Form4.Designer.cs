namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.decryptTextLink = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptedText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "RSA Algorithm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter filepath to cipher";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // decryptTextLink
            // 
            this.decryptTextLink.Location = new System.Drawing.Point(105, 155);
            this.decryptTextLink.Name = "decryptTextLink";
            this.decryptTextLink.Size = new System.Drawing.Size(366, 31);
            this.decryptTextLink.TabIndex = 5;
            this.decryptTextLink.TextChanged += new System.EventHandler(this.decryptTextLink_TextChanged);
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(203, 210);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(151, 67);
            this.decryptButton.TabIndex = 6;
            this.decryptButton.Text = "DECRYPT";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // decryptedText
            // 
            this.decryptedText.AutoSize = true;
            this.decryptedText.Location = new System.Drawing.Point(238, 297);
            this.decryptedText.Name = "decryptedText";
            this.decryptedText.Size = new System.Drawing.Size(0, 25);
            this.decryptedText.TabIndex = 7;
            this.decryptedText.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 353);
            this.Controls.Add(this.decryptedText);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decryptTextLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox decryptTextLink;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.Label decryptedText;
    }
}