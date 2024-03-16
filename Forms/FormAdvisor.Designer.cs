namespace ver2.Forms
{
    partial class FormAdvisor
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
            gendercombo = new ComboBox();
            dateofbirthbox = new DateTimePicker();
            emailtxt = new TextBox();
            contacttxt = new TextBox();
            lastnametxt = new TextBox();
            firstnametxt = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            advisorgridview = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            addbtn = new Button();
            salarytxt = new TextBox();
            label1 = new Label();
            designaationcombobox = new ComboBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)advisorgridview).BeginInit();
            SuspendLayout();
            // 
            // gendercombo
            // 
            gendercombo.FormattingEnabled = true;
            gendercombo.Items.AddRange(new object[] { "Male", "Female" });
            gendercombo.Location = new Point(458, 18);
            gendercombo.Name = "gendercombo";
            gendercombo.Size = new Size(121, 23);
            gendercombo.TabIndex = 35;
            // 
            // dateofbirthbox
            // 
            dateofbirthbox.Location = new Point(128, 173);
            dateofbirthbox.Name = "dateofbirthbox";
            dateofbirthbox.Size = new Size(200, 23);
            dateofbirthbox.TabIndex = 34;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(458, 56);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(168, 23);
            emailtxt.TabIndex = 33;
            // 
            // contacttxt
            // 
            contacttxt.Location = new Point(129, 120);
            contacttxt.Name = "contacttxt";
            contacttxt.Size = new Size(199, 23);
            contacttxt.TabIndex = 32;
            // 
            // lastnametxt
            // 
            lastnametxt.Location = new Point(128, 65);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(240, 23);
            lastnametxt.TabIndex = 31;
            // 
            // firstnametxt
            // 
            firstnametxt.Location = new Point(128, 11);
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(240, 23);
            firstnametxt.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(382, 14);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 28;
            label7.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(374, 59);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 27;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(9, 120);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 26;
            label5.Text = "Contact:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(6, 173);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 25;
            label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 24;
            label3.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(6, 11);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 23;
            label2.Text = "First Name:";
            // 
            // advisorgridview
            // 
            advisorgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advisorgridview.Location = new Point(18, 268);
            advisorgridview.Name = "advisorgridview";
            advisorgridview.Size = new Size(624, 150);
            advisorgridview.TabIndex = 21;
            advisorgridview.CellContentClick += advisorgridview_CellContentClick_1;
            // 
            // button3
            // 
            button3.Location = new Point(548, 420);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 20;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(448, 420);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 19;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(348, 420);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 18;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // salarytxt
            // 
            salarytxt.Location = new Point(458, 117);
            salarytxt.Name = "salarytxt";
            salarytxt.Size = new Size(163, 23);
            salarytxt.TabIndex = 37;
            salarytxt.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(382, 116);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 36;
            label1.Text = "Salary:";
            label1.Click += label1_Click;
            // 
            // designaationcombobox
            // 
            designaationcombobox.FormattingEnabled = true;
            designaationcombobox.Items.AddRange(new object[] { "Professor", "Associate Professor", "Assistant Professor", "Lecturer", "Industry Professional" });
            designaationcombobox.Location = new Point(490, 176);
            designaationcombobox.Name = "designaationcombobox";
            designaationcombobox.Size = new Size(121, 23);
            designaationcombobox.TabIndex = 39;
            designaationcombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(382, 173);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 38;
            label8.Text = "Designation:";
            // 
            // FormAdvisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(designaationcombobox);
            Controls.Add(label8);
            Controls.Add(salarytxt);
            Controls.Add(label1);
            Controls.Add(gendercombo);
            Controls.Add(dateofbirthbox);
            Controls.Add(emailtxt);
            Controls.Add(contacttxt);
            Controls.Add(lastnametxt);
            Controls.Add(firstnametxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(advisorgridview);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addbtn);
            Name = "FormAdvisor";
            Text = "FormAdvisor";
            Load += FormAdvisor_Load;
            ((System.ComponentModel.ISupportInitialize)advisorgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox gendercombo;
        private DateTimePicker dateofbirthbox;
        private TextBox emailtxt;
        private TextBox contacttxt;
        private TextBox lastnametxt;
        private TextBox firstnametxt;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView advisorgridview;
        private Button button3;
        private Button button2;
        private Button addbtn;
        private TextBox salarytxt;
        private Label label1;
        private ComboBox designaationcombobox;
        private Label label8;
    }
}