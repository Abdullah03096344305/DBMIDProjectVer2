using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ver2.Forms
{
    public partial class FormEvalutionExamine : Form
    {
        int CurrentEvalGroupId = 0;
        List<Pair> Evaluations = new List<Pair>();

        public FormEvalutionExamine()
        {
            InitializeComponent();
            evaluationgridview.CellContentClick += evaluationgridview_CellContentClick;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void FormEvalutionExamine_Load(object sender, EventArgs e)
        {
            LoadExistingEvaluations();
            getFreeEvaluations();
        }

        private void LoadExistingEvaluations()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT G.id AS GroupId, P.Title FROM [Group] G JOIN GroupProject GP ON G.Id = GP.GroupId JOIN Project P ON GP.ProjectId = P.Id JOIN GroupEvaluation GE ON GE.GroupId = G.Id JOIN Evaluation E ON E.Id = GE.EvaluationId WHERE P.Title NOT LIKE '-%' GROUP BY G.id, P.Title", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            evaluationgridview.DataSource = dt;
        }

        private void getFreeEvaluations()
        {
            comboBox1.Items.Clear();
            Evaluations.Clear();

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Evaluation.Id, Evaluation.Name FROM Evaluation WHERE Evaluation.Id NOT IN (SELECT EvaluationId FROM GroupEvaluation WHERE GroupId = @GroupId) AND Evaluation.Name NOT LIKE '-%'", con);
            cmd.Parameters.AddWithValue("@GroupId", CurrentEvalGroupId);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader["Id"].ToString();
                string name = reader["Name"].ToString();
                comboBox1.Items.Add(name);
                Evaluations.Add(new Pair(id, name));
            }
            reader.Close();
        }

        private void evaluationgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = evaluationgridview.CurrentRow.Cells[0].Value.ToString();
                CurrentEvalGroupId = int.Parse(id);
                getData("SELECT GE.EvaluationId, E.Name, E.TotalMarks, E.TotalWeightage FROM GroupEvaluation GE JOIN [Group] G ON G.Id = GE.GroupId JOIN Evaluation E ON GE.EvaluationId = E.Id WHERE G.Id = @GroupId AND E.Name NOT LIKE '-%'", evaluationgridview);
                getFreeEvaluations();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObtainedMarksTextBox.Enabled = true;
            buttonAddEvaluation.Enabled = true;
        }

        private void getData(string query, DataGridView grid)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@GroupId", CurrentEvalGroupId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid.DataSource = dt;
        }

        private void buttonAddEvaluation_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select an evaluation to assign");
                return;
            }

            string selectedEvaluationId = "";
            foreach (Pair p in Evaluations)
            {
                if (comboBox1.Text == p.name)
                {
                    selectedEvaluationId = p.id;
                    break;
                }
            }

            if (selectedEvaluationId != "")
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation VALUES(@GroupId, @EvaluationId, @ObtainedMarks, @EvaluationDate)", con);
                cmd.Parameters.AddWithValue("@GroupId", CurrentEvalGroupId);
                cmd.Parameters.AddWithValue("@EvaluationId", selectedEvaluationId);
                cmd.Parameters.AddWithValue("@ObtainedMarks", ObtainedMarksTextBox.Text);
                cmd.Parameters.AddWithValue("@EvaluationDate", DateTime.Now);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully added");
                getData("SELECT GE.EvaluationId, E.Name, E.TotalMarks, E.TotalWeightage FROM GroupEvaluation GE JOIN [Group] G ON G.Id = GE.GroupId JOIN Evaluation E ON GE.EvaluationId = E.Id WHERE G.Id = @GroupId AND E.Name NOT LIKE '-%'", evaluationgridview);
                comboBox1.Items.Clear();
                getFreeEvaluations();
            }
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
    }
}
