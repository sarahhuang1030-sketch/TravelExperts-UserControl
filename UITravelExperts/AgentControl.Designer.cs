namespace UITravelExperts
{
    partial class AgentControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            panel8 = new Panel();
            btnReset = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            pnlContentHeader = new Panel();
            lblPageTitle = new Label();
            btnAddAgent = new Button();
            dgvAgent = new DataGridView();
            colAgentId = new DataGridViewTextBoxColumn();
            colFirstNam = new DataGridViewTextBoxColumn();
            colLastNam = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            panel8.SuspendLayout();
            pnlContentHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgent).BeginInit();
            SuspendLayout();
            // 
            // panel8
            // 
            panel8.Controls.Add(btnReset);
            panel8.Controls.Add(btnSearch);
            panel8.Controls.Add(txtSearch);
            panel8.Location = new Point(22, 115);
            panel8.Name = "panel8";
            panel8.Size = new Size(980, 50);
            panel8.TabIndex = 12;
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
            txtSearch.ForeColor = SystemColors.WindowText;
            txtSearch.Location = new Point(1, 8);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(680, 34);
            txtSearch.TabIndex = 2;
            txtSearch.Text = " Search agent by first name or last name...";
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = Color.Transparent;
            pnlContentHeader.Controls.Add(lblPageTitle);
            pnlContentHeader.Controls.Add(btnAddAgent);
            pnlContentHeader.Location = new Point(17, 18);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new Size(990, 73);
            pnlContentHeader.TabIndex = 10;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(12, 28, 46);
            lblPageTitle.Location = new Point(0, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(355, 48);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Agent Management";
            // 
            // btnAddAgent
            // 
            btnAddAgent.BackColor = Color.FromArgb(30, 58, 95);
            btnAddAgent.Cursor = Cursors.Hand;
            btnAddAgent.FlatAppearance.BorderSize = 0;
            btnAddAgent.FlatStyle = FlatStyle.Flat;
            btnAddAgent.ForeColor = Color.White;
            btnAddAgent.Location = new Point(766, 24);
            btnAddAgent.Name = "btnAddAgent";
            btnAddAgent.Size = new Size(166, 34);
            btnAddAgent.TabIndex = 1;
            btnAddAgent.Text = "➕ Add Agent";
            btnAddAgent.UseVisualStyleBackColor = false;
            btnAddAgent.Click += btnAddAgent_Click;
            // 
            // dgvAgent
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 123, 167);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvAgent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAgent.BackgroundColor = Color.White;
            dgvAgent.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAgent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAgent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgent.Columns.AddRange(new DataGridViewColumn[] { colAgentId, colFirstNam, colLastNam, colPhone, colView, colEdit, colDelete });
            dgvAgent.EnableHeadersVisualStyles = false;
            dgvAgent.Location = new Point(27, 200);
            dgvAgent.MultiSelect = false;
            dgvAgent.Name = "dgvAgent";
            dgvAgent.RowHeadersWidth = 62;
            dgvAgent.RowTemplate.Height = 40;
            dgvAgent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAgent.Size = new Size(970, 400);
            dgvAgent.TabIndex = 11;
            dgvAgent.CellContentClick += dgvAgent_CellContentClick;
            // 
            // colAgentId
            // 
            colAgentId.DataPropertyName = "AgentId";
            colAgentId.HeaderText = "ID";
            colAgentId.MinimumWidth = 8;
            colAgentId.Name = "colAgentId";
            // 
            // colFirstNam
            // 
            colFirstNam.DataPropertyName = "AgtFirstName";
            colFirstNam.FillWeight = 150F;
            colFirstNam.HeaderText = "First Name";
            colFirstNam.MinimumWidth = 8;
            colFirstNam.Name = "colFirstNam";
            // 
            // colLastNam
            // 
            colLastNam.DataPropertyName = "AgtLastName";
            colLastNam.HeaderText = "Last Name";
            colLastNam.MinimumWidth = 8;
            colLastNam.Name = "colLastNam";
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "AgtBusPhone";
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 8;
            colPhone.Name = "colPhone";
            // 
            // colView
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Cyan;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            colEdit.DefaultCellStyle = dataGridViewCellStyle4;
            colEdit.FillWeight = 80F;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            colDelete.DefaultCellStyle = dataGridViewCellStyle5;
            colDelete.FillWeight = 90F;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑️ Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // AgentControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel8);
            Controls.Add(pnlContentHeader);
            Controls.Add(dgvAgent);
            Name = "AgentControl";
            Size = new Size(1030, 667);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAgent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel8;
        private Button btnReset;
        private Button btnSearch;
        private TextBox txtSearch;
        private Panel pnlContentHeader;
        private Label lblPageTitle;
        private Button btnAddAgent;
        private DataGridView dgvAgent;
        private DataGridViewTextBoxColumn colAgentId;
        private DataGridViewTextBoxColumn colFirstNam;
        private DataGridViewTextBoxColumn colLastNam;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}
