namespace EditSupply
{
    partial class frmEditSupply
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
            txtSupplyId = new TextBox();
            btnSave = new Button();
            txtSupName = new TextBox();
            SuspendLayout();
            // 
            // txtSupplyId
            // 
            txtSupplyId.Location = new Point(239, 63);
            txtSupplyId.Name = "txtSupplyId";
            txtSupplyId.Size = new Size(150, 31);
            txtSupplyId.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(469, 354);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(219, 137);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(150, 31);
            txtSupName.TabIndex = 3;
            // 
            // frmEditSupply
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSupplyId);
            Controls.Add(btnSave);
            Controls.Add(txtSupName);
            Name = "frmEditSupply";
            Text = "Form1";
            Load += frmEditSupply_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplyId;
        private Button btnSave;
        private TextBox txtSupName;
    }
}
