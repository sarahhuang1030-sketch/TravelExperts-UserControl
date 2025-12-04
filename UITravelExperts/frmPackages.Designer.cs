namespace UITravelExperts
{
    partial class frmPackages
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            lblCurrentUser = new Label();
            lblAdminBadge = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlSidebar = new Panel();
            btnNavSettings = new Button();
            btnNavLogout = new Button();
            panel5 = new Panel();
            pnlSeparator = new Panel();
            panel6 = new Panel();
            btnNavSuppliers = new Button();
            btnNavProducts = new Button();
            btnNavAgencies = new Button();
            btnNavAgents = new Button();
            btnNavPackages = new Button();
            pnlConent = new Panel();
            pnlStatsContainer = new Panel();
            panel3 = new Panel();
            lblStatAgenciesLabel = new Label();
            lblStatAgenciesValue = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            lblStatAgentsLabel = new Label();
            lblStatAgentsValue = new Label();
            panel2 = new Panel();
            pnlStatPackages = new Panel();
            lblStatPackagesLabel = new Label();
            lblStatPackagesValue = new Label();
            pnlStatPackagesBorder = new Panel();
            mainPanel = new Panel();
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
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            btnReset = new Button();
            btnSearch = new Button();
            pnlContentHeader = new Panel();
            btnAddPackage = new Button();
            lblPageTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlSeparator.SuspendLayout();
            pnlConent.SuspendLayout();
            pnlStatsContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            pnlStatPackages.SuspendLayout();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPackages).BeginInit();
            pnlSearch.SuspendLayout();
            pnlContentHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Navy;
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(lblAdminBadge);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1258, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(1130, 20);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(114, 28);
            lblCurrentUser.TabIndex = 4;
            lblCurrentUser.Text = "Admin User";
            // 
            // lblAdminBadge
            // 
            lblAdminBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminBadge.BackColor = Color.Red;
            lblAdminBadge.ForeColor = Color.White;
            lblAdminBadge.Location = new Point(1022, 23);
            lblAdminBadge.Name = "lblAdminBadge";
            lblAdminBadge.Size = new Size(95, 25);
            lblAdminBadge.TabIndex = 3;
            lblAdminBadge.Text = "Admin 👤";
            lblAdminBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Gainsboro;
            lblSubtitle.Location = new Point(65, 40);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(175, 25);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Admin Control Panel";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(62, 5);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 38);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Travel Experts";
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 28, 46);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(btnNavLogout);
            pnlSidebar.Controls.Add(panel5);
            pnlSidebar.Controls.Add(pnlSeparator);
            pnlSidebar.Controls.Add(btnNavSuppliers);
            pnlSidebar.Controls.Add(btnNavProducts);
            pnlSidebar.Controls.Add(btnNavAgencies);
            pnlSidebar.Controls.Add(btnNavAgents);
            pnlSidebar.Controls.Add(btnNavPackages);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 70);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 714);
            pnlSidebar.TabIndex = 1;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.FromArgb(46, 74, 123);
            btnNavSettings.Cursor = Cursors.Hand;
            btnNavSettings.FlatAppearance.BorderSize = 0;
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavSettings.ForeColor = Color.White;
            btnNavSettings.Location = new Point(-1, 584);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Padding = new Padding(25, 0, 0, 0);
            btnNavSettings.Size = new Size(220, 45);
            btnNavSettings.TabIndex = 7;
            btnNavSettings.Text = "⚙️Settings";
            btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSettings.UseVisualStyleBackColor = false;
            // 
            // btnNavLogout
            // 
            btnNavLogout.BackColor = Color.FromArgb(46, 74, 123);
            btnNavLogout.Cursor = Cursors.Hand;
            btnNavLogout.FlatAppearance.BorderSize = 0;
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavLogout.ForeColor = Color.White;
            btnNavLogout.Location = new Point(0, 629);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Padding = new Padding(25, 0, 0, 0);
            btnNavLogout.Size = new Size(220, 45);
            btnNavLogout.TabIndex = 6;
            btnNavLogout.Text = "🚪Logout";
            btnNavLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.UseVisualStyleBackColor = false;
            btnNavLogout.Click += btnNavLogout_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.Location = new Point(0, 470);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 1);
            panel5.TabIndex = 5;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(50, 50, 50);
            pnlSeparator.Controls.Add(panel6);
            pnlSeparator.Location = new Point(0, 470);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(220, 1);
            pnlSeparator.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(50, 50, 50);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(220, 1);
            panel6.TabIndex = 5;
            // 
            // btnNavSuppliers
            // 
            btnNavSuppliers.BackColor = Color.FromArgb(46, 74, 123);
            btnNavSuppliers.Cursor = Cursors.Hand;
            btnNavSuppliers.FlatAppearance.BorderSize = 0;
            btnNavSuppliers.FlatStyle = FlatStyle.Flat;
            btnNavSuppliers.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavSuppliers.ForeColor = Color.White;
            btnNavSuppliers.Location = new Point(0, 91);
            btnNavSuppliers.Name = "btnNavSuppliers";
            btnNavSuppliers.Padding = new Padding(25, 0, 0, 0);
            btnNavSuppliers.Size = new Size(220, 45);
            btnNavSuppliers.TabIndex = 4;
            btnNavSuppliers.Text = "🏭 Suppliers";
            btnNavSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSuppliers.UseVisualStyleBackColor = false;
            btnNavSuppliers.Click += btnNavSuppliers_Click;
            // 
            // btnNavProducts
            // 
            btnNavProducts.BackColor = Color.FromArgb(46, 74, 123);
            btnNavProducts.Cursor = Cursors.Hand;
            btnNavProducts.FlatAppearance.BorderSize = 0;
            btnNavProducts.FlatStyle = FlatStyle.Flat;
            btnNavProducts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavProducts.ForeColor = Color.White;
            btnNavProducts.Location = new Point(0, 46);
            btnNavProducts.Name = "btnNavProducts";
            btnNavProducts.Padding = new Padding(25, 0, 0, 0);
            btnNavProducts.Size = new Size(220, 45);
            btnNavProducts.TabIndex = 3;
            btnNavProducts.Text = "📦 Products";
            btnNavProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnNavProducts.UseVisualStyleBackColor = false;
            btnNavProducts.Click += btnNavProducts_Click;
            // 
            // btnNavAgencies
            // 
            btnNavAgencies.BackColor = Color.FromArgb(46, 74, 123);
            btnNavAgencies.Cursor = Cursors.Hand;
            btnNavAgencies.FlatAppearance.BorderSize = 0;
            btnNavAgencies.FlatStyle = FlatStyle.Flat;
            btnNavAgencies.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAgencies.ForeColor = Color.White;
            btnNavAgencies.Location = new Point(0, 181);
            btnNavAgencies.Name = "btnNavAgencies";
            btnNavAgencies.Padding = new Padding(25, 0, 0, 0);
            btnNavAgencies.Size = new Size(220, 45);
            btnNavAgencies.TabIndex = 2;
            btnNavAgencies.Text = "🏢 Agencies";
            btnNavAgencies.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAgencies.UseVisualStyleBackColor = false;
            btnNavAgencies.Click += btnNavAgencies_Click;
            // 
            // btnNavAgents
            // 
            btnNavAgents.BackColor = Color.FromArgb(46, 74, 123);
            btnNavAgents.Cursor = Cursors.Hand;
            btnNavAgents.FlatAppearance.BorderSize = 0;
            btnNavAgents.FlatStyle = FlatStyle.Flat;
            btnNavAgents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAgents.ForeColor = Color.White;
            btnNavAgents.Location = new Point(0, 136);
            btnNavAgents.Name = "btnNavAgents";
            btnNavAgents.Padding = new Padding(25, 0, 0, 0);
            btnNavAgents.Size = new Size(220, 45);
            btnNavAgents.TabIndex = 1;
            btnNavAgents.Text = "👥 Agents";
            btnNavAgents.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAgents.UseVisualStyleBackColor = false;
            btnNavAgents.Click += btnNavAgents_Click;
            // 
            // btnNavPackages
            // 
            btnNavPackages.BackColor = Color.FromArgb(46, 74, 123);
            btnNavPackages.Cursor = Cursors.Hand;
            btnNavPackages.FlatAppearance.BorderSize = 0;
            btnNavPackages.FlatStyle = FlatStyle.Flat;
            btnNavPackages.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavPackages.ForeColor = Color.White;
            btnNavPackages.Location = new Point(0, 1);
            btnNavPackages.Name = "btnNavPackages";
            btnNavPackages.Padding = new Padding(25, 0, 0, 0);
            btnNavPackages.Size = new Size(220, 45);
            btnNavPackages.TabIndex = 0;
            btnNavPackages.Text = "📦 Packages";
            btnNavPackages.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPackages.UseVisualStyleBackColor = false;
            btnNavPackages.Click += btnNavPackages_Click;
            // 
            // pnlConent
            // 
            pnlConent.AutoScroll = true;
            pnlConent.BackColor = Color.FromArgb(244, 246, 248);
            pnlConent.Controls.Add(pnlStatsContainer);
            pnlConent.Controls.Add(mainPanel);
            pnlConent.Dock = DockStyle.Fill;
            pnlConent.Location = new Point(220, 70);
            pnlConent.Name = "pnlConent";
            pnlConent.Padding = new Padding(25);
            pnlConent.Size = new Size(1038, 714);
            pnlConent.TabIndex = 2;
            // 
            // pnlStatsContainer
            // 
            pnlStatsContainer.BackColor = Color.Transparent;
            pnlStatsContainer.Controls.Add(panel3);
            pnlStatsContainer.Controls.Add(panel1);
            pnlStatsContainer.Controls.Add(pnlStatPackages);
            pnlStatsContainer.Location = new Point(0, 0);
            pnlStatsContainer.Name = "pnlStatsContainer";
            pnlStatsContainer.Size = new Size(900, 130);
            pnlStatsContainer.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblStatAgenciesLabel);
            panel3.Controls.Add(lblStatAgenciesValue);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(600, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(248, 90);
            panel3.TabIndex = 4;
            // 
            // lblStatAgenciesLabel
            // 
            lblStatAgenciesLabel.AutoSize = true;
            lblStatAgenciesLabel.BackColor = Color.Transparent;
            lblStatAgenciesLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblStatAgenciesLabel.Location = new Point(18, 55);
            lblStatAgenciesLabel.Name = "lblStatAgenciesLabel";
            lblStatAgenciesLabel.Size = new Size(83, 25);
            lblStatAgenciesLabel.TabIndex = 2;
            lblStatAgenciesLabel.Text = "Agencies";
            // 
            // lblStatAgenciesValue
            // 
            lblStatAgenciesValue.AutoSize = true;
            lblStatAgenciesValue.BackColor = Color.Transparent;
            lblStatAgenciesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatAgenciesValue.ForeColor = Color.FromArgb(15, 28, 46);
            lblStatAgenciesValue.Location = new Point(11, 0);
            lblStatAgenciesValue.Name = "lblStatAgenciesValue";
            lblStatAgenciesValue.Size = new Size(56, 65);
            lblStatAgenciesValue.TabIndex = 1;
            lblStatAgenciesValue.Text = "5";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(74, 123, 167);
            panel4.Location = new Point(1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 90);
            panel4.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblStatAgentsLabel);
            panel1.Controls.Add(lblStatAgentsValue);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(302, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 90);
            panel1.TabIndex = 3;
            // 
            // lblStatAgentsLabel
            // 
            lblStatAgentsLabel.AutoSize = true;
            lblStatAgentsLabel.BackColor = Color.Transparent;
            lblStatAgentsLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblStatAgentsLabel.Location = new Point(18, 55);
            lblStatAgentsLabel.Name = "lblStatAgentsLabel";
            lblStatAgentsLabel.Size = new Size(110, 25);
            lblStatAgentsLabel.TabIndex = 2;
            lblStatAgentsLabel.Text = "Total Agents";
            // 
            // lblStatAgentsValue
            // 
            lblStatAgentsValue.AutoSize = true;
            lblStatAgentsValue.BackColor = Color.Transparent;
            lblStatAgentsValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatAgentsValue.ForeColor = Color.FromArgb(15, 28, 46);
            lblStatAgentsValue.Location = new Point(11, 0);
            lblStatAgentsValue.Name = "lblStatAgentsValue";
            lblStatAgentsValue.Size = new Size(84, 65);
            lblStatAgentsValue.TabIndex = 1;
            lblStatAgentsValue.Text = "15";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 126, 34);
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 90);
            panel2.TabIndex = 0;
            // 
            // pnlStatPackages
            // 
            pnlStatPackages.BackColor = Color.White;
            pnlStatPackages.Controls.Add(lblStatPackagesLabel);
            pnlStatPackages.Controls.Add(lblStatPackagesValue);
            pnlStatPackages.Controls.Add(pnlStatPackagesBorder);
            pnlStatPackages.Location = new Point(28, 17);
            pnlStatPackages.Name = "pnlStatPackages";
            pnlStatPackages.Size = new Size(248, 90);
            pnlStatPackages.TabIndex = 0;
            // 
            // lblStatPackagesLabel
            // 
            lblStatPackagesLabel.AutoSize = true;
            lblStatPackagesLabel.BackColor = Color.Transparent;
            lblStatPackagesLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblStatPackagesLabel.Location = new Point(18, 55);
            lblStatPackagesLabel.Name = "lblStatPackagesLabel";
            lblStatPackagesLabel.Size = new Size(137, 25);
            lblStatPackagesLabel.TabIndex = 2;
            lblStatPackagesLabel.Text = "Active Packages";
            // 
            // lblStatPackagesValue
            // 
            lblStatPackagesValue.AutoSize = true;
            lblStatPackagesValue.BackColor = Color.Transparent;
            lblStatPackagesValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatPackagesValue.ForeColor = Color.FromArgb(15, 28, 46);
            lblStatPackagesValue.Location = new Point(11, 0);
            lblStatPackagesValue.Name = "lblStatPackagesValue";
            lblStatPackagesValue.Size = new Size(84, 65);
            lblStatPackagesValue.TabIndex = 1;
            lblStatPackagesValue.Text = "24";
            // 
            // pnlStatPackagesBorder
            // 
            pnlStatPackagesBorder.BackColor = Color.FromArgb(30, 58, 95);
            pnlStatPackagesBorder.Location = new Point(1, -1);
            pnlStatPackagesBorder.Name = "pnlStatPackagesBorder";
            pnlStatPackagesBorder.Size = new Size(4, 90);
            pnlStatPackagesBorder.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(dgvPackages);
            mainPanel.Controls.Add(pnlSearch);
            mainPanel.Controls.Add(pnlContentHeader);
            mainPanel.Location = new Point(0, 136);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1038, 578);
            mainPanel.TabIndex = 5;
            // 
            // dgvPackages
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 249, 250);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(74, 123, 167);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvPackages.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPackages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPackages.BackgroundColor = Color.White;
            dgvPackages.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(10);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(15, 28, 46);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPackages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPackages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPackages.Columns.AddRange(new DataGridViewColumn[] { colPackageId, colPkgNam, colPkgStartDate, colPkgEndDate, colPkgBasePrice, colView, colEdit, colDelete, colPkgAgentCommission, colPkgDescption });
            dgvPackages.EnableHeadersVisualStyles = false;
            dgvPackages.Location = new Point(34, 166);
            dgvPackages.MultiSelect = false;
            dgvPackages.Name = "dgvPackages";
            dgvPackages.RowHeadersWidth = 62;
            dgvPackages.RowTemplate.Height = 40;
            dgvPackages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPackages.Size = new Size(970, 400);
            dgvPackages.TabIndex = 4;
            dgvPackages.CellContentClick += dgvPackages_CellContentClick;
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
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            colPkgStartDate.DefaultCellStyle = dataGridViewCellStyle3;
            colPkgStartDate.HeaderText = "Start Date";
            colPkgStartDate.MinimumWidth = 8;
            colPkgStartDate.Name = "colPkgStartDate";
            // 
            // colPkgEndDate
            // 
            colPkgEndDate.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            colPkgEndDate.DefaultCellStyle = dataGridViewCellStyle4;
            colPkgEndDate.HeaderText = "End Date";
            colPkgEndDate.MinimumWidth = 8;
            colPkgEndDate.Name = "colPkgEndDate";
            // 
            // colPkgBasePrice
            // 
            colPkgBasePrice.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            colPkgBasePrice.DefaultCellStyle = dataGridViewCellStyle5;
            colPkgBasePrice.HeaderText = "Base Price";
            colPkgBasePrice.MinimumWidth = 8;
            colPkgBasePrice.Name = "colPkgBasePrice";
            // 
            // colView
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.Cyan;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            colEdit.DefaultCellStyle = dataGridViewCellStyle7;
            colEdit.FillWeight = 80F;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            colDelete.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            colPkgAgentCommission.DefaultCellStyle = dataGridViewCellStyle9;
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
            // pnlSearch
            // 
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnReset);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Location = new Point(24, 96);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(990, 44);
            pnlSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(680, 34);
            txtSearch.TabIndex = 2;
            txtSearch.Text = " Search packages by name, description, or destination...";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(74, 123, 167);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(852, 6);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(123, 34);
            btnReset.TabIndex = 3;
            btnReset.Text = "🔃 Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(74, 123, 167);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(710, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(123, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // pnlContentHeader
            // 
            pnlContentHeader.BackColor = Color.Transparent;
            pnlContentHeader.Controls.Add(btnAddPackage);
            pnlContentHeader.Controls.Add(lblPageTitle);
            pnlContentHeader.Location = new Point(24, 6);
            pnlContentHeader.Name = "pnlContentHeader";
            pnlContentHeader.Size = new Size(990, 73);
            pnlContentHeader.TabIndex = 2;
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
            btnAddPackage.Click += btnAddPackage_Click_1;
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
            // frmPackages
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1258, 784);
            Controls.Add(pnlConent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1200, 700);
            Name = "frmPackages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel Exerpts - Admin Control Panel";
            Load += frmPackages_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            pnlSeparator.ResumeLayout(false);
            pnlConent.ResumeLayout(false);
            pnlStatsContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlStatPackages.ResumeLayout(false);
            pnlStatPackages.PerformLayout();
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPackages).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlContentHeader.ResumeLayout(false);
            pnlContentHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblAdminBadge;
        private Label lblSubtitle;
        private Label lblCurrentUser;
        private Panel pnlSidebar;
        private Button btnNavPackages;
        private Button btnNavAgents;
        private Button btnNavSuppliers;
        private Button btnNavProducts;
        private Button btnNavAgencies;
        private Button btnNavSettings;
        private Button btnNavLogout;
        private Panel pnlSeparator;
        private Panel pnlConent;
        private Panel pnlStatsContainer;
        private Panel pnlStatPackages;
        private Label lblStatPackagesValue;
        private Panel pnlStatPackagesBorder;
        private Label lblStatPackagesLabel;
        private Panel panel1;
        private Label lblStatAgentsLabel;
        private Label lblStatAgentsValue;
        private Panel panel2;
        private Panel panel3;
        private Label lblStatAgenciesLabel;
        private Label lblStatAgenciesValue;
        private Panel panel4;
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
        private Panel panel5;
        private Panel panel6;
        private Panel mainPanel;
        private Panel pnlContentHeader;
        private Button btnAddPackage;
        private Label lblPageTitle;
        private Panel pnlSearch;
        private TextBox txtSearch;
        private Button btnReset;
        private Button btnSearch;
    }
}
