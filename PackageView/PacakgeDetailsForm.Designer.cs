namespace PackageView
{
    partial class PacakgeDetailsForm
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
            lblPackageID = new Label();
            lblName = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            lblPrice = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblPackageID
            // 
            lblPackageID.AutoSize = true;
            lblPackageID.Location = new Point(146, 52);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(59, 25);
            lblPackageID.TabIndex = 0;
            lblPackageID.Text = "label1";
           
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(146, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(59, 25);
            lblName.TabIndex = 1;
            lblName.Text = "label1";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(161, 163);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(59, 25);
            lblStartDate.TabIndex = 2;
            lblStartDate.Text = "label1";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(161, 214);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(59, 25);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "label1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(146, 278);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 25);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(170, 345);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(59, 25);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "label1";
            // 
            // PacakgeDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblName);
            Controls.Add(lblPackageID);
            Name = "PacakgeDetailsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPackageID;
        private Label lblName;
        private Label lblStartDate;
        private Label lblEndDate;
        private Label lblPrice;
        private Label lblDescription;
    }
}
