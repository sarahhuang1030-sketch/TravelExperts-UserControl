using AddPackage;
using CurrentUser;
using EditPackage;
using Login;
using PackageView;
using TravelData.Models;


namespace UITravelExperts
{
    public partial class frmPackages : Form
    {
        public frmPackages()
        {
            InitializeComponent();
        }

        private void frmPackages_Load(object sender, EventArgs e)
        {

            btnNavAgents.Visible = CurrentUserC.Role == "Admin";
            btnNavAgencies.Visible = CurrentUserC.Role == "Admin";
            lblCurrentUser.Text = CurrentUserC.Username;

            using (TravelexpertsContext db = new TravelexpertsContext())
            {
                RefreshStatsAndPackages();
            }
        }

        private void LoadPackages(TravelexpertsContext db)
        {
            //load packages
            var packages = db.Packages
            .OrderBy(p => p.PackageId) // 👈 Explicit order
            .Select(p => new
        {

            p.PackageId,
                p.PkgName,
                p.PkgStartDate,
                p.PkgEndDate,
                p.PkgBasePrice
            }).ToList();
            dgvPackages.DataSource = packages;
        }

        private void RefreshStatsAndPackages()
        {
            using (var db = new TravelexpertsContext())
            {
                // Update stats
                lblStatPackagesValue.Text = db.Packages.Count().ToString();
                lblStatAgentsValue.Text = db.Agents.Count().ToString();
                lblStatAgenciesValue.Text = db.Agencies.Count().ToString();

                // Refresh grid
                LoadPackages(db);
            }
        }

        private void dgvPackages_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            string columnName = dgvPackages.Columns[e.ColumnIndex].Name;
            var selectedRow = dgvPackages.Rows[e.RowIndex];
            dynamic package = selectedRow.DataBoundItem;
            int packageId = package.PackageId;

            if (columnName == "colView")
            {
                // MessageBox.Show($"Viewing Package ID: {packageId}");
                var detailsForm = new PacakgeDetailsForm(package.PackageId);
                detailsForm.ShowDialog();


            }
            else if (columnName == "colEdit")
            {
                //  MessageBox.Show($"Editing Package ID: {packageId}");
                var editForm = new EditPackageForm(package.PackageId);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshStatsAndPackages(); // Refresh grid and stats after editing
                }

            }
            else if (columnName == "colDelete")
            {
                var confirm = MessageBox.Show($"Delete Package ID: {packageId}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TravelexpertsContext())
                    {
                        var pkg = db.Packages.Find(packageId);
                        if (pkg != null)
                        {
                            db.Packages.Remove(pkg);
                            db.SaveChanges();
                            MessageBox.Show("Package deleted.");
                            LoadPackages(db); // Refresh the grid
                        }
                    }
                }
            }
        }

        private void btnAddPackage_Click_1(object sender, EventArgs e)
        {
            var addForm = new frmAddPackage();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshStatsAndPackages(); // Updates label and grid

            }

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            using (var db = new TravelexpertsContext())
            {
                var filteredPackages = db.Packages
                    .Where(p => p.PkgName.ToLower().Contains(keyword))
                    .Select(p => new
                    {
                        p.PackageId,
                        p.PkgName,
                        p.PkgStartDate,
                        p.PkgEndDate,
                        p.PkgBasePrice,
                      
                    })
                    .ToList();

                dgvPackages.DataSource = filteredPackages;
            }

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search box
            RefreshStatsAndPackages(); // Reload all packages and stats

        }

        private void btnNavLogout_Click(object sender, EventArgs e)
        {
            // Optionally hide or close the current form
            this.Hide();
            //this.Close();

            // Show the login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();

        }

        private void btnNavProducts_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var productControl = new ProductControl();
            productControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(productControl);
            productControl.InitializeProductView();
        }

        private void btnNavPackages_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            // Re-add original controls manually
            mainPanel.Controls.Add(pnlContentHeader);
            mainPanel.Controls.Add(pnlSearch);
            mainPanel.Controls.Add(dgvPackages);
        }

        private void btnNavSuppliers_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var supplyControl = new SupplyControl();
            supplyControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(supplyControl);
            supplyControl.InitializeSupplyView();
        }

        private void btnNavAgents_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var agentControl = new AgentControl();
            agentControl.Dock = DockStyle.Fill;
            agentControl.AgentAdded += AgentControl_AgentAdded; // 👈 Subscribe
            agentControl.AgentDeleted += AgentControl_AgentChanged;// 👈 Subscribe

            mainPanel.Controls.Add(agentControl);
            agentControl.InitializeAgentView();
        }

        private void AgentControl_AgentAdded(object sender, EventArgs e)
        {
            RefreshStatsAndPackages(); // ✅ Updates lblStatAgentsValue
        }
        private void AgentControl_AgentChanged(object sender, EventArgs e)
        {
            RefreshStatsAndPackages(); // ✅ Updates lblStatAgentsValue
        }

        private void btnNavAgencies_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            var agencyControl = new AgencyControl();
            agencyControl.Dock = DockStyle.Fill;
            agencyControl.AgencyAdded += AgencyControl_AgencyAdded; // 👈 Subscribe
            agencyControl.AgencyDeleted += AgencyControl_AgencyChanged;// 👈 Subscribe

            mainPanel.Controls.Add(agencyControl);
            agencyControl.InitializeAgencyView();
        }

        private void AgencyControl_AgencyAdded(object sender, EventArgs e)
        {
            RefreshStatsAndPackages(); // ✅ Updates lblStatAgentsValue
        }
        private void AgencyControl_AgencyChanged(object sender, EventArgs e)
        {
            RefreshStatsAndPackages(); // ✅ Updates lblStatAgentsValue
        }
    }

}
