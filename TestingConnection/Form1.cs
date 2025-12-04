using Microsoft.Data.SqlClient;

namespace TestingConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string connString =
    "Server=tcp:travelexperts-sql.database.windows.net,1433;" +
    "Initial Catalog=TravelExperts;" +
    "Persist Security Info=False;" +
    "User ID=sqladmin;" +
    "Password=Sarah923;" +   
    "MultipleActiveResultSets=False;" +
    "Encrypt=True;" +
    "TrustServerCertificate=False;" +
    "Connection Timeout=30;";

            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    MessageBox.Show("✔ Connected to Azure SQL Database successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed:\n" + ex.Message);
            }
        }
    }
}
