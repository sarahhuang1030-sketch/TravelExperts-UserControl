namespace EditPackage
{
    partial class EditPackageForm
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
            txtPacakge = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrice = new TextBox();
            label5 = new Label();
            txtAgentComission = new TextBox();
            label6 = new Label();
            btnEdit = new Button();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 43);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
            label1.TabIndex = 0;
            label1.Text = "Package Name";
            // 
            // txtPacakge
            // 
            txtPacakge.Location = new Point(228, 40);
            txtPacakge.Name = "txtPacakge";
            txtPacakge.Size = new Size(150, 31);
            txtPacakge.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(228, 233);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(275, 31);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 236);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 2;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 104);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 167);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 6;
            label4.Text = "End Date";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(228, 280);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 31);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 283);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // txtAgentComission
            // 
            txtAgentComission.Location = new Point(253, 334);
            txtAgentComission.Name = "txtAgentComission";
            txtAgentComission.Size = new Size(125, 31);
            txtAgentComission.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 337);
            label6.Name = "label6";
            label6.Size = new Size(148, 25);
            label6.TabIndex = 10;
            label6.Text = "Agent Comission";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(563, 334);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(236, 103);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 13;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(236, 169);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 14;
            // 
            // EditPackageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnEdit);
            Controls.Add(txtAgentComission);
            Controls.Add(label6);
            Controls.Add(txtPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtPacakge);
            Controls.Add(label1);
            Name = "EditPackageForm";
            Text = "Form1";
            Load += EditPackageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPacakge;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrice;
        private Label label5;
        private TextBox txtAgentComission;
        private Label label6;
        private Button btnEdit;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
    }
}
