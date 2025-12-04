using AddSupply;
using EditSupply;
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
    public partial class SupplyControl : UserControl
    {
        public SupplyControl()
        {
            InitializeComponent();
        }

        public void InitializeSupplyView()
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

        private void LoadSupply(TravelexpertsContext db)
        {
            //load products
            var supply = db.Suppliers.Select(s => new
            {
                s.SupplierId,
                s.SupName,

            }).ToList();
            dgvSupply.DataSource = supply;
        }

        private void RefreshStatsAndPackages()
        {
            using (var db = new TravelexpertsContext())
            {
                // Update stats
                //  lblStatPackagesValue.Text = db.Packages.Count().ToString();
                //   lblStatAgentsValue.Text = db.Agents.Count().ToString();
                //   lblStatAgenciesValue.Text = db.Agencies.Count().ToString();

                // Refresh grid
                LoadSupply(db);
            }
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddSupply();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                RefreshStatsAndPackages(); // Updates label and grid
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            txtSearch.Text = ""; // Clear the search box
            RefreshStatsAndPackages(); // Reload all packages and stats
        }

        private void dgvSupply_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            string columnName = dgvSupply.Columns[e.ColumnIndex].Name;
            var selectedRow = dgvSupply.Rows[e.RowIndex];
            dynamic sup = selectedRow.DataBoundItem;
            int supply = sup.SupplierId;

            if (columnName == "colView")
            {
                // MessageBox.Show($"Viewing Package ID: {packageId}");
                //var detailsForm = new PacakgeDetailsForm(package.PackageId);
                //detailsForm.ShowDialog();


            }
            else if (columnName == "colEdit")
            {
                //  MessageBox.Show($"Editing Package ID: {packageId}");
                var editForm = new frmEditSupply(sup.SupplierId);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshStatsAndPackages(); // Refresh grid and stats after editing
                }

            }
            else if (columnName == "colDelete")
            {
                if (e.RowIndex < 0) return;

                dynamic supplier = dgvSupply.Rows[e.RowIndex].DataBoundItem;
                int supplyId = supplier.SupplierId;

                var confirm = MessageBox.Show($"Delete Product ID: {supplyId}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TravelexpertsContext())
                    {
                        var supplier1 = db.Suppliers.Find(supplyId);
                        if (supplier1 != null)
                        {
                            db.Suppliers.Remove(supplier1);
                            db.SaveChanges();
                            MessageBox.Show("Product deleted.");
                            LoadSupply(db); // Refresh the grid
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
                    }
                }


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
                var filteredSupply = db.Suppliers
                    .Where(p => p.SupName != null && p.SupName.ToLower().Contains(keyword))
                    .Select(p => new { p.SupplierId, p.SupName })
                    .ToList();

                dgvSupply.DataSource = filteredSupply;
            }
        }
    }
}
