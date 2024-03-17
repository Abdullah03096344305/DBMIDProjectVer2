using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ver2.Forms
{
    public partial class FormGroup : Form
    {
        private string connectionString = "Data Source=DESKTOP-GSR1O2M;Initial Catalog=ProjectA;Integrated Security=True";
        public FormGroup()
        {
            InitializeComponent();
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select RegistrationNo FROM Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            LoadRegistrationNumbers();
            LoadProjects();
        }
        private void LoadRegistrationNumbers()
        {
            try
            {
                string query = "SELECT RegistrationNo FROM Student";

                // Create connection and command objects
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Open connection
                    connection.Open();

                    // Execute command and load results into a DataTable
                    DataTable table = new DataTable();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }

                    // Bind the DataTable to the regnocombobox
                    regnocombobox.DataSource = table;
                    regnocombobox.DisplayMember = "RegistrationNo";
                    regnocombobox.ValueMember = "RegistrationNo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading registration numbers: " + ex.Message);
            }
        }


        private void regnocombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void LoadProjects()
        {
            try
            {
                string query = "SELECT Title FROM Project";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    DataTable table = new DataTable();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        table.Load(reader);
                    }
                    projectcomboBox.DataSource = table;
                    projectcomboBox.DisplayMember = "Title";
                    projectcomboBox.ValueMember = "Title";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading registration numbers: " + ex.Message);
            }
        }

        private void projectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (regnocombobox.SelectedIndex > -1)
            {
                string selectedItemText = regnocombobox.GetItemText(regnocombobox.SelectedItem);
                listBox1.Items.Add(selectedItemText);
            }
            if (listBox1.SelectedIndex > -1)
            {
                string selectedRegNo = listBox1.SelectedItem.ToString();
                int studentId = GetStudentIdByRegistrationNo(selectedRegNo);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Now you have the studentId, you can use it to insert into the GroupStudent table
                // along with the selected project and other details.
            }
        }

        private void groupgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (projectcomboBox.SelectedIndex > -1)
            {
                string selectedItemText = projectcomboBox.GetItemText(projectcomboBox.SelectedItem);
                listBox2.Items.Add(selectedItemText);
            }
            if (listBox2.SelectedIndex > -1)
            {
                string selectedProjectTitle = listBox2.SelectedItem.ToString();
                int projectId = GetProjectIdByTitle(selectedProjectTitle);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);

                // Now you have the projectId, you can use it to insert into the GroupStudent table
                // along with the selected student and other details.
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex > -1)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }
        DateTime DoB;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DoB = DateTime.Parse(dateTimePicker1.Text);
            MessageBox.Show(Text = DoB.ToString("yyyy-MM-dd"));
        }

        private int GetStudentIdByRegistrationNo(string registrationNo)
        {
            int studentId = -1;
            try
            {
                string query = "SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                    connection.Open();
                    studentId = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching student ID: " + ex.Message);
            }
            return studentId;
        }

        private int GetProjectIdByTitle(string title)
        {
            int projectId = -1;
            try
            {
                string query = "SELECT Id FROM Project WHERE Title = @Title";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", title);
                    connection.Open();
                    projectId = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching project ID: " + ex.Message);
            }
            return projectId;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Insert into the Group table to generate a new Group ID
                int groupId = InsertGroup();

                // Get selected registration numbers from listBox1
                List<string> selectedRegistrationNumbers = new List<string>();
                foreach (var item in listBox1.Items)
                {
                    selectedRegistrationNumbers.Add(item.ToString());
                }

                // Insert each selected registration number into the GroupStudent table
                foreach (var registrationNumber in selectedRegistrationNumbers)
                {
                    // Retrieve Student ID based on Registration Number
                    int studentId = GetStudentIdByRegistrationNumber(registrationNumber);

                    // Insert into GroupStudent table
                    InsertGroupStudent(groupId, studentId, DateTime.Now, 1); // Assuming Status = 3 for Active
                }

                MessageBox.Show("Data inserted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private int InsertGroup()
        {
            int groupId = -1;
            try
            {
                string groupQuery = "INSERT INTO [Group] (Created_On) VALUES (@CreatedOn); SELECT SCOPE_IDENTITY();";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand groupCommand = new SqlCommand(groupQuery, connection);
                    groupCommand.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
                    connection.Open();
                    groupId = Convert.ToInt32(groupCommand.ExecuteScalar()); // Retrieve the generated Group ID
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting data into Group table: " + ex.Message);
            }
            return groupId;
        }

        private int GetStudentIdByRegistrationNumber(string registrationNumber)
        {
            int studentId = -1;
            try
            {
                string query = "SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RegistrationNo", registrationNumber);
                    connection.Open();
                    studentId = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving student ID: " + ex.Message);
            }
            return studentId;
        }

        private void InsertGroupStudent(int groupId, int studentId, DateTime assignmentDate, int status)
        {
            try
            {
                string query = "INSERT INTO GroupStudent (GroupId, StudentId, AssignmentDate, Status) " +
                               "VALUES (@GroupId, @StudentId, @AssignmentDate, @Status)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GroupId", groupId);
                    command.Parameters.AddWithValue("@StudentId", studentId);
                    command.Parameters.AddWithValue("@AssignmentDate", assignmentDate);
                    command.Parameters.AddWithValue("@Status", status);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while inserting data into GroupStudent table: " + ex.Message);
            }
        }
       


    }
}
