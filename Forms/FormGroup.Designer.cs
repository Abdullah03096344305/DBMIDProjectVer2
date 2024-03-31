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
            studentgridview = new DataGridView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            addbtn2 = new Button();
            ((System.ComponentModel.ISupportInitialize)studentgridview).BeginInit();
            SuspendLayout();
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Navy;
            addbtn.Font = new Font("Segoe UI", 11F);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(338, 36);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 1;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // studentgridview
            // 
            studentgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            studentgridview.Location = new Point(12, 156);
            studentgridview.Name = "studentgridview";
            studentgridview.Size = new Size(624, 302);
            studentgridview.TabIndex = 4;
            studentgridview.CellContentClick += studentgridview_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(438, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(454, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 14;
            label1.Text = "Remaining Projects:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 16;
            label2.Text = "Remaining Students";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(7, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(198, 23);
            comboBox2.TabIndex = 15;
            // 
            // addbtn2
            // 
            addbtn2.BackColor = Color.Navy;
            addbtn2.Font = new Font("Segoe UI", 11F);
            addbtn2.ForeColor = Color.White;
            addbtn2.Location = new Point(211, 36);
            addbtn2.Name = "addbtn2";
            addbtn2.Size = new Size(94, 32);
            addbtn2.TabIndex = 17;
            addbtn2.Text = "ADD";
            addbtn2.UseVisualStyleBackColor = false;
            addbtn2.Click += addbtn2_Click;
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(648, 462);
            Controls.Add(addbtn2);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(studentgridview);
            Controls.Add(addbtn);
            Name = "FormGroup";
            Text = "FormGroup";
            Load += FormGroup_Load;
            ((System.ComponentModel.ISupportInitialize)studentgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addbtn;
        private DataGridView studentgridview;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private Button addbtn2;
    }
}