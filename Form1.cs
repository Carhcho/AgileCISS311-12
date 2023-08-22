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
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection conn;
        int adviseeId;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["dropbox13.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("SELECT adviseeId, adviseeName FROM advisee WHERE adviseeId = " + "@adviseeId", conn))
            using (SqlDataAdapter adapter = new SqlDataAdapter(comd))
            {
                comd.Parameters.AddWithValue("@adviseeId", adviseeIdTextBox.Text);
                DataTable adviseeTable = new DataTable();
                adapter.Fill(adviseeTable);
                if (adviseeTable.Rows.Count < 1)
                    currentNameLabel.Text = "No Student found";
                else
                {
                    newNameTextBox.Enabled = true;
                    newNameTextBox.Focus();
                    updateButton.Enabled = true;
                    DataRow dr = adviseeTable.Rows[0];
                    adviseeId = int.Parse(dr["adviseeId"].ToString());
                    currentNameLabel.Text = dr["adviseeName"].ToString();
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
            using (SqlCommand comd = new SqlCommand("UPDATE advisee SET adviseeName" + "= @adviseeNewName WHERE adviseeId = @adviseeId", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@adviseeNewName", newNameTextBox.Text);
                comd.Parameters.AddWithValue("@adviseeId", adviseeId);
                comd.ExecuteScalar();
                MessageBox.Show("Record Updated.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
