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
    public partial class Form2 : Form
    {
        string connectionString;
        SqlConnection conn;
        int adviseeId;
        public Form2()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox13.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM advisor", conn))
            {
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);
                newAdvisorComboBox.DisplayMember = "advisorName";
                newAdvisorComboBox.ValueMember = "advisorId";
                newAdvisorComboBox.DataSource = advisorTable;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT adviseeId, adviseeName, advisor.advisorName FROM advisee" + " JOIN advisor ON advisee.advisorId = advisor.advisorId " + "WHERE adviseeId = @adviseeId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                if(adviseeTable.Rows.Count < 1)
                {
                    adviseeNameLabel.Text = "No advisee found";
                    newAdvisorComboBox.Enabled = false;
                    updateButton.Enabled = false;
                    currentAdvisorLabel.Text = string.Empty;
                }
                else
                {
                    DataRow dr = adviseeTable.Rows[0];
                    adviseeId = int.Parse(dr["adviseeId"].ToString());
                    adviseeNameLabel.Text = dr["adviseeName"].ToString();
                    newAdvisorComboBox.Enabled = true;
                    updateButton.Enabled = true;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("UPDATE advisee SET advisorId = @advisorId " + "WHERE adviseeId = @adviseeId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@advisorId", newAdvisorComboBox.SelectedValue);
                comd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                comd.ExecuteScalar();
                MessageBox.Show("Record updated.");
            }
        }
    }
}
