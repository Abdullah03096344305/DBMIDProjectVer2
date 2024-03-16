namespace ver2
{
    partial class FormMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnReports = new Button();
            btnAssignAdviosr = new Button();
            btnGroups = new Button();
            btnEvalutionExamine = new Button();
            btnEvalutions = new Button();
            btnProjects = new Button();
            btnAdvisor = new Button();
            btnStudent = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            lblTitle = new Label();
            panel1 = new Panel();
            panelDesktopPane = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(btnReports);
            panelMenu.Controls.Add(btnAssignAdviosr);
            panelMenu.Controls.Add(btnGroups);
            panelMenu.Controls.Add(btnEvalutionExamine);
            panelMenu.Controls.Add(btnEvalutions);
            panelMenu.Controls.Add(btnProjects);
            panelMenu.Controls.Add(btnAdvisor);
            panelMenu.Controls.Add(btnStudent);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.ForeColor = Color.Beige;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 581);
            panelMenu.TabIndex = 0;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.ForeColor = Color.Beige;
            btnReports.Location = new Point(0, 318);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(11, 3, 0, 0);
            btnReports.Size = new Size(220, 34);
            btnReports.TabIndex = 8;
            btnReports.Text = "Generate Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnAssignAdviosr
            // 
            btnAssignAdviosr.Dock = DockStyle.Top;
            btnAssignAdviosr.FlatStyle = FlatStyle.Flat;
            btnAssignAdviosr.ForeColor = Color.Beige;
            btnAssignAdviosr.Location = new Point(0, 284);
            btnAssignAdviosr.Name = "btnAssignAdviosr";
            btnAssignAdviosr.Padding = new Padding(11, 3, 0, 0);
            btnAssignAdviosr.Size = new Size(220, 34);
            btnAssignAdviosr.TabIndex = 7;
            btnAssignAdviosr.Text = "Assign Advisor";
            btnAssignAdviosr.UseVisualStyleBackColor = true;
            btnAssignAdviosr.Click += btnAssignAdviosr_Click;
            // 
            // btnGroups
            // 
            btnGroups.Dock = DockStyle.Top;
            btnGroups.FlatStyle = FlatStyle.Flat;
            btnGroups.ForeColor = Color.Beige;
            btnGroups.Location = new Point(0, 250);
            btnGroups.Name = "btnGroups";
            btnGroups.Padding = new Padding(11, 3, 0, 0);
            btnGroups.Size = new Size(220, 34);
            btnGroups.TabIndex = 6;
            btnGroups.Text = "Groups";
            btnGroups.UseVisualStyleBackColor = true;
            btnGroups.Click += btnGroups_Click;
            // 
            // btnEvalutionExamine
            // 
            btnEvalutionExamine.Dock = DockStyle.Top;
            btnEvalutionExamine.FlatStyle = FlatStyle.Flat;
            btnEvalutionExamine.ForeColor = Color.Beige;
            btnEvalutionExamine.Location = new Point(0, 216);
            btnEvalutionExamine.Name = "btnEvalutionExamine";
            btnEvalutionExamine.Padding = new Padding(11, 3, 0, 0);
            btnEvalutionExamine.Size = new Size(220, 34);
            btnEvalutionExamine.TabIndex = 5;
            btnEvalutionExamine.Text = "Evalution Examine";
            btnEvalutionExamine.UseVisualStyleBackColor = true;
            btnEvalutionExamine.Click += btnEvalutionExamine_Click;
            // 
            // btnEvalutions
            // 
            btnEvalutions.Dock = DockStyle.Top;
            btnEvalutions.FlatStyle = FlatStyle.Flat;
            btnEvalutions.ForeColor = Color.Beige;
            btnEvalutions.Location = new Point(0, 182);
            btnEvalutions.Name = "btnEvalutions";
            btnEvalutions.Padding = new Padding(11, 3, 0, 0);
            btnEvalutions.Size = new Size(220, 34);
            btnEvalutions.TabIndex = 4;
            btnEvalutions.Text = "Evalutions";
            btnEvalutions.UseVisualStyleBackColor = true;
            btnEvalutions.Click += btnEvalutions_Click;
            // 
            // btnProjects
            // 
            btnProjects.Dock = DockStyle.Top;
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.ForeColor = Color.Beige;
            btnProjects.Location = new Point(0, 148);
            btnProjects.Name = "btnProjects";
            btnProjects.Padding = new Padding(11, 3, 0, 0);
            btnProjects.Size = new Size(220, 34);
            btnProjects.TabIndex = 3;
            btnProjects.Text = "Projects";
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            // 
            // btnAdvisor
            // 
            btnAdvisor.Dock = DockStyle.Top;
            btnAdvisor.FlatStyle = FlatStyle.Flat;
            btnAdvisor.ForeColor = Color.Beige;
            btnAdvisor.Location = new Point(0, 114);
            btnAdvisor.Name = "btnAdvisor";
            btnAdvisor.Padding = new Padding(11, 3, 0, 0);
            btnAdvisor.Size = new Size(220, 34);
            btnAdvisor.TabIndex = 2;
            btnAdvisor.Text = "Advisor";
            btnAdvisor.UseVisualStyleBackColor = true;
            btnAdvisor.Click += button1_Click;
            // 
            // btnStudent
            // 
            btnStudent.Dock = DockStyle.Top;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.ForeColor = Color.Beige;
            btnStudent.Location = new Point(0, 80);
            btnStudent.Name = "btnStudent";
            btnStudent.Padding = new Padding(11, 3, 0, 0);
            btnStudent.Size = new Size(220, 34);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(30, 21);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 2;
            label2.Text = "FYP MANAGER";
            label2.Click += label2_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(258, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(80, 30);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 150, 136);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 80);
            panel1.TabIndex = 2;
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(220, 80);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(664, 501);
            panelDesktopPane.TabIndex = 3;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 581);
            Controls.Add(panelDesktopPane);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 450);
            Name = "FormMainMenu";
            Text = "Form1";
            Load += FormMainMenu_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnStudent;
        private Panel panelLogo;
        private Button btnReports;
        private Button btnAssignAdviosr;
        private Button btnGroups;
        private Button btnEvalutionExamine;
        private Button btnEvalutions;
        private Button btnProjects;
        private Button btnAdvisor;
        private Label lblTitle;
        private Panel panel1;
        private Label label2;
        private Panel panelDesktopPane;
    }
}
