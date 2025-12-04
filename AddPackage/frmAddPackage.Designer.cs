namespace AddPackage
{
    partial class frmAddPackage
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
            txtPkgName = new TextBox();
            txtPkgDesc = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtPrice = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            txtAgentComission = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 35);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Pacakge Name";
            label1.Click += label1_Click;
            // 
            // txtPkgName
            // 
            txtPkgName.Location = new Point(226, 35);
            txtPkgName.Name = "txtPkgName";
            txtPkgName.Size = new Size(150, 31);
            txtPkgName.TabIndex = 1;
       //txtPkgName.TextChanged += this.txtPkgName_TextChanged;
            // 
            // txtPkgDesc
            // 
            txtPkgDesc.Location = new Point(250, 187);
            txtPkgDesc.Name = "txtPkgDesc";
            txtPkgDesc.Size = new Size(323, 31);
            txtPkgDesc.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 187);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 2;
            label2.Text = "Pacakge Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 85);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 136);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "End Date";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(221, 92);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(221, 136);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(250, 238);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(83, 238);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(570, 380);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtAgentComission
            // 
            txtAgentComission.Location = new Point(250, 290);
            txtAgentComission.Name = "txtAgentComission";
            txtAgentComission.Size = new Size(150, 31);
            txtAgentComission.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 290);
            label6.Name = "label6";
            label6.Size = new Size(159, 25);
            label6.TabIndex = 11;
            label6.Text = "Agency Comission";
            // 
            // frmAddPackage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAgentComission);
            Controls.Add(label6);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPkgDesc);
            Controls.Add(label2);
            Controls.Add(txtPkgName);
            Controls.Add(label1);
            Name = "frmAddPackage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPkgName;
        private TextBox txtPkgDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtPrice;
        private Label label5;
        private Button btnSave;
        private TextBox txtAgentComission;
        private Label label6;
    }
}
