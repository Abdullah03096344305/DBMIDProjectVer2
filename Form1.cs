using System.Runtime.InteropServices;

namespace ver2
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
           
        }
       
        private void FormMainMenu_Load(object sender, EventArgs e)
        {

        }
        //Methods
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Navy;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Beige;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStudent(), sender);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAdvisor(), sender);
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEvalutions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnEvalutionExamine_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnAssignAdviosr_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
