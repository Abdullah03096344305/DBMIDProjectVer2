using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormGroup : Form
    {
        public FormGroup()
        {
            InitializeComponent();
        }
        struct Pair
        {
            public Pair(string id, string name)
            {
                this.id = id;
                this.name = name;
            }

            public string id;
            public string name;
        }

        int Editid = 0;
        int EditAdvisorid = 0;
        int EditProjectid = 0;
        int CurrentId = 0;


        private void FormGroup_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select [Group].Id,[Group].Created_On,Project.Title as ProjectTitle  FROM ([Group] JOIN GroupProject ON [Group].Id=GroupProject.GroupId) JOIN Project ON GroupProject.ProjectId=Project.Id WHERE Project.Title NOT LIKE '-%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
            comboBox1.Items.Clear();
            getProjectIds();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void studentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = studentgridview.CurrentCell.RowIndex;
            int id = Convert.ToInt32(studentgridview.Rows[index].Cells[0].Value);
            CurrentId = id;
            getStudents();
            getStudentData();
        }
        List<Pair> Students = new List<Pair>();
        List<Pair> Projects = new List<Pair>();
        private void getProjectIds()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT id, Title FROM Project WHERE id NOT IN (SELECT Projectid FROM GroupProject) AND Project.Title NOT LIKE '-%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                comboBox1.Items.Add(row[1].ToString());
                Projects.Add(new Pair(id, row[1].ToString()));
            }
        }

        private void getStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.id, FirstName + ' ' + LastName FROM Person JOIN Student On Person.id = Student.id WHERE Student.id NOT IN (SELECT Studentid FROM GroupStudent) AND Person.FirstName NOT LIKE '-%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string id = row[0].ToString();
                comboBox2.Items.Add(row[1].ToString());
                Students.Add(new Pair(id, row[1].ToString()));
            }
        }
        private bool isGroupFree()
        {           
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GroupStudent JOIN Student ON student.Id = GroupStudent.StudentId WHERE GroupId = @GroupId AND Student.RegistrationNo NOT LIKE '-%'", con);
            cmd.Parameters.AddWithValue("@GroupId", CurrentId);
            return (int)cmd.ExecuteScalar() < 5;
        }

        private void getStudentData()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT GroupStudent.GroupId, Student.RegistrationNo, Person.FirstName+' '+Person.LastName as StudentName, CASE WHEN Status = '3' THEN 'ACTIVE' WHEN Status = '4' THEN 'INACTIVE' END AS Status  FROM GroupStudent JOIN Person ON Person.Id=GroupStudent.StudentId JOIN Student ON GroupStudent.StudentId=Student.Id  Where GroupStudent.GroupId=@GroupId AND Student.RegistrationNo NOT LIKE '-%' AND GroupStudent.Status <> 4", con);
            cmd.Parameters.AddWithValue("@groupId", CurrentId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
        }

        private void addbtn2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                MessageBox.Show("Select a Student to assign");
                return;
            }
            if (!isGroupFree())
            {
                MessageBox.Show("Group is full");
                return;
            }
            DateTime date = DateTime.Now;
            var con = Configuration.getInstance().getConnection();

            foreach (Pair p in Students)
            {
                if (comboBox2.Text == p.name)
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent VALUES(@GroupId, @StudentId, @Status, @AssignmentDate)", con);
                    cmd.Parameters.AddWithValue("@GroupId", CurrentId);
                    cmd.Parameters.AddWithValue("@StudentId", p.id);
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    break;
                }
            }
            MessageBox.Show("Succussfully added");
            getStudentData();
            comboBox2.Items.Clear();
            getStudents();
        }
    }
}
