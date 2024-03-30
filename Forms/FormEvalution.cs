using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormEvalution : Form
    {
        public FormEvalution()
        {
            InitializeComponent();
        }

        private void FormEvalution_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
        }
      /*  bool checkPresence()
        {

            int id = 0;           
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Evaluation WHERE  Name = @Name AND TotalMarks = @TotalMarks AND TotalWeightage = @TotalWeightage", con);
            cmd.Parameters.AddWithValue("@FirstName", NametextBox.Text);
            cmd.Parameters.AddWithValue("@LastName", TotalMarkstextBox.Text);
            cmd.Parameters.AddWithValue("@Contact", TotalWeightagetextBox.Text);            

            int rowCount = (int)cmd.ExecuteScalar();

            if (rowCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
       /* private bool checkBoxes()
        {
            if (NametextBox.Text == null || NametextBox.Text == "" ||
                TotalMarkstextBox.Text == null || TotalMarkstextBox.Text == "" ||
                TotalWeightagetextBox.Text == null || TotalWeightagetextBox.Text == "" )
                
            {
                return false;
            }
            return true;
        }
        public void clearBoxes()
        {
            NametextBox.Text = "";
            TotalMarkstextBox.Text = "";
            TotalWeightagetextBox.Text = "";
        }*/
        private void updateTable()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            studentgridview.DataSource = dt;
        }
        private bool isEvalEmpty()
        {
            if (TotalMarkstextBox.Text == "" || NametextBox.Text == "" || TotalWeightagetextBox.Text == "")
            {
                return true;
            }
            return false;
        }

        private bool isEvalPresent()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Evaluation WHERE Name = @Name AND TotalMarks = @TotalMarks AND TotalWeightage = @TotalWeightage", con);
            cmd.Parameters.AddWithValue("@Name", NametextBox.Text);
            cmd.Parameters.AddWithValue("@TotalMarks", TotalMarkstextBox.Text);
            cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightagetextBox.Text);
            int rowCount = (int)cmd.ExecuteScalar();
            return rowCount > 0;
        }
        private void getData(string query, DataGridView grid)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (isEvalEmpty() || isEvalPresent())
            {
                MessageBox.Show("An Error Occured");
                return;
            }
            else
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation VALUES(@Name, @TotalMarks, @TotalWeightage)", con);
                cmd.Parameters.AddWithValue("@Name", NametextBox.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", TotalMarkstextBox.Text);
                cmd.Parameters.AddWithValue("@TotalWeightage", TotalWeightagetextBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Succussfully added");
                updateTable();
            }
        }

        private void studentgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
