namespace EditProducts
{
    partial class frmEditProducts
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
            txtProdName = new TextBox();
            btnSave = new Button();
            txtProductId = new TextBox();
            SuspendLayout();
            // 
            // txtProdName
            // 
            txtProdName.Location = new Point(206, 146);
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(150, 31);
            txtProdName.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(456, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(226, 72);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(150, 31);
            txtProductId.TabIndex = 2;
            // 
            // frmEditProducts
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtProductId);
            Controls.Add(btnSave);
            Controls.Add(txtProdName);
            Name = "frmEditProducts";
            Text = "Form1";
            Load += frmEditProducts_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProdName;
        private Button btnSave;
        private TextBox txtProductId;
    }
}
