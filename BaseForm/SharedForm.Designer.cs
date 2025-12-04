namespace BaseForm
{
    partial class SharedForm
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
            panel5 = new Panel();
            colPkgDescption = new DataGridViewTextBoxColumn();
            colPkgAgentCommission = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colView = new DataGridViewButtonColumn();
            btnNavSettings = new Button();
            btnNavLogout = new Button();
            pnlSeparator = new Panel();
            panel6 = new Panel();
            btnNavSuppliers = new Button();
            btnNavProducts = new Button();
            btnNavAgencies = new Button();
            colPkgBasePrice = new DataGridViewTextBoxColumn();
            colPkgEndDate = new DataGridViewTextBoxColumn();
            colPkgStartDate = new DataGridViewTextBoxColumn();
            colPackageId = new DataGridViewTextBoxColumn();
            btnNavPackages = new Button();
            pnlSidebar = new Panel();
            btnNavAgents = new Button();
            lblAdminBadge = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            colPkgNam = new DataGridViewTextBoxColumn();
            pnlHeader = new Panel();
            lblCurrentUser = new Label();
            label1 = new Label();
            pnlStatsContainer = new Panel();
            pnlStatPackages = new Panel();
            pnlStatPackagesBorder = new Panel();
            lblStatPackagesValue = new Label();
            lblStatPackagesLabel = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lblStatAgentsValue = new Label();
            lblStatAgentsLabel = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            lblStatAgenciesValue = new Label();
            lblStatAgenciesLabel = new Label();
            pnlConent = new Panel();
            pnlSeparator.SuspendLayout();
            pnlSidebar.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlStatsContainer.SuspendLayout();
            pnlStatPackages.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            pnlConent.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(50, 50, 50);
            panel5.Location = new Point(0, 470);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 1);
            panel5.TabIndex = 5;
            // 
            // colPkgDescption
            // 
            colPkgDescption.DataPropertyName = "PkgDesc";
            colPkgDescption.HeaderText = "Description";
            colPkgDescption.MinimumWidth = 8;
            colPkgDescption.Name = "colPkgDescption";
            colPkgDescption.Visible = false;
            colPkgDescption.Width = 150;
            // 
            // colPkgAgentCommission
            // 
            colPkgAgentCommission.DataPropertyName = "PkgAgencyComission";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            colPkgAgentCommission.DefaultCellStyle = dataGridViewCellStyle1;
            colPkgAgentCommission.HeaderText = "Agent Comission";
            colPkgAgentCommission.MinimumWidth = 8;
            colPkgAgentCommission.Name = "colPkgAgentCommission";
            colPkgAgentCommission.Visible = false;
            colPkgAgentCommission.Width = 150;
            // 
            // colDelete
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            colDelete.FillWeight = 90F;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Text = "🗑️ Delete";
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Width = 150;
            // 
            // colEdit
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Cyan;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            colEdit.DefaultCellStyle = dataGridViewCellStyle3;
            colEdit.FillWeight = 80F;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Text = "✏️ Edit";
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Width = 150;
            // 
            // colView
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            colView.DefaultCellStyle = dataGridViewCellStyle4;
            colView.FillWeight = 80F;
            colView.HeaderText = "Actions";
            colView.MinimumWidth = 8;
            colView.Name = "colView";
            colView.Resizable = DataGridViewTriState.True;
            colView.SortMode = DataGridViewColumnSortMode.Automatic;
            colView.Text = "👁️ View";
            colView.UseColumnTextForButtonValue = true;
            colView.Width = 150;
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
            btnNavLogout.Click += btnNavLogout_Click_1;
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
            colPkgBasePrice.Width = 150;
            // 
            // colPkgEndDate
            // 
            colPkgEndDate.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            colPkgEndDate.DefaultCellStyle = dataGridViewCellStyle6;
            colPkgEndDate.HeaderText = "End Date";
            colPkgEndDate.MinimumWidth = 8;
            colPkgEndDate.Name = "colPkgEndDate";
            colPkgEndDate.Width = 150;
            // 
            // colPkgStartDate
            // 
            colPkgStartDate.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            colPkgStartDate.DefaultCellStyle = dataGridViewCellStyle7;
            colPkgStartDate.HeaderText = "Start Date";
            colPkgStartDate.MinimumWidth = 8;
            colPkgStartDate.Name = "colPkgStartDate";
            colPkgStartDate.Width = 150;
            // 
            // colPackageId
            // 
            colPackageId.DataPropertyName = "PackageId";
            colPackageId.HeaderText = "ID";
            colPackageId.MinimumWidth = 8;
            colPackageId.Name = "colPackageId";
            colPackageId.Width = 150;
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
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(15, 28, 46);
            pnlSidebar.Controls.Add(btnNavAgents);
            pnlSidebar.Controls.Add(btnNavSettings);
            pnlSidebar.Controls.Add(btnNavLogout);
            pnlSidebar.Controls.Add(panel5);
            pnlSidebar.Controls.Add(pnlSeparator);
            pnlSidebar.Controls.Add(btnNavSuppliers);
            pnlSidebar.Controls.Add(btnNavProducts);
            pnlSidebar.Controls.Add(btnNavAgencies);
            pnlSidebar.Controls.Add(btnNavPackages);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 70);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 674);
            pnlSidebar.TabIndex = 3;
            // 
            // btnNavAgents
            // 
            btnNavAgents.BackColor = Color.FromArgb(46, 74, 123);
            btnNavAgents.Cursor = Cursors.Hand;
            btnNavAgents.FlatAppearance.BorderSize = 0;
            btnNavAgents.FlatStyle = FlatStyle.Flat;
            btnNavAgents.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNavAgents.ForeColor = Color.White;
            btnNavAgents.Location = new Point(1, 136);
            btnNavAgents.Name = "btnNavAgents";
            btnNavAgents.Padding = new Padding(25, 0, 0, 0);
            btnNavAgents.Size = new Size(220, 45);
            btnNavAgents.TabIndex = 7;
            btnNavAgents.Text = "👥 Agents";
            btnNavAgents.TextAlign = ContentAlignment.MiddleLeft;
            btnNavAgents.UseVisualStyleBackColor = false;
            // 
            // lblAdminBadge
            // 
            lblAdminBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblAdminBadge.BackColor = Color.Red;
            lblAdminBadge.ForeColor = Color.White;
            lblAdminBadge.Location = new Point(2200, 23);
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
            // colPkgNam
            // 
            colPkgNam.DataPropertyName = "PkgName";
            colPkgNam.FillWeight = 150F;
            colPkgNam.HeaderText = "Package Name";
            colPkgNam.MinimumWidth = 8;
            colPkgNam.Name = "colPkgNam";
            colPkgNam.Width = 150;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.Navy;
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(lblAdminBadge);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1378, 70);
            pnlHeader.TabIndex = 2;
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.BackColor = Color.Transparent;
            lblCurrentUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentUser.ForeColor = Color.White;
            lblCurrentUser.Location = new Point(1247, 23);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(114, 28);
            lblCurrentUser.TabIndex = 6;
            lblCurrentUser.Text = "Admin User";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
            label1.Location = new Point(1140, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 5;
            label1.Text = "Admin 👤";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlStatsContainer
            // 
            pnlStatsContainer.BackColor = Color.Transparent;
            pnlStatsContainer.Controls.Add(panel3);
            pnlStatsContainer.Controls.Add(panel1);
            pnlStatsContainer.Controls.Add(pnlStatPackages);
            pnlStatsContainer.Location = new Point(116, 0);
            pnlStatsContainer.Name = "pnlStatsContainer";
            pnlStatsContainer.Size = new Size(900, 130);
            pnlStatsContainer.TabIndex = 0;
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
            // pnlStatPackagesBorder
            // 
            pnlStatPackagesBorder.BackColor = Color.FromArgb(30, 58, 95);
            pnlStatPackagesBorder.Location = new Point(1, -1);
            pnlStatPackagesBorder.Name = "pnlStatPackagesBorder";
            pnlStatPackagesBorder.Size = new Size(4, 90);
            pnlStatPackagesBorder.TabIndex = 0;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(230, 126, 34);
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 90);
            panel2.TabIndex = 0;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(74, 123, 167);
            panel4.Location = new Point(1, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(4, 90);
            panel4.TabIndex = 0;
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
            // pnlConent
            // 
            pnlConent.AutoScroll = true;
            pnlConent.BackColor = Color.FromArgb(244, 246, 248);
            pnlConent.Controls.Add(pnlStatsContainer);
            pnlConent.Dock = DockStyle.Fill;
            pnlConent.Location = new Point(220, 70);
            pnlConent.Name = "pnlConent";
            pnlConent.Padding = new Padding(25);
            pnlConent.Size = new Size(1158, 674);
            pnlConent.TabIndex = 4;
            // 
            // SharedForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 248);
            ClientSize = new Size(1378, 744);
            Controls.Add(pnlConent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1200, 700);
            Name = "SharedForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += BaseForm_Load;
            pnlSeparator.ResumeLayout(false);
            pnlSidebar.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlStatsContainer.ResumeLayout(false);
            pnlStatPackages.ResumeLayout(false);
            pnlStatPackages.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlConent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private DataGridViewTextBoxColumn colPkgDescption;
        private DataGridViewTextBoxColumn colPkgAgentCommission;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colView;
        private Button btnNavSettings;
        private Button btnNavLogout;
        private Panel pnlSeparator;
        private Panel panel6;
        private Button btnNavSuppliers;
        private Button btnNavProducts;
        private Button btnNavAgencies;
        private DataGridViewTextBoxColumn colPkgBasePrice;
        private DataGridViewTextBoxColumn colPkgEndDate;
        private DataGridViewTextBoxColumn colPkgStartDate;
     
        private DataGridViewTextBoxColumn colPackageId;
        private Button btnNavPackages;
        private Panel pnlSidebar;

        private Label lblAdminBadge;
        private Label lblSubtitle;
        private Label lblTitle;
        private DataGridViewTextBoxColumn colPkgNam;
        private Panel pnlHeader;
        private Label label1;
        private Label lblCurrentUser;
        private Button btnNavAgents;
        private Panel pnlStatsContainer;
        private Panel panel3;
        private Label lblStatAgenciesLabel;
        private Label lblStatAgenciesValue;
        private Panel panel4;
        private Panel panel1;
        private Label lblStatAgentsLabel;
        private Label lblStatAgentsValue;
        private Panel panel2;
        private Panel pnlStatPackages;
        private Label lblStatPackagesLabel;
        private Label lblStatPackagesValue;
        private Panel pnlStatPackagesBorder;
        private Panel pnlConent;
    }
}
