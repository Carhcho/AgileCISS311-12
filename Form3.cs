using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace dropbox13
{
    public partial class Form3 : Form
    {
        string connectionString;
        SqlConnection conn;
        int adviseeId;
        public Form3()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox13.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT adviseeId, " + "adviseeName, advisor.advisorName FROM advisee JOIN advisor ON " + "advisee.advisorId = advisor.advisorId WHERE adviseeId = " + "@adviseeId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                if(adviseeTable.Rows.Count < 1)
                {
                    adviseeNameLabel.Text = "No student found";
                    advisorLabel.Text = string.Empty;
                    deleteButton.Enabled = false;
                }
                else
                {
                    DataRow dr = adviseeTable.Rows[0];
                    adviseeId = int.Parse(dr["adviseeId"].ToString());
                    adviseeNameLabel.Text = dr["adviseeName"].ToString();
                    advisorLabel.Text = dr["advisorName"].ToString();
                    deleteButton.Enabled = true;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("DELETE FROM advisee WHERE adviseeId = @adviseeId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@adviseeId", adviseeId);
                comd.ExecuteScalar();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
