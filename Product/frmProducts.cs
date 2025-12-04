using TravelData.Models;
using CurrentUser;
using AddProduct;

namespace Product
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();

        }
        public Panel ProductSummary => this.ProductSummaryPanel;

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

        public void frmProducts_Load(object sender, EventArgs e)
        {

            btnNavAgents.Visible = CurrentUserC.Role == "Admin";
            btnNavAgencies.Visible = CurrentUserC.Role == "Admin";
            lblCurrentUser.Text = CurrentUserC.Username;

            using (TravelexpertsContext db = new TravelexpertsContext())
            {

                RefreshStatsAndPackages();
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            using (var db = new TravelexpertsContext())
            {
                var filteredProducts = db.Products
                    .Where(p => p.ProdName.ToLower().Contains(keyword))
                    .Select(p => new
                    {
                        p.ProdName,

                    })
                    .ToList();

                dgvProducts.DataSource = filteredProducts;
            }
        }

        
    }

}

