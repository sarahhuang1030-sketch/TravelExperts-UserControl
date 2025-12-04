namespace EditAgent
{
    partial class frmEditAgent
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
            lstAgency = new ListBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtPosition = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnEditAgent = new Button();
            SuspendLayout();
            // 
            // lstAgency
            // 
            lstAgency.FormattingEnabled = true;
            lstAgency.Items.AddRange(new object[] { "Calgary", "Okotoks" });
            lstAgency.Location = new Point(215, 240);
            lstAgency.Name = "lstAgency";
            lstAgency.Size = new Size(180, 54);
            lstAgency.TabIndex = 25;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(216, 367);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 309);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 23;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(216, 190);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 31);
            txtPosition.TabIndex = 22;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(216, 119);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 21;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(216, 52);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 367);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 19;
            label6.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 312);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 18;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 249);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 17;
            label4.Text = "Agency";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 190);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 16;
            label3.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 125);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 15;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 55);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 14;
            label1.Text = "First Name";
            // 
            // btnEditAgent
            // 
            btnEditAgent.Location = new Point(497, 376);
            btnEditAgent.Name = "btnEditAgent";
            btnEditAgent.Size = new Size(112, 34);
            btnEditAgent.TabIndex = 26;
            btnEditAgent.Text = "Edit";
            btnEditAgent.UseVisualStyleBackColor = true;
            btnEditAgent.Click += this.btnEditAgent_Click;
            // 
            // frmEditAgent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditAgent);
            Controls.Add(lstAgency);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtPosition);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmEditAgent";
            Text = "Form1";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAgency;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtPosition;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEditAgent;
    }
}
