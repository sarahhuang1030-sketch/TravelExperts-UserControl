using AddProduct;
using CurrentUser;
using EditPackage;
using PackageView;
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
using EditProducts;

namespace UITravelExperts
{
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }

        public void InitializeProductView()
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

        private void LoadProducts(TravelexpertsContext db)
        {
            //load products
            var products = db.Products.Select(p => new
            {
                p.ProductId,
                p.ProdName,

            }).ToList();
            dgvProducts.DataSource = products;
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
                LoadProducts(db);
            }
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            var addForm = new frmAddProduct();
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

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            string columnName = dgvProducts.Columns[e.ColumnIndex].Name;
            var selectedRow = dgvProducts.Rows[e.RowIndex];
            dynamic prod = selectedRow.DataBoundItem;
            int productId = prod.ProductId;

            if (columnName == "colView")
            {
                // MessageBox.Show($"Viewing Package ID: {packageId}");
                //var detailsForm = new PacakgeDetailsForm(package.PackageId);
                //detailsForm.ShowDialog();


            }
            else if (columnName == "colEdit")
            {
                //  MessageBox.Show($"Editing Package ID: {packageId}");
                var editForm = new frmEditProducts(prod.ProductId);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshStatsAndPackages(); // Refresh grid and stats after editing
                }

            }
            else if (columnName == "colDelete")
            {
                if (e.RowIndex < 0) return;

                dynamic products = dgvProducts.Rows[e.RowIndex].DataBoundItem;
                int productIds = prod.ProductId;

                var confirm = MessageBox.Show($"Delete Product ID: {productId}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TravelexpertsContext())
                    {
                        var product = db.Products.Find(productIds);
                        if (product != null)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            MessageBox.Show("Product deleted.");
                            LoadProducts(db); // Refresh the grid
                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
                    }
                }


            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            using (var db = new TravelexpertsContext())
            {
                var filteredProducts = db.Products
                    .Where(p => p.ProdName != null && p.ProdName.ToLower().Contains(keyword))
                    .Select(p => new { p.ProductId, p.ProdName })
                    .ToList();

                dgvProducts.DataSource = filteredProducts;
            }
        }
    }
}
