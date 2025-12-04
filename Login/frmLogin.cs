using CurrentUser;
using Microsoft.EntityFrameworkCore;
using TravelData.Models;

namespace Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            using (var db = new TravelexpertsContext())
            {
                var user = db.Users
                    .Include(u => u.Role) // Include Role if it's a navigation property
                    .FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

                if (user != null)
                {
                    CurrentUserC.Username = user.Username;
                    CurrentUserC.Role = user.Role?.RoleName ?? "Viewer"; // Fallback if Role is null

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

        }
    }
}
