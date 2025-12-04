namespace PackageDetailsForm
{
    partial class PackageDetailsForm
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
            lblPackageID = new Label();
            lblName = new Label();
            label3 = new Label();
            lblStartDate = new Label();
            label4 = new Label();
            lblEndDate = new Label();
            label5 = new Label();
            lblDescription = new Label();
            label6 = new Label();
            lblPrice = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 58);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "PackageID";
            // 
            // lblPackageID
            // 
            lblPackageID.BorderStyle = BorderStyle.Fixed3D;
            lblPackageID.Location = new Point(253, 45);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(144, 38);
            lblPackageID.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.Fixed3D;
            lblName.Location = new Point(253, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(331, 38);
            lblName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 114);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // lblStartDate
            // 
            lblStartDate.BorderStyle = BorderStyle.Fixed3D;
            lblStartDate.Location = new Point(253, 162);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(331, 38);
            lblStartDate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 175);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 4;
            label4.Text = "Start Date";
            // 
            // lblEndDate
            // 
            lblEndDate.BorderStyle = BorderStyle.Fixed3D;
            lblEndDate.Location = new Point(253, 220);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(331, 38);
            lblEndDate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(126, 233);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 6;
            label5.Text = "End Date";
            // 
            // lblDescription
            // 
            lblDescription.BorderStyle = BorderStyle.Fixed3D;
            lblDescription.Location = new Point(253, 285);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(331, 102);
            lblDescription.TabIndex = 9;
        
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(126, 298);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 8;
            label6.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.BorderStyle = BorderStyle.Fixed3D;
            lblPrice.Location = new Point(482, 45);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(144, 38);
            lblPrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(427, 46);
            label7.Name = "label7";
            label7.Size = new Size(49, 25);
            label7.TabIndex = 10;
            label7.Text = "Price";
            // 
            // PackageDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice);
            Controls.Add(label7);
            Controls.Add(lblDescription);
            Controls.Add(label6);
            Controls.Add(lblEndDate);
            Controls.Add(label5);
            Controls.Add(lblStartDate);
            Controls.Add(label4);
            Controls.Add(lblName);
            Controls.Add(label3);
            Controls.Add(lblPackageID);
            Controls.Add(label1);
            Name = "PackageDetailsForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblPackageID;
        private Label lblName;
        private Label label3;
        private Label lblStartDate;
        private Label label4;
        private Label lblEndDate;
        private Label label5;
        private Label lblDescription;
        private Label label6;
        private Label lblPrice;
        private Label label7;
    }
}
