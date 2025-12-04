namespace AddAgents
{
    partial class frmAddAgent
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPosition = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            btnAddAgent = new Button();
            lstAgency = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 126);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 191);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 250);
            label4.Name = "label4";
            label4.Size = new Size(71, 25);
            label4.TabIndex = 3;
            label4.Text = "Agency";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 313);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(78, 368);
            label6.Name = "label6";
            label6.Size = new Size(62, 25);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(205, 53);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(205, 120);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 7;
            // 
            // txtPosition
            // 
            txtPosition.Location = new Point(205, 191);
            txtPosition.Name = "txtPosition";
            txtPosition.Size = new Size(150, 31);
            txtPosition.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(205, 310);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(205, 368);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 31);
            txtPhone.TabIndex = 11;
            // 
            // btnAddAgent
            // 
            btnAddAgent.Location = new Point(529, 370);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(112, 34);
            btnAddAgent.TabIndex = 12;
            btnAddAgent.Text = "Add";
            btnAddAgent.UseVisualStyleBackColor = true;
            btnAddAgent.Click += btnAddAgent_Click;
            // 
            // lstAgency
            // 
            lstAgency.FormattingEnabled = true;
            lstAgency.Items.AddRange(new object[] { "Calgary", "Okotoks" });
            lstAgency.Location = new Point(204, 241);
            lstAgency.Name = "lstAgency";
            lstAgency.Size = new Size(180, 54);
            lstAgency.TabIndex = 13;
            // 
            // frmAddAgent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstAgency);
            Controls.Add(btnAddAgent);
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
            Name = "frmAddAgent";
            Text = "Form1";
            Load += frmAddAgent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPosition;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button btnAddAgent;
        private ListBox lstAgency;
    }
}
