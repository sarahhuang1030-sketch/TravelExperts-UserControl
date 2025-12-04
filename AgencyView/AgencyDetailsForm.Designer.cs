namespace AgencyView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFax = new Label();
            lblPhone = new Label();
            lblPostalCode = new Label();
            lblProv = new Label();
            lblCountry = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // lblFax
            // 
            lblFax.AutoSize = true;
            lblFax.Location = new Point(488, 211);
            lblFax.Name = "lblFax";
            lblFax.Size = new Size(37, 25);
            lblFax.TabIndex = 42;
            lblFax.Text = "Fax";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(100, 365);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(62, 25);
            lblPhone.TabIndex = 35;
            lblPhone.Text = "Phone";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(100, 244);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(106, 25);
            lblPostalCode.TabIndex = 34;
            lblPostalCode.Text = "Postal Code";
            // 
            // lblProv
            // 
            lblProv.AutoSize = true;
            lblProv.Location = new Point(100, 181);
            lblProv.Name = "lblProv";
            lblProv.Size = new Size(79, 25);
            lblProv.TabIndex = 33;
            lblProv.Text = "Province";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(100, 299);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(75, 25);
            lblCountry.TabIndex = 32;
            lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(100, 123);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(42, 25);
            lblCity.TabIndex = 31;
            lblCity.Text = "City";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(100, 53);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(77, 25);
            lblAddress.TabIndex = 30;
            lblAddress.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFax);
            Controls.Add(lblPhone);
            Controls.Add(lblPostalCode);
            Controls.Add(lblProv);
            Controls.Add(lblCountry);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFax;
        private Label lblPhone;
        private Label lblPostalCode;
        private Label lblProv;
        private Label lblCountry;
        private Label lblCity;
        private Label lblAddress;
    }
}
