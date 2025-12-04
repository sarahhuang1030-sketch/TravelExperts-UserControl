namespace AddSupply
{
    partial class frmAddSupply
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
            btnSave = new Button();
            txtSupName = new TextBox();
            label1 = new Label();
            txtSupId = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(574, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(163, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(233, 123);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(150, 31);
            txtSupName.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 123);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 14;
            label1.Text = "Supplier Name";
            // 
            // txtSupId
            // 
            txtSupId.Location = new Point(233, 70);
            txtSupId.Name = "txtSupId";
            txtSupId.Size = new Size(150, 31);
            txtSupId.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 70);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 17;
            label2.Text = "Supplier ID";
            // 
            // frmAddSupply
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSupId);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtSupName);
            Controls.Add(label1);
            Name = "frmAddSupply";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtSupName;
        private Label label1;
        private TextBox txtSupId;
        private Label label2;
    }
}
