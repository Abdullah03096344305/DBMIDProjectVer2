namespace ver2.Forms
{
    partial class FormGroup
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
            label1 = new Label();
            regnocombobox = new ComboBox();
            label2 = new Label();
            projectcomboBox = new ComboBox();
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            confirmButton = new Button();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.LightSeaGreen;
            addbtn.Location = new Point(391, 12);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 23);
            addbtn.TabIndex = 38;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 41;
            label1.Text = "Student Registration No:";
            // 
            // regnocombobox
            // 
            regnocombobox.FormattingEnabled = true;
            regnocombobox.Location = new Point(201, 12);
            regnocombobox.Name = "regnocombobox";
            regnocombobox.Size = new Size(159, 23);
            regnocombobox.TabIndex = 40;
            regnocombobox.SelectedIndexChanged += regnocombobox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(21, 167);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 43;
            label2.Text = "Projects:";
            // 
            // projectcomboBox
            // 
            projectcomboBox.FormattingEnabled = true;
            projectcomboBox.Location = new Point(201, 164);
            projectcomboBox.Name = "projectcomboBox";
            projectcomboBox.Size = new Size(159, 23);
            projectcomboBox.TabIndex = 42;
            projectcomboBox.SelectedIndexChanged += projectcomboBox_SelectedIndexChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(516, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 109);
            listBox1.TabIndex = 44;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.Location = new Point(391, 41);
            button1.Name = "button1";
            button1.Size = new Size(94, 23);
            button1.TabIndex = 45;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(516, 164);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(120, 109);
            listBox2.TabIndex = 46;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSeaGreen;
            button2.Location = new Point(391, 163);
            button2.Name = "button2";
            button2.Size = new Size(94, 23);
            button2.TabIndex = 47;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSeaGreen;
            button3.Location = new Point(391, 192);
            button3.Name = "button3";
            button3.Size = new Size(94, 23);
            button3.TabIndex = 48;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(201, 273);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 49;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(21, 276);
            label3.Name = "label3";
            label3.Size = new Size(162, 20);
            label3.TabIndex = 50;
            label3.Text = "Project Assigning Date:";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.LightSeaGreen;
            confirmButton.Location = new Point(239, 350);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(195, 29);
            confirmButton.TabIndex = 51;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(confirmButton);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(projectcomboBox);
            Controls.Add(label1);
            Controls.Add(regnocombobox);
            Controls.Add(addbtn);
            Name = "FormGroup";
            Text = "FormGroup";
            Load += FormGroup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button addbtn;
        private Label label1;
        private ComboBox regnocombobox;
        private Label label2;
        private ComboBox projectcomboBox;
        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button confirmButton;
    }
}