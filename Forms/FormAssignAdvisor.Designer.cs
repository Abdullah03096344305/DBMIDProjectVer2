namespace ver2.Forms
{
    partial class FormAssignAdvisor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupgridview = new DataGridView();
            dataGridView1 = new DataGridView();
            MainAdvisorBox = new ComboBox();
            CoAdvisorBox = new ComboBox();
            IndustrialAdvisorBox = new ComboBox();
            addbtn = new Button();
            addbtn2 = new Button();
            addbtn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)groupgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupgridview
            // 
            groupgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupgridview.Location = new Point(12, -1);
            groupgridview.Name = "groupgridview";
            groupgridview.Size = new Size(624, 164);
            groupgridview.TabIndex = 42;
            groupgridview.CellContentClick += groupgridview_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(624, 178);
            dataGridView1.TabIndex = 43;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MainAdvisorBox
            // 
            MainAdvisorBox.FormattingEnabled = true;
            MainAdvisorBox.Location = new Point(12, 353);
            MainAdvisorBox.Name = "MainAdvisorBox";
            MainAdvisorBox.Size = new Size(198, 23);
            MainAdvisorBox.TabIndex = 44;
            // 
            // CoAdvisorBox
            // 
            CoAdvisorBox.FormattingEnabled = true;
            CoAdvisorBox.Location = new Point(12, 382);
            CoAdvisorBox.Name = "CoAdvisorBox";
            CoAdvisorBox.Size = new Size(198, 23);
            CoAdvisorBox.TabIndex = 45;
            // 
            // IndustrialAdvisorBox
            // 
            IndustrialAdvisorBox.FormattingEnabled = true;
            IndustrialAdvisorBox.Location = new Point(12, 411);
            IndustrialAdvisorBox.Name = "IndustrialAdvisorBox";
            IndustrialAdvisorBox.Size = new Size(198, 23);
            IndustrialAdvisorBox.TabIndex = 46;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Navy;
            addbtn.Font = new Font("Segoe UI", 9F);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(232, 353);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(82, 23);
            addbtn.TabIndex = 47;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // addbtn2
            // 
            addbtn2.BackColor = Color.Navy;
            addbtn2.Font = new Font("Segoe UI", 9F);
            addbtn2.ForeColor = Color.White;
            addbtn2.Location = new Point(232, 382);
            addbtn2.Name = "addbtn2";
            addbtn2.Size = new Size(82, 23);
            addbtn2.TabIndex = 48;
            addbtn2.Text = "ADD";
            addbtn2.UseVisualStyleBackColor = false;
            addbtn2.Click += addbtn2_Click;
            // 
            // addbtn3
            // 
            addbtn3.BackColor = Color.Navy;
            addbtn3.Font = new Font("Segoe UI", 9F);
            addbtn3.ForeColor = Color.White;
            addbtn3.Location = new Point(232, 411);
            addbtn3.Name = "addbtn3";
            addbtn3.Size = new Size(82, 23);
            addbtn3.TabIndex = 49;
            addbtn3.Text = "ADD";
            addbtn3.UseVisualStyleBackColor = false;
            addbtn3.Click += addbtn3_Click;
            // 
            // FormAssignAdvisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(addbtn3);
            Controls.Add(addbtn2);
            Controls.Add(addbtn);
            Controls.Add(IndustrialAdvisorBox);
            Controls.Add(CoAdvisorBox);
            Controls.Add(MainAdvisorBox);
            Controls.Add(dataGridView1);
            Controls.Add(groupgridview);
            Name = "FormAssignAdvisor";
            Text = "FormAssignAdvisor";
            Load += FormAssignAdvisor_Load;
            ((System.ComponentModel.ISupportInitialize)groupgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView groupgridview;
        private DataGridView dataGridView1;
        private ComboBox MainAdvisorBox;
        private ComboBox CoAdvisorBox;
        private ComboBox IndustrialAdvisorBox;
        private Button addbtn;
        private Button addbtn2;
        private Button addbtn3;
    }
}