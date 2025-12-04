using CurrentUser;
using Login;
using TravelData.Models;
namespace BaseForm
{
    public partial class SharedForm : Form
    {
        public SharedForm()
        {
            InitializeComponent();
          //  InitializeRoleButtons();
            this.Load += BaseForm_Load; // ✅ Designer-safe event hookup

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            btnNavAgents.Visible = false;
            btnNavAgencies.Visible = false;
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
                //  LoadPackages(db);
            }
        }

        private void btnNavLogout_Click_1(object sender, EventArgs e)
        {

            // Optionally hide or close the current form
            this.Hide();
            //this.Close();

            // Show the login form
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
