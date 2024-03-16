namespace ver2.Forms
{
    partial class FormGroup2
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
            label2 = new Label();
            gendercombo = new ComboBox();
            addbtn = new Button();
            backbtn = new Button();
            groupgridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)groupgridview).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 33;
            label2.Text = "Add Student:";
            // 
            // gendercombo
            // 
            gendercombo.FormattingEnabled = true;
            gendercombo.Items.AddRange(new object[] { "Male", "Female" });
            gendercombo.Location = new Point(204, 9);
            gendercombo.Name = "gendercombo";
            gendercombo.Size = new Size(269, 23);
            gendercombo.TabIndex = 37;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(513, 4);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 39;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            backbtn.Location = new Point(513, 51);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(94, 32);
            backbtn.TabIndex = 40;
            backbtn.Text = "BACK";
            backbtn.UseVisualStyleBackColor = true;
            // 
            // groupgridview
            // 
            groupgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupgridview.Location = new Point(12, 142);
            groupgridview.Name = "groupgridview";
            groupgridview.Size = new Size(624, 281);
            groupgridview.TabIndex = 41;
            // 
            // FormGroup2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(groupgridview);
            Controls.Add(backbtn);
            Controls.Add(addbtn);
            Controls.Add(gendercombo);
            Controls.Add(label2);
            Name = "FormGroup2";
            Text = "FormGroup2";
            ((System.ComponentModel.ISupportInitialize)groupgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox gendercombo;
        private Button addbtn;
        private Button backbtn;
        private DataGridView groupgridview;
    }
}