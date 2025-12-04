namespace EditAgency
{
    partial class frmEditAgency
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
            txtCity = new TextBox();
            txtFax = new TextBox();
            label7 = new Label();
            txtProv = new TextBox();
            btnEditAgency = new Button();
            txtPhone = new TextBox();
            txtPostalCode = new TextBox();
            txtCountry = new TextBox();
            txtAddress = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCity
            // 
            txtCity.Location = new Point(227, 117);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 44;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(551, 208);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(150, 31);
            txtFax.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(488, 211);
            label7.Name = "label7";
            label7.Size = new Size(37, 25);
            label7.TabIndex = 42;
            label7.Text = "Fax";
            // 
            // txtProv
            // 
            txtProv.Location = new Point(227, 181);
            txtProv.Name = "txtProv";
            txtProv.Size = new Size(150, 31);
            txtProv.TabIndex = 41;
            // 
            // btnEditAgency
            // 
            btnEditAgency.Location = new Point(551, 367);
            btnEditAgency.Name = "btnEditAgency";
            btnEditAgency.Size = new Size(112, 34);
            btnEditAgency.TabIndex = 40;
            btnEditAgency.Text = "Edit";
            btnEditAgency.UseVisualStyleBackColor = true;
            btnEditAgency.Click += btnEditAgency_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(227, 365);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 39;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(227, 241);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 31);
            txtPostalCode.TabIndex = 38;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(227, 299);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 37;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(227, 50);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(100, 365);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 35;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 244);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 34;
            label5.Text = "Postal Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 181);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 33;
            label4.Text = "Province";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 299);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 32;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 123);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 31;
            label2.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 53);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 30;
            label1.Text = "Address";
            // 
            // frmEditAgency
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCity);
            Controls.Add(txtFax);
            Controls.Add(label7);
            Controls.Add(txtProv);
            Controls.Add(btnEditAgency);
            Controls.Add(txtPhone);
            Controls.Add(txtPostalCode);
            Controls.Add(txtCountry);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditAgency";
            Text = "Form1";
            Load += frmEditAgency_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCity;
        private TextBox txtFax;
        private Label label7;
        private TextBox txtProv;
        private Button btnEditAgency;
        private TextBox txtPhone;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtAddress;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
