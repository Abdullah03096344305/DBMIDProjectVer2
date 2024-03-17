using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ver2.Forms
{
    public partial class FormProjects : Form
    {
        
        public FormProjects()
        {
            InitializeComponent();
        }

        private void FormProjects_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * FROM Project", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            projectgridview.DataSource = dt;
        }

        private void titletxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptiontxt_TextChanged(object sender, EventArgs e)
        {

        }
        int gender;
        DateTime DoB;
        int GetMaxPersonId()
        {

            string selectMaxIdQuery = "SELECT Top 1 Id FROM Project ORDER BY Id DESC ;";
            var con = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand(selectMaxIdQuery, con);
            return (int)command.ExecuteScalar();

        }

        private string registrationNumber;
        private string Firstname;
        private string Lastname;
        private string Contact;
        private string Email;
        private int Gender;
        private DateTime dateofbirth;

        /*void getGender()
        {

            if (gendercombo.Text == "Male")
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }

        }*/
        bool checkPresence()
        {
            if (descriptiontxt == null || titletxt == null || Configuration.getInstance() == null)
            {
                MessageBox.Show("Error: One or more objects are not properly initialized.");
                return false;
            }

            var con = Configuration.getInstance().getConnection();
            if (con == null)
            {
                MessageBox.Show("Error: Database connection is not properly initialized.");
                return false;
            }

            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Project WHERE Description = @Description AND Title = @Title ", con);
            cmd.Parameters.AddWithValue("@Description", descriptiontxt.Text);
            cmd.Parameters.AddWithValue("@Title", titletxt.Text);

            int rowCount = (int)cmd.ExecuteScalar();

            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool checkBoxes()
        {
            if (descriptiontxt == null || descriptiontxt.Text == "" ||
                titletxt == null || titletxt.Text == "")
            {
                MessageBox.Show("Error: Please fill out all the requirements.");
                return false;
            }
            return true;
        }
        public void clearBoxes()
        {
            if (descriptiontxt != null && titletxt != null)
            {
                descriptiontxt.Text = "";
                titletxt.Text = "";
            }
            else
            {
                MessageBox.Show("Error: One or more objects are not properly initialized.");
            }
        }
        private void updateTable()
        {
            var con = Configuration.getInstance().getConnection();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Project", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                projectgridview.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Error: Database connection is not properly initialized.");
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                if (checkPresence())
                {
                    MessageBox.Show("Error: This project already exists.");
                }
                else
                {
                    var con = Configuration.getInstance().getConnection();
                    if (con != null)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Project(Description, Title) VALUES (@Description, @Title)", con);
                        cmd.Parameters.AddWithValue("@Description", descriptiontxt.Text);
                        cmd.Parameters.AddWithValue("@Title", titletxt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Project has been added successfully.");
                        updateTable();
                        clearBoxes();
                    }
                    else
                    {
                        MessageBox.Show("Error: Database connection is not properly initialized.");
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (projectgridview.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(projectgridview.SelectedRows[0].Cells["Id"].Value);
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("UPDATE Project SET Description = @Description, Title = @Title WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Description", descriptiontxt.Text);
                    cmd.Parameters.AddWithValue("@Title", titletxt.Text);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Updated");
                    updateTable();
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Updating the Record: " + ex.Message);
            }
        }
        int getID()
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Project WHERE Description = @Description AND Title = @Title", con);
            cmd.Parameters.AddWithValue("@Description", descriptiontxt.Text);
            cmd.Parameters.AddWithValue("@Title", titletxt.Text);
            id = (int)cmd.ExecuteScalar();
            return id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected in the DataGridView
                if (projectgridview.SelectedRows.Count > 0)
                {
                    // Get the ID of the selected project from the DataGridView
                    int id = Convert.ToInt32(projectgridview.SelectedRows[0].Cells["Id"].Value);

                    // Delete the record from the Project table
                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Project WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Successfully Deleted");
                    updateTable(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Deleting the Record: " + ex.Message);
            }
        }

        private void projectgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row and not on the header row
            if (e.RowIndex >= 0 && e.RowIndex < projectgridview.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = projectgridview.Rows[e.RowIndex];

                // Populate textboxes with data from the selected row
                descriptiontxt.Text = selectedRow.Cells["Description"].Value.ToString();
                titletxt.Text = selectedRow.Cells["Title"].Value.ToString();
            }
        }
    }
}
