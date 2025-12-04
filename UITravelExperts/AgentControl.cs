using AddAgents;
using EditAgent;
using AgentView;
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
    public partial class AgentControl : UserControl
    {
        public event EventHandler AgentAdded;
        public event EventHandler AgentDeleted;

        public AgentControl()
        {
            InitializeComponent();
        }

        public void InitializeAgentView()
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

        private void LoadAgent(TravelexpertsContext db)
        {
            //load products
            var agents = db.Agents.Select(a => new
            {
                a.AgentId,
                a.AgtFirstName,
                a.AgtLastName,
                a.AgtBusPhone,

            }).ToList();
            dgvAgent.DataSource = agents;
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
                LoadAgent(db);
            }
        }

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddAgent();
            var result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                AgentAdded?.Invoke(this, EventArgs.Empty); // 🔔 Notify parent

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
                var filteredAgents = db.Agents
                    .Where(p =>
                        (p.AgtFirstName != null && p.AgtFirstName.ToLower().Contains(keyword)) ||
                        (p.AgtLastName != null && p.AgtLastName.ToLower().Contains(keyword)))
                    .Select(p => new
                    {
                        p.AgentId,
                        p.AgtFirstName,
                        p.AgtLastName,
                        p.AgtBusPhone
                    })
                    .ToList();

                dgvAgent.DataSource = filteredAgents; // ✅ This line was missing
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = ""; // Clear the search box
            RefreshStatsAndPackages(); // Reload all packages and stats
        }

        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string columnName = dgvAgent.Columns[e.ColumnIndex].Name;
            var selectedRow = dgvAgent.Rows[e.RowIndex];
            dynamic agent = selectedRow.DataBoundItem;
            int agentId = agent.AgentId;

            if (columnName == "colView")
            {
                // MessageBox.Show($"Viewing Package ID: {packageId}");
                var detailsForm = new AgentDetailsForm(agent.AgentId);
                detailsForm.ShowDialog();


            }
            else if (columnName == "colEdit")
            {
                //  MessageBox.Show($"Editing Package ID: {packageId}");
                var editForm = new frmEditAgent(agent.AgentId);
                var result = editForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefreshStatsAndPackages(); // Refresh grid and stats after editing
                }

            }
            else if (columnName == "colDelete")
            {
                if (e.RowIndex < 0) return;

                dynamic agents = dgvAgent.Rows[e.RowIndex].DataBoundItem;
                int agentIds = agents.AgentId;

                var confirm = MessageBox.Show($"Delete Agent ID: {agentId}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TravelexpertsContext())
                    {
                        var agents1 = db.Agents.Find(agentIds);
                        if (agents1 != null)
                        {
                            db.Agents.Remove(agents1);
                            db.SaveChanges();
                            MessageBox.Show("Agent deleted.");
                            LoadAgent(db); // Refresh the grid
                            RefreshStatsAndPackages(); // ✅ Refresh grid
                            AgentDeleted?.Invoke(this, EventArgs.Empty); // 🔔 Notify main form

                        }
                        else
                        {
                            MessageBox.Show("Product not found.");
                        }
                    }
                }


            }
        }
    }
}
