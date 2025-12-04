using AddAgency;
using AgencyView;
using EditAgency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelData.Models;

namespace UITravelExperts
{
    public partial class AgencyControl : UserControl
    {
        public event EventHandler AgencyAdded;
        public event EventHandler AgencyDeleted;
        public AgencyControl()
        {
            InitializeComponent();
        }

        public void InitializeAgencyView()
        {
            // Role-based visibility
            //if (btnNavAgents != null)
            //    btnNavAgents.Visible = CurrentUserC.Role == "Admin";

            //if (btnNavAgencies != null)
            //    btnNavAgencies.Visible = CurrentUserC.Role == "Admin";

            //// Show current user
            //if (lblCurrentUser != null)
            //    lblCurrentUser.Text = CurrentUserC.Username;

            // Load stats and product list
            RefreshStatsAndPackages();

        }

        private void LoadAgency(TravelexpertsContext db)
        {
            //load products
            var agency = db.Agencies.Select(a => new
            {
                a.AgencyId,
                a.AgncyAddress,
                a.AgncyCity,
                a.AgncyCountry,
                a.AgncyPhone

            }).ToList();
            dgvAgency.DataSource = agency;
        }

        private void RefreshStatsAndPackages()
        {
            using (var db = new TravelexpertsContext())
            {
                // Update stats
                //lblStatPackagesValue.Text = db.Packages.Count().ToString();
                // lblStatAgentsValue.Text = db.Agents.Count().ToString();
                // lblStatAgenciesValue.Text = db.Agencies.Count().ToString();

                // Refresh grid
                LoadAgency(db);
            }
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {

            var addForm = new frmAddAgency();
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                AgencyAdded?.Invoke(this, EventArgs.Empty);
                RefreshStatsAndPackages(); // Updates label and grid
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            using (var db = new TravelexpertsContext())
            {
                var filteredAgency = db.Agencies
                    .Where(p =>
                        (p.AgncyAddress != null && p.AgncyAddress.ToLower().Contains(keyword)) ||
                        (p.AgncyCity != null && p.AgncyCity.ToLower().Contains(keyword)) ||
                        (p.AgncyCountry != null && p.AgncyCountry.ToLower().Contains(keyword)) ||
                        (p.AgncyPhone != null && p.AgncyPhone.ToLower().Contains(keyword)))
                    .Select(p => new
                    {
                        p.AgencyId,
                        p.AgncyAddress,
                        p.AgncyCity,
                        p.AgncyCountry,
                        p.AgncyPhone
                    })
                    .ToList();
                dgvAgency.DataSource = filteredAgency;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search box
            RefreshStatsAndPackages(); // Reload all packages and stats
        }

        private void dgvAgency_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvAgency.Columns[e.ColumnIndex].Name;
            var selectedRow = dgvAgency.Rows[e.RowIndex];
            dynamic agency1 = selectedRow.DataBoundItem;
            int agencyId = agency1.AgencyId;

            if (columnName == "colView")
            {
                // MessageBox.Show($"Viewing Package ID: {packageId}");
              

                var detailsForm = new Form1(agencyId); // ✅ Pass AgencyId, not AgentId
                detailsForm.ShowDialog();



            }
            else if (columnName == "colEdit")
            {
                //  MessageBox.Show($"Editing Package ID: {packageId}");
                var editForm = new frmEditAgency(agency1.AgencyId);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshStatsAndPackages(); // Refresh grid and stats after editing
                }

            }
            else if (columnName == "colDelete")
            {
                if (e.RowIndex < 0) return;

                dynamic agency = dgvAgency.Rows[e.RowIndex].DataBoundItem;
          

                var confirm = MessageBox.Show($"Delete Agency ID: {agencyId}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TravelexpertsContext())
                    {
                        var agencies = db.Agencies.Find(agencyId);
                        if (agencies != null)
                        {
                            db.Agencies.Remove(agencies);
                            db.SaveChanges();
                            MessageBox.Show("Agency deleted.");
                            LoadAgency(db); // Refresh the grid
                            RefreshStatsAndPackages(); // ✅ Refresh grid
                            AgencyDeleted?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            MessageBox.Show("Agency not found.");
                        }
                    }
                }


            }
        }   
    }
}
