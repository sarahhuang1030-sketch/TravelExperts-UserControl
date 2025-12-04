namespace AgentView
{
    partial class AgentDetailsForm
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
            lblEmail = new Label();
            lblPhone = new Label();
            lblMdInitial = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblAgentID = new Label();
            lblPosition = new Label();
            lblAgency = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(198, 322);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 25);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "label1";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(174, 255);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 25);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "label1";
            // 
            // lblMdInitial
            // 
            lblMdInitial.AutoSize = true;
            lblMdInitial.Location = new Point(174, 140);
            lblMdInitial.Name = "lblMdInitial";
            lblMdInitial.Size = new Size(59, 25);
            lblMdInitial.TabIndex = 9;
            lblMdInitial.Text = "label1";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(198, 187);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(59, 25);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "label1";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(174, 93);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(59, 25);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "label1";
            // 
            // lblAgentID
            // 
            lblAgentID.AutoSize = true;
            lblAgentID.Location = new Point(174, 29);
            lblAgentID.Name = "lblAgentID";
            lblAgentID.Size = new Size(59, 25);
            lblAgentID.TabIndex = 6;
            lblAgentID.Text = "label1";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(466, 64);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(59, 25);
            lblPosition.TabIndex = 12;
            lblPosition.Text = "label1";
            // 
            // lblAgency
            // 
            lblAgency.AutoSize = true;
            lblAgency.Location = new Point(466, 140);
            lblAgency.Name = "lblAgency";
            lblAgency.Size = new Size(59, 25);
            lblAgency.TabIndex = 13;
            lblAgency.Text = "label1";
           
            // 
            // AgentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAgency);
            Controls.Add(lblPosition);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblMdInitial);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblAgentID);
            Name = "AgentDetailsForm";
            Text = "Form1";
            Load += AgentDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPhone;
        private Label lblMdInitial;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblAgentID;
        private Label lblPosition;
        private Label lblAgency;
    }
}
