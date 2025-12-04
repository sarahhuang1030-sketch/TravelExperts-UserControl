namespace AddAgency
{
    partial class frmAddAgency
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
            btnAddAgency = new Button();
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
            txtProv = new TextBox();
            txtFax = new TextBox();
            label7 = new Label();
            txtCity = new TextBox();
            SuspendLayout();
            // 
            // btnAddAgency
            // 
            btnAddAgency.Location = new Point(570, 367);
            btnAddAgency.Name = "btnAddAgency";
            btnAddAgency.Size = new Size(112, 34);
            btnAddAgency.TabIndex = 25;
            btnAddAgency.Text = "Add";
            btnAddAgency.UseVisualStyleBackColor = true;
            btnAddAgency.Click += btnAddAgency_Click_1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(246, 365);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 24;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(246, 241);
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(150, 31);
            txtPostalCode.TabIndex = 23;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(246, 299);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(150, 31);
            txtCountry.TabIndex = 22;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(246, 50);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 365);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 19;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 244);
            label5.Name = "label5";
            label5.Size = new Size(106, 25);
            label5.TabIndex = 18;
            label5.Text = "Postal Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 181);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 17;
            label4.Text = "Province";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 299);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 16;
            label3.Text = "Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 123);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 15;
            label2.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 53);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 14;
            label1.Text = "Address";
            // 
            // txtProv
            // 
            txtProv.Location = new Point(246, 181);
            txtProv.Name = "txtProv";
            txtProv.Size = new Size(150, 31);
            txtProv.TabIndex = 26;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(570, 208);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(150, 31);
            txtFax.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(507, 211);
            label7.Name = "label7";
            label7.Size = new Size(37, 25);
            label7.TabIndex = 27;
            label7.Text = "Fax";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(246, 117);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(150, 31);
            txtCity.TabIndex = 29;
            // 
            // frmAddAgency
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCity);
            Controls.Add(txtFax);
            Controls.Add(label7);
            Controls.Add(txtProv);
            Controls.Add(btnAddAgency);
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
            Name = "frmAddAgency";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAgency;
        private Button btnAddAgency;
        private TextBox txtPhone;
        private TextBox txtPostalCode;
        private TextBox txtCountry;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtProv;
        private TextBox txtFax;
        private Label label7;
        private TextBox txtCity;
    }
}
