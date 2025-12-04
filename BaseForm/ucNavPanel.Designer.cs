namespace BaseForm
{
    partial class ucNavPanel
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            btnNavAgencies = new Button();
            btnNavAgents = new Button();
            lblPageTitle = new Label();
            pnlContentHeader = new Panel();
            btnAddPackage = new Button();
            dgvPackages = new DataGridView();
            colPackageId = new DataGridViewTextBoxColumn();
            colPkgNam = new DataGridViewTextBoxColumn();
            colPkgStartDate = new DataGridViewTextBoxColumn();
            colPkgEndDate = new DataGridViewTextBoxColumn();
            colPkgBasePrice = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            colPkgAgentCommission = new DataGridViewTextBoxColumn();
            colPkgDescption = new DataGridViewTextBoxColumn();
            btnReset = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblCurrentUser = new Label();
            pnlContentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            SuspendLayout();
            // 
            // btnNavAgencies
            // 
            btnNavAgencies.BackColor = Color.FromArgb(46, 74, 123);
            btnNavAgencies.Cursor = Cursors.Hand;
            btnNavAgencies.FlatAppearance.BorderSize = 0;
            btnNavAgencies.FlatStyle = FlatStyle.Flat;
            btnNavAgencies.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAgencies.ForeColor = Color.White;
            btnNavAgencies.Location = new Point(3, 315);
            btnNavAgencies.Name = "btnNavAgencies";
            btnNavAgencies.Padding = new Padding(25, 0, 0, 0);
            btnNavAgencies.Size = new Size(220, 45);
            btnNavAgencies.TabIndex = 7;
            btnNavAgencies.Text = "🏢 Agencies";
            btnNavAgencies.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAgencies.UseVisualStyleBackColor = false;
            // 
            // btnNavAgents
            // 
            btnNavAgents.BackColor = Color.FromArgb(46, 74, 123);
            btnNavAgents.Cursor = Cursors.Hand;
            btnNavAgents.FlatAppearance.BorderSize = 0;
            btnNavAgents.FlatStyle = FlatStyle.Flat;
            btnNavAgents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAgents.ForeColor = Color.White;
            btnNavAgents.Location = new Point(3, 270);
            btnNavAgents.Name = "btnNavAgents";
            btnNavAgents.Padding = new Padding(25, 0, 0, 0);
            btnNavAgents.Size = new Size(220, 45);
            btnNavAgents.TabIndex = 5;
            btnNavAgents.Text = "👥 Agents";
            btnNavAgents.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAgents.UseVisualStyleBackColor = false;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(12, 28, 46);
            lblPageTitle.Location = new Point(0, 10);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(390, 48);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Package Management";
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = Color.Transparent;
            pnlContentHeader.Controls.Add(btnAddPackage);
            pnlContentHeader.Controls.Add(lblPageTitle);
            pnlContentHeader.Location = new Point(234, 14);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new Size(990, 73);
            pnlContentHeader.TabIndex = 6;
            // 
            // btnAddPackage
            // 
            btnAddPackage.BackColor = Color.FromArgb(30, 58, 95);
            btnAddPackage.Cursor = Cursors.Hand;
            btnAddPackage.FlatAppearance.BorderSize = 0;
            btnAddPackage.FlatStyle = FlatStyle.Flat;
            btnAddPackage.ForeColor = Color.White;
            btnAddPackage.Location = new Point(766, 20);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(166, 34);
            btnAddPackage.TabIndex = 1;
            btnAddPackage.Text = "➕ Add Package";
            btnAddPackage.UseVisualStyleBackColor = false;
            // 
            // dgvPackages
            // 
            dataGridViewCellStyle10.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(74, 123, 167);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dgvPackages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackages.BackgroundColor = Color.White;
            dgvPackages.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Padding = new Padding(10);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Columns.AddRange(new DataGridViewColumn[] { colPackageId, colPkgNam, colPkgStartDate, colPkgEndDate, colPkgBasePrice, colView, colEdit, colDelete, colPkgAgentCommission, colPkgDescption });
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.Location = new Point(254, 196);
            dgvPackages.MultiSelect = false;
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.RowTemplate.Height = 40;
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.Size = new Size(970, 400);
            dgvPackages.TabIndex = 11;
            // 
            // colPackageId
            // 
            colPackageId.DataPropertyName = "PackageId";
            colPackageId.HeaderText = "ID";
            colPackageId.MinimumWidth = 8;
            colPackageId.Name = "colPackageId";
            // 
            // colPkgNam
            // 
            colPkgNam.DataPropertyName = "PkgName";
            colPkgNam.FillWeight = 150F;
            colPkgNam.HeaderText = "Package Name";
            colPkgNam.MinimumWidth = 8;
            colPkgNam.Name = "colPkgNam";
            // 
            // colPkgStartDate
            // 
            colPkgStartDate.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            colPkgStartDate.DefaultCellStyle = dataGridViewCellStyle12;
            colPkgStartDate.HeaderText = "Start Date";
            colPkgStartDate.MinimumWidth = 8;
            colPkgStartDate.Name = "colPkgStartDate";
            // 
            // colPkgEndDate
            // 
            colPkgEndDate.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            colPkgEndDate.DefaultCellStyle = dataGridViewCellStyle13;
            colPkgEndDate.HeaderText = "End Date";
            colPkgEndDate.MinimumWidth = 8;
            colPkgEndDate.Name = "colPkgEndDate";
            // 
            // colPkgBasePrice
            // 
            colPkgBasePrice.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            colPkgBasePrice.DefaultCellStyle = dataGridViewCellStyle14;
            colPkgBasePrice.HeaderText = "Base Price";
            colPkgBasePrice.MinimumWidth = 8;
            colPkgBasePrice.Name = "colPkgBasePrice";
            // 
            // colView
            // 
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle15.ForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle15;
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
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = Color.Cyan;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle16.ForeColor = Color.White;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            colEdit.DefaultCellStyle = dataGridViewCellStyle16;
            colEdit.FillWeight = 80F;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle17.ForeColor = Color.White;
            colDelete.DefaultCellStyle = dataGridViewCellStyle17;
            colDelete.FillWeight = 90F;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑️ Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // colPkgAgentCommission
            // 
            colPkgAgentCommission.DataPropertyName = "PkgAgencyComission";
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            colPkgAgentCommission.DefaultCellStyle = dataGridViewCellStyle18;
            colPkgAgentCommission.HeaderText = "Agent Comission";
            colPkgAgentCommission.MinimumWidth = 8;
            colPkgAgentCommission.Name = "colPkgAgentCommission";
            colPkgAgentCommission.Visible = false;
            // 
            // colPkgDescption
            // 
            colPkgDescption.DataPropertyName = "PkgDesc";
            colPkgDescption.HeaderText = "Description";
            colPkgDescption.MinimumWidth = 8;
            colPkgDescption.Name = "colPkgDescption";
            colPkgDescption.Visible = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(74, 123, 167);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(1101, 119);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 34);
            btnReset.TabIndex = 10;
            btnReset.Text = "🔃 Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(74, 123, 167);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(959, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 34);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(255, 120);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(680, 34);
            txtSearch.TabIndex = 9;
            txtSearch.Text = " Search packages by name, description, or destination...";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(1456, -89);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(114, 28);
            lblCurrentUser.TabIndex = 12;
            lblCurrentUser.Text = "Admin User";
            // 
            // ucNavPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnNavAgencies);
            Controls.Add(btnNavAgents);
            Controls.Add(pnlContentHeader);
            Controls.Add(dgvPackages);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblCurrentUser);
            Name = "ucNavPanel";
            Size = new Size(1341, 677);
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNavAgencies;
        private Button btnNavAgents;
        private Label lblPageTitle;
        private Panel pnlContentHeader;
        private Button btnAddPackage;
        private DataGridView dgvPackages;
        private DataGridViewTextBoxColumn colPackageId;
        private DataGridViewTextBoxColumn colPkgNam;
        private DataGridViewTextBoxColumn colPkgStartDate;
        private DataGridViewTextBoxColumn colPkgEndDate;
        private DataGridViewTextBoxColumn colPkgBasePrice;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewTextBoxColumn colPkgAgentCommission;
        private DataGridViewTextBoxColumn colPkgDescption;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblCurrentUser;
    }
}
