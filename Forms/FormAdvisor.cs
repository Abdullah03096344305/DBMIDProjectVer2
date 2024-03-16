using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormAdvisor : Form
    {
        public FormAdvisor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAdvisor_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth,Advisor.Designation,Advisor.Salary, CASE WHEN Person.Gender = 1 THEN 'Male' ELSE 'Female' END AS Gender FROM Advisor INNER JOIN Person ON Advisor.Id = Person.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorgridview.DataSource = dt;
        }

        int gender;
        DateTime DoB;

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (checkBoxes())
            {
                if (!checkPresence())
                {
                    try
                    {
                        getGender();
                        DoB = DateTime.Parse(dateofbirthbox.Text);
                        var con = Configuration.getInstance().getConnection();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Person values (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
                        cmd.Parameters.AddWithValue("@FirstName", firstnametxt.Text);
                        cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
                        cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                        cmd.ExecuteNonQuery();

                        int Id = GetMaxPersonId();

                        // Assign ID based on designation
                        int designationId;
                        switch (designaationcombobox.Text)
                        {
                            case "Professor":
                                designationId = 6;
                                break;
                            case "Associate Professor":
                                designationId = 7;
                                break;
                            case "Assistant Professor":
                                designationId = 8;
                                break;
                            case "Lecturer":
                                designationId = 9;
                                break;
                            case "Industry Professional":
                                designationId = 10;
                                break;
                            default:
                                designationId = 0; // Default value if designation is not recognized
                                break;
                        }

                        // Insert into Advisor table with the assigned designation ID
                        SqlCommand cmd2 = new SqlCommand("Insert into Advisor values (@Id, @Designation, @Salary)", con);
                        cmd2.Parameters.AddWithValue("@Id", Id);
                        cmd2.Parameters.AddWithValue("@Salary", salarytxt.Text);
                        cmd2.Parameters.AddWithValue("@Designation", designationId);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Successfully saved");
                        clearBoxes();
                        updateTable();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An Error Occurred While Running the Query: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("This Person Already Exists");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all the requirements");
            }
        }

        private bool checkBoxes()
        {
            return !string.IsNullOrWhiteSpace(firstnametxt.Text) &&
                   !string.IsNullOrWhiteSpace(lastnametxt.Text) &&
                   !string.IsNullOrWhiteSpace(contacttxt.Text) &&
                   !string.IsNullOrWhiteSpace(dateofbirthbox.Text) &&
                   !string.IsNullOrWhiteSpace(emailtxt.Text) &&
                   !string.IsNullOrWhiteSpace(gendercombo.Text);
        }
        public void clearBoxes()
        {
            firstnametxt.Clear();
            lastnametxt.Clear();
            emailtxt.Clear();
            contacttxt.Clear();
            gendercombo.Text = "Male";
            dateofbirthbox.Text = "";
        }
        private void updateTable()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, CASE WHEN Person.Gender,Advisor.Designation,Advisor.Salary = 1 THEN 'Male' ELSE 'Female' END AS Gender FROM Advisor INNER JOIN Person ON Advisor.Id = Person.Id", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorgridview.DataSource = dt;
        }
        int GetMaxPersonId()
        {
            string selectMaxIdQuery = "SELECT TOP 1 Id FROM Person ORDER BY Id DESC";
            var con = Configuration.getInstance().getConnection();
            SqlCommand command = new SqlCommand(selectMaxIdQuery, con);
            return (int)command.ExecuteScalar();
        }
        private string Firstname;
        private string Lastname;
        private string Contact;
        private string Email;
        private int Gender;
        private DateTime dateofbirth;

        void getGender()
        {

            gender = gendercombo.Text == "Male" ? 1 : 2;
        }
        bool checkPresence()
        {
            getGender();
            DoB = DateTime.Parse(dateofbirthbox.Text);
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Person WHERE FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email AND DateOfBirth = @DateOfBirth AND Gender = @Gender", con);
            cmd.Parameters.AddWithValue("@FirstName", firstnametxt.Text);
            cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
            cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
            cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
            cmd.Parameters.AddWithValue("@Gender", gender);
            int rowCount = (int)cmd.ExecuteScalar();
            return rowCount > 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* if (advisorgridview.SelectedRows.Count > 0)
             {
                 try
                 {
                     DataGridViewRow selectedRow = advisorgridview.SelectedRows[0];
                     int id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                     var con = Configuration.getInstance().getConnection();
                     SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE Id = @Id; DELETE FROM Person WHERE Id = @Id", con);
                     cmd.Parameters.AddWithValue("@Id", id);
                     cmd.ExecuteNonQuery();

                     MessageBox.Show("Successfully Deleted");
                     updateTable();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("An Error Occurred While Deleting: " + ex.Message);
                 }
             }
             else
             {
                 MessageBox.Show("Please select a row to delete");
             }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if (checkBoxes())
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
                    //cmd2.Parameters.AddWithValue("@RegisterationNo", registrationnotxt.Text);
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
            }*/
        }
        int getID()
        {
            int id = 0;
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Advisor WHERE Salary = @Salary", con);
            cmd.Parameters.AddWithValue("@Salary", salarytxt.Text);
            id = (int)cmd.ExecuteScalar();
            return id;
        }

        private void advisorgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = advisorgridview.Rows[e.RowIndex];
                firstnametxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lastnametxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                contacttxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                dateofbirthbox.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                gendercombo.Text = selectedRow.Cells["Gender"].Value.ToString();
                emailtxt.Text = selectedRow.Cells["Email"].Value.ToString();
                salarytxt.Text = selectedRow.Cells["Salary"].Value.ToString();



                // Assign values to class-level variables for potential update
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
            }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Delete Button Functionality
            try
            {
                // Get the ID of the selected student
                int id = getID();

                // Delete the record from the Student and Person tables
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Advisor WHERE Id = @Id; DELETE FROM Person WHERE Id = @Id", con);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Update Button Functionality Doesnt Work Correctly So dont copy from here

            if (checkBoxes())
            {
                try
                {
                    getGender();
                    DoB = Convert.ToDateTime(dateofbirthbox.Value);
                    var con = Configuration.getInstance().getConnection();
                    int id = getID(); // Retrieve ID

                    // Update Person table
                    SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender, Salary = @Salary WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@FirstName", firstnametxt.Text);
                    cmd.Parameters.AddWithValue("@LastName", lastnametxt.Text);
                    cmd.Parameters.AddWithValue("@Contact", contacttxt.Text);
                    cmd.Parameters.AddWithValue("@Email", emailtxt.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", DoB);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Salary", salarytxt.Text); // Parameter name corrected here
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    // Update Advisor table - Update Designation and Salary for the same ID
                    SqlCommand cmd2 = new SqlCommand("UPDATE Advisor SET Designation = @Designation, Salary = @Salary WHERE Id = @Id", con);
                    cmd2.Parameters.AddWithValue("@Designation", designaationcombobox.Text);
                    cmd2.Parameters.AddWithValue("@Salary", salarytxt.Text); // Parameter name corrected here
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

        private void advisorgridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = advisorgridview.Rows[e.RowIndex];
                firstnametxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                lastnametxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                contacttxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                dateofbirthbox.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                gendercombo.Text = selectedRow.Cells["Gender"].Value.ToString();
                emailtxt.Text = selectedRow.Cells["Email"].Value.ToString();
                salarytxt.Text = selectedRow.Cells["Salary"].Value.ToString();



                // Assign values to class-level variables for potential update
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
    }
}
