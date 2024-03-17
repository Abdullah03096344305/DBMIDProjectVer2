namespace ver2.Forms
{
    partial class FormStudent
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
            addbtn = new Button();
            button2 = new Button();
            button3 = new Button();
            studentgridview = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            registrationnotxt = new TextBox();
            firstnametxt = new TextBox();
            lastnametxt = new TextBox();
            contacttxt = new TextBox();
            emailtxt = new TextBox();
            dateofbirthbox = new DateTimePicker();
            gendercombo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)studentgridview).BeginInit();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.Location = new Point(342, 418);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 0;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 418);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 1;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(542, 418);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 2;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // studentgridview
            // 
            studentgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            studentgridview.Location = new Point(12, 266);
            studentgridview.Name = "studentgridview";
            studentgridview.Size = new Size(624, 150);
            studentgridview.TabIndex = 3;
            studentgridview.CellContentClick += studentgridview_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 4;
            label1.Text = "Registration No:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(0, 114);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(0, 171);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 7;
            label4.Text = "Date of Birth:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(368, 9);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 8;
            label5.Text = "Contact:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(368, 57);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 9;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(368, 114);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 10;
            label7.Text = "Gender:";
            // 
            // registrationnotxt
            // 
            registrationnotxt.Location = new Point(122, 11);
            registrationnotxt.Name = "registrationnotxt";
            registrationnotxt.Size = new Size(240, 23);
            registrationnotxt.TabIndex = 11;
            // 
            // firstnametxt
            // 
            firstnametxt.Location = new Point(122, 57);
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(240, 23);
            firstnametxt.TabIndex = 12;
            // 
            // lastnametxt
            // 
            lastnametxt.Location = new Point(122, 111);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(240, 23);
            lastnametxt.TabIndex = 13;
            // 
            // contacttxt
            // 
            contacttxt.Location = new Point(437, 9);
            contacttxt.Name = "contacttxt";
            contacttxt.Size = new Size(199, 23);
            contacttxt.TabIndex = 14;
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(437, 54);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(199, 23);
            emailtxt.TabIndex = 15;
            // 
            // dateofbirthbox
            // 
            dateofbirthbox.Location = new Point(122, 171);
            dateofbirthbox.Name = "dateofbirthbox";
            dateofbirthbox.Size = new Size(200, 23);
            dateofbirthbox.TabIndex = 16;
            dateofbirthbox.ValueChanged += dateofbirthbox_ValueChanged;
            // 
            // gendercombo
            // 
            gendercombo.FormattingEnabled = true;
            gendercombo.Items.AddRange(new object[] { "Male", "Female" });
            gendercombo.Location = new Point(444, 118);
            gendercombo.Name = "gendercombo";
            gendercombo.Size = new Size(121, 23);
            gendercombo.TabIndex = 17;
            gendercombo.SelectedIndexChanged += gendercombo_SelectedIndexChanged;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(gendercombo);
            Controls.Add(dateofbirthbox);
            Controls.Add(emailtxt);
            Controls.Add(contacttxt);
            Controls.Add(lastnametxt);
            Controls.Add(firstnametxt);
            Controls.Add(registrationnotxt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(studentgridview);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addbtn);
            Name = "FormStudent";
            Text = "FormStudent";
            Load += FormStudent_Load;
            ((System.ComponentModel.ISupportInitialize)studentgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbtn;
        private Button button2;
        private Button button3;
        private DataGridView studentgridview;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox registrationnotxt;
        private TextBox firstnametxt;
        private TextBox lastnametxt;
        private TextBox contacttxt;
        private TextBox emailtxt;
        private DateTimePicker dateofbirthbox;
        private ComboBox gendercombo;
    }
}