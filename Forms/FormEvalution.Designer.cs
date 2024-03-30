namespace ver2.Forms
{
    partial class FormEvalution
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
            NametextBox = new TextBox();
            TotalMarkstextBox = new TextBox();
            TotalWeightagetextBox = new TextBox();
            Addbtn = new Button();
            studentgridview = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)studentgridview).BeginInit();
            SuspendLayout();
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(216, 46);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(212, 23);
            NametextBox.TabIndex = 0;
            // 
            // TotalMarkstextBox
            // 
            TotalMarkstextBox.Location = new Point(216, 91);
            TotalMarkstextBox.Name = "TotalMarkstextBox";
            TotalMarkstextBox.Size = new Size(212, 23);
            TotalMarkstextBox.TabIndex = 2;
            // 
            // TotalWeightagetextBox
            // 
            TotalWeightagetextBox.Location = new Point(216, 138);
            TotalWeightagetextBox.Name = "TotalWeightagetextBox";
            TotalWeightagetextBox.Size = new Size(212, 23);
            TotalWeightagetextBox.TabIndex = 3;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.CornflowerBlue;
            Addbtn.Font = new Font("Times New Roman", 11F);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(507, 91);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(129, 31);
            Addbtn.TabIndex = 4;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // studentgridview
            // 
            studentgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            studentgridview.Location = new Point(12, 182);
            studentgridview.Name = "studentgridview";
            studentgridview.Size = new Size(624, 268);
            studentgridview.TabIndex = 5;
            studentgridview.CellContentClick += studentgridview_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(77, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(77, 94);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Total Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(77, 141);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 8;
            label4.Text = "Total Weightage";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 25);
            label1.TabIndex = 9;
            label1.Text = "Add Evalution";
            // 
            // FormEvalution
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(648, 462);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(studentgridview);
            Controls.Add(Addbtn);
            Controls.Add(TotalWeightagetextBox);
            Controls.Add(TotalMarkstextBox);
            Controls.Add(NametextBox);
            Name = "FormEvalution";
            Text = "FormEvalution";
            Load += FormEvalution_Load;
            ((System.ComponentModel.ISupportInitialize)studentgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NametextBox;
        private TextBox TotalMarkstextBox;
        private TextBox TotalWeightagetextBox;
        private Button Addbtn;
        private DataGridView studentgridview;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}