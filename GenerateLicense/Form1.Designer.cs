namespace GenerateLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.productID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.licensekey = new System.Windows.Forms.TextBox();
            this.generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductID";
            // 
            // productID
            // 
            this.productID.Location = new System.Drawing.Point(152, 26);
            this.productID.Name = "productID";
            this.productID.Size = new System.Drawing.Size(332, 20);
            this.productID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "License Key";
            // 
            // licensekey
            // 
            this.licensekey.Location = new System.Drawing.Point(152, 67);
            this.licensekey.Name = "licensekey";
            this.licensekey.Size = new System.Drawing.Size(332, 20);
            this.licensekey.TabIndex = 1;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(415, 105);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(147, 33);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 152);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.licensekey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LicenseGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox licensekey;
        private System.Windows.Forms.Button generate;
    }
}

