using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ver2.Forms
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Student.RegistrationNo,Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,CASE WHEN Person.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender FROM Student INNER JOIN Person ON Student.Id=Person.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int gender;
        DateTime DoB;

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxes() == true)
            {
                if (checkPresence() == false)
                {
                    try
                    {
                        getGender();
                        DoB = DateTime.Parse(dateofbirthbox.Text);
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("Insert into Person values (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
                        cmd.Parameters.AddWithValue("@FirstName", (firstnametxt.Text));
                        cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
                        cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.ExecuteNonQuery();

                        int Id = GetMaxPersonId();

                        var con2 = Configuration.getInstance().getConnection();
                        SqlCommand cmd2 = new SqlCommand("Insert into Student values (@Id, @RegisterationNo)", con2);
                        cmd2.Parameters.AddWithValue("@Id", Id);
                        cmd2.Parameters.AddWithValue("@RegisterationNo", registrationnotxt.Text);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Successfully saved");
                        clearBoxes();
                        updateTable();
                    }
                    catch
                    {
                        MessageBox.Show("An Error Occured While Running the Query");
                    }

                }
                else
                {
                    MessageBox.Show("This Person Already Exists");
                }

            }
            else
            {
                MessageBox.Show("please fill out all the requirements");
            }
        }
        int GetMaxPersonId()
        {

            string selectMaxIdQuery = "SELECT Top 1 Id FROM Person ORDER BY Id DESC ;";
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

        void getGender()
        {

            if (gendercombo.Text == "Male")
            {
                gender = 1;
            }
            else
            {
                gender = 2;
            }

        }
        bool checkPresence()
        {

            int id = 0;
            getGender();
            DoB = DateTime.Parse(dateofbirthbox.Text);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Person WHERE  FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email AND DateOfBirth = @DateOfBirth AND Gender = @Gender", con);
            cmd.Parameters.AddWithValue("@FirstName", firstnametxt.Text);
            cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
            cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
            cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
            cmd.Parameters.AddWithValue("@Gender", gender);

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
        private void studentgridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = studentgridview.Rows[e.RowIndex];
                registrationnotxt.Text = selectedRow.Cells["RegistrationNo"].Value.ToString();
                firstnametxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lastnametxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                contacttxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                emailtxt.Text = selectedRow.Cells["Email"].Value.ToString();
                gendercombo.Text = selectedRow.Cells["Gender"].Value.ToString();
                dateofbirthbox.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);

                registrationNumber = registrationnotxt.Text;
                Firstname = firstnametxt.Text;
                Lastname = lastnametxt.Text;
                Contact = contacttxt.Text;
                Email = emailtxt.Text;
                dateofbirth = dateofbirthbox.Value;
                if (gendercombo.Text == "Male")
                {
                    Gender = 1;
                }
                else
                {
                    Gender = 2;
                }

            }
        }
        private bool checkBoxes()
        {
            if (registrationnotxt.Text == null || registrationnotxt.Text == "" ||
                firstnametxt.Text == null || firstnametxt.Text == "" ||
                lastnametxt.Text == null || lastnametxt.Text == "" ||
                emailtxt.Text == null || emailtxt.Text == "" ||
                contacttxt.Text == null || contacttxt.Text == "" ||
                gendercombo.Text == null || gendercombo.Text == "" ||
                dateofbirthbox.Text == null)
            {
                return false;
            }
            return true;
        }
        public void clearBoxes()
        {
            registrationnotxt.Text = "";
            firstnametxt.Text = "";
            lastnametxt.Text = "";
            emailtxt.Text = "";
            contacttxt.Text = "";
            gendercombo.Text = "Male";
            dateofbirthbox.Text = "";
            registrationnotxt.Text = "";
            firstnametxt.Text = "";
            lastnametxt.Text = "";
            emailtxt.Text = "";
            contacttxt.Text = "";
            gender = 0;
            DoB = DateTime.MinValue;
        }
        private void updateTable()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Student.RegistrationNo,Person.FirstName,Person.LastName,Person.Contact,Person.Email,Person.DateOfBirth,CASE WHEN Person.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender FROM Student INNER JOIN Person ON Student.Id=Person.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
        }

        private void gendercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                try
                {
                    getGender();
                    DoB = Convert.ToDateTime(dateofbirthbox.Value);
                    var con = Configuration.getInstance().getConnection();
                    int id = getID(); // Retrieve ID

                    // Update Person table
                    SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstnametxt.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
                    cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
                    cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    // Update Student table - Update RegistrationNo for the same ID
                    SqlCommand cmd2 = new SqlCommand("UPDATE Student SET RegisterationNo = @RegisterationNo WHERE Id = @Id", con);
                    cmd2.Parameters.AddWithValue("@RegisterationNo", registrationnotxt.Text);
                    cmd2.Parameters.AddWithValue("@Id", id);
                    cmd2.ExecuteNonQuery();  // Executing the update query

                    MessageBox.Show("Successfully Updated");
                    clearBoxes();
                    updateTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occurred While Updating the Data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the requirements");
            }
        }

        int getID()
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo", con);
            cmd.Parameters.AddWithValue("@RegistrationNo", registrationnotxt.Text);
            id = (int)cmd.ExecuteScalar();
            return id;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                // Get the ID of the selected student
                int id = getID();

                // Delete the record from the Student and Person tables
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE Id = @Id; DELETE FROM Person WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Deleted");
                updateTable(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occurred While Deleting the Record: " + ex.Message);
            }
        }

        private void studentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = studentgridview.Rows[e.RowIndex];
                registrationnotxt.Text = selectedRow.Cells["RegistrationNo"].Value.ToString();
                firstnametxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lastnametxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                contacttxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                emailtxt.Text = selectedRow.Cells["Email"].Value.ToString();
                gendercombo.Text = selectedRow.Cells["Gender"].Value.ToString();
                dateofbirthbox.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);

                // Assign values to class-level variables for potential update
                registrationNumber = registrationnotxt.Text;
                Firstname = firstnametxt.Text;
                Lastname = lastnametxt.Text;
                Contact = contacttxt.Text;
                Email = emailtxt.Text;
                dateofbirth = dateofbirthbox.Value;
                if (gendercombo.Text == "Male")
                {
                    Gender = 1;
                }
                else
                {
                    Gender = 2;
                }
            }
        }

        private void dateofbirthbox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
