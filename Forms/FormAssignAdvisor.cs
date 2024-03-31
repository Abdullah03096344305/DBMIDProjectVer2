using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormAssignAdvisor : Form
    {
        public FormAssignAdvisor()
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

       
        int CurrentAdvisorProjectId = 0;

        private void groupgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAssignAdvisor_Load(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT PA.ProjectId,MAX(P.Title) AS ProjectTitle,MAX(P.Description) AS Description,MAX(CASE WHEN PA.AdvisorRole = 11 THEN CONCAT(Pers.FirstName, ' ', Pers.LastName) END) AS MainAdvisor,MAX(CASE WHEN PA.AdvisorRole = 12 THEN CONCAT(Pers.FirstName, ' ', Pers.LastName) END) AS CoAdvisor,MAX(CASE WHEN PA.AdvisorRole = 14 THEN CONCAT(Pers.FirstName, ' ', Pers.LastName) END) AS IndustryAdvisor FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN   Project P ON P.Id = PA.ProjectId JOIN Person Pers ON Pers.Id = A.Id WHERE P.Title NOT LIKE '-%' AND A.Salary NOT LIKE '-%' GROUP BY PA.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupgridview.DataSource = dt;

            var con2 = Configuration.getInstance().getConnection();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Project WHERE Id NOT IN(SELECT ProjectId FROM ProjectAdvisor) AND Project.Title NOT LIKE '-%'", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            CurrentAdvisorProjectId = int.Parse(id);
            getData("SELECT * FROM Project WHERE Id NOT IN (SELECT ProjectId FROM GroupProject) AND Project.Title NOT LIKE '-%'", dataGridView1);
            getMainAdvisors();
            MainAdvisorBox.Enabled = true;
            CoAdvisorBox.Enabled = true;
            IndustrialAdvisorBox.Enabled = true;
            addbtn2.Enabled = false;
            addbtn3.Enabled = false;
        }
        List<Pair> MAdvisor = new List<Pair>();
        List<Pair> CAdvisor = new List<Pair>();
        List<Pair> IAdvisor = new List<Pair>();

        private void getMainAdvisors()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.FirstName+' '+Person.LastName, Person.Id as ProjectTitle FROM Advisor JOIN Person ON Advisor.Id=Person.Id WHERE Person.id NOT LIKE '-%'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string name = row[0].ToString();
                MainAdvisorBox.Items.Add(name);
                MAdvisor.Add(new Pair(row[1].ToString(), name));
            }
        }

        private void getCoAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.FirstName+' '+Person.LastName, Person.Id as ProjectTitle FROM Advisor JOIN Person ON Advisor.Id=Person.Id WHERE Person.FirstName+' '+Person.LastName NOT IN (@main_advisor) AND Person.id NOT LIKE '-%'", con);
            cmd.Parameters.AddWithValue("@main_advisor", MainAdvisorBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string name = row[0].ToString();
                CoAdvisorBox.Items.Add(name);
                CAdvisor.Add(new Pair(row[1].ToString(), name));
            }
        }

        private void getIndustrialAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Person.FirstName+' '+Person.LastName, Person.Id as ProjectTitle FROM Advisor JOIN Person ON Advisor.Id=Person.Id WHERE Person.FirstName+' '+Person.LastName NOT IN (@main_advisor, @co_advisor) AND Person.id NOT LIKE '-%'", con);
            cmd.Parameters.AddWithValue("@main_advisor", MainAdvisorBox.Text);
            cmd.Parameters.AddWithValue("@co_advisor", CoAdvisorBox.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                string name = row[0].ToString();
                IndustrialAdvisorBox.Items.Add(name);
                IAdvisor.Add(new Pair(row[1].ToString(), name));
            }
        }

        private void addbtn2_Click(object sender, EventArgs e)
        {
            if (CoAdvisorBox.Text == "")
            {
                return;
            }
            CoAdvisorBox.Enabled = false;
            addbtn3.Enabled = true;
            getIndustrialAdvisor();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (MainAdvisorBox.Text == "")
            {
                return;
            }
            MainAdvisorBox.Enabled = false;
            addbtn2.Enabled = true;
            getCoAdvisor();
        }

        private void addbtn3_Click(object sender, EventArgs e)
        {
            if (IndustrialAdvisorBox.Text == "")
            {
                return;
            }
            IndustrialAdvisorBox.Enabled = false;
            var con = Configuration.getInstance().getConnection();
            SqlTransaction transaction = con.BeginTransaction();
            Pair MainAdvisor = getSelectedAdvisor(MAdvisor, MainAdvisorBox.Text);
            Pair CoAdvisor = getSelectedAdvisor(CAdvisor, CoAdvisorBox.Text);
            Pair IndustrialAdvisor = getSelectedAdvisor(IAdvisor, IndustrialAdvisorBox.Text);
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES(@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con, transaction);
                cmd.Parameters.AddWithValue("@AdvisorId", MainAdvisor.id);
                cmd.Parameters.AddWithValue("@ProjectId", CurrentAdvisorProjectId);
                cmd.Parameters.AddWithValue("@AdvisorRole", getAdvisorId("Main Advisor"));
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES(@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con, transaction);
                cmd.Parameters.AddWithValue("@AdvisorId", CoAdvisor.id);
                cmd.Parameters.AddWithValue("@ProjectId", CurrentAdvisorProjectId);
                cmd.Parameters.AddWithValue("@AdvisorRole", getAdvisorId("Co Advisor"));
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO ProjectAdvisor VALUES(@AdvisorId, @ProjectId, @AdvisorRole, @AssignmentDate)", con, transaction);
                cmd.Parameters.AddWithValue("@AdvisorId", IndustrialAdvisor.id);
                cmd.Parameters.AddWithValue("@ProjectId", CurrentAdvisorProjectId);
                cmd.Parameters.AddWithValue("@AdvisorRole", getAdvisorId("Industrial Advisor"));
                cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                transaction.Commit();
                MainAdvisorBox.Text = CoAdvisorBox.Text = IndustrialAdvisorBox.Text = "";
                getData("SELECT * FROM Project WHERE Id NOT IN (SELECT ProjectId FROM ProjectAdvisor) AND Project.Title NOT LIKE '-%'", dataGridView1);

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message);
            }
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
        private int getAdvisorId(string role)
        {
            switch (role)
            {
                case "Main Advisor":
                    return 11;
                case "Co Advisor":
                    return 12;
                case "Industrial Advisor":
                    return 14;
                default:
                    return 0;
            }
        }


        private Pair getSelectedAdvisor(List<Pair> Advisors, string name)
        {
            foreach (Pair p in Advisors)
            {
                if (p.name == name)
                {
                    return p;
                }
            }
            return new Pair("", "");
        }
    }
}
