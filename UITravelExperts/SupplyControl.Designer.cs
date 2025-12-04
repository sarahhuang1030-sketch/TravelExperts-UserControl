namespace UITravelExperts
{
    partial class SupplyControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            lblPageTitle = new Label();
            pnlsupply = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            s = new Panel();
            btnAddSupply = new Button();
            dgvSupply = new DataGridView();
            colSupplierId = new DataGridViewTextBoxColumn();
            colSupNam = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlsupply.SuspendLayout();
            s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(12, 28, 46);
            lblPageTitle.Location = new Point(0, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(392, 48);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Supplier Management";
            // 
            // pnlsupply
            // 
            pnlsupply.Controls.Add(btnReset);
            pnlsupply.Controls.Add(btnSearch);
            pnlsupply.Controls.Add(txtSearch);
            pnlsupply.Location = new Point(21, 114);
            pnlsupply.Name = "pnlsupply";
            pnlsupply.Size = new Size(980, 50);
            pnlsupply.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(74, 123, 167);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(847, 7);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "🔃 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(74, 123, 167);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(705, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(1, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(680, 34);
            txtSearch.TabIndex = 2;
            txtSearch.Text = " Search supplier by name...";
            // 
            // s
            // 
            s.BackColor = Color.Transparent;
            s.Controls.Add(lblPageTitle);
            s.Controls.Add(btnAddSupply);
            s.Location = new Point(16, 17);
            s.Name = "s";
            s.Size = new Size(990, 73);
            s.TabIndex = 10;
            // 
            // btnAddSupply
            // 
            btnAddSupply.BackColor = Color.FromArgb(30, 58, 95);
            btnAddSupply.Cursor = Cursors.Hand;
            btnAddSupply.FlatAppearance.BorderSize = 0;
            btnAddSupply.FlatStyle = FlatStyle.Flat;
            btnAddSupply.ForeColor = Color.White;
            btnAddSupply.Location = new Point(766, 24);
            btnAddSupply.Name = "btnAddSupply";
            btnAddSupply.Size = new Size(166, 34);
            btnAddSupply.TabIndex = 1;
            btnAddSupply.Text = "➕ Add Supplier";
            btnAddSupply.UseVisualStyleBackColor = false;
            btnAddSupply.Click += btnAddSupply_Click;
            // 
            // dgvSupply
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(74, 123, 167);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dgvSupply.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSupply.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupply.BackgroundColor = Color.White;
            dgvSupply.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.Padding = new Padding(10);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle7.SelectionForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSupply.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSupply.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupply.Columns.AddRange(new DataGridViewColumn[] { colSupplierId, colSupNam, colView, colEdit, colDelete });
            dgvSupply.EnableHeadersVisualStyles = false;
            dgvSupply.Location = new Point(26, 199);
            dgvSupply.MultiSelect = false;
            dgvSupply.Name = "dgvSupply";
            dgvSupply.RowHeadersWidth = 62;
            dgvSupply.RowTemplate.Height = 40;
            dgvSupply.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupply.Size = new Size(970, 400);
            dgvSupply.TabIndex = 11;
            dgvSupply.CellContentClick += dgvSupply_CellContentClick;
            // 
            // colSupplierId
            // 
            colSupplierId.DataPropertyName = "SupplierId";
            colSupplierId.HeaderText = "ID";
            colSupplierId.MinimumWidth = 8;
            colSupplierId.Name = "colSupplierId";
            // 
            // colSupNam
            // 
            colSupNam.DataPropertyName = "SupName";
            colSupNam.FillWeight = 150F;
            colSupNam.HeaderText = "Supplier Name";
            colSupNam.MinimumWidth = 8;
            colSupNam.Name = "colSupNam";
            // 
            // colView
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle8;
            colView.FillWeight = 80F;
            colView.HeaderText = "Actions";
            colView.MinimumWidth = 8;
            colView.Name = "colView";
            colView.Resizable = DataGridViewTriState.True;
            colView.SortMode = DataGridViewColumnSortMode.Automatic;
            colView.Text = "👁️ View";
            colView.UseColumnTextForButtonValue = true;
            // 
            // colEdit
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.Cyan;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            colEdit.DefaultCellStyle = dataGridViewCellStyle9;
            colEdit.FillWeight = 80F;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            colDelete.FillWeight = 90F;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑️ Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // SupplyControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlsupply);
            Controls.Add(s);
            Controls.Add(dgvSupply);
            Name = "SupplyControl";
            Size = new Size(1040, 580);
            pnlsupply.ResumeLayout(false);
            pnlsupply.PerformLayout();
            s.ResumeLayout(false);
            s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupply).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPageTitle;
        private Panel pnlsupply;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel s;
        private Button btnAddSupply;
        private DataGridView dgvSupply;
        private DataGridViewTextBoxColumn colSupplierId;
        private DataGridViewTextBoxColumn colSupNam;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
