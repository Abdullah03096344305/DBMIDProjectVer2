namespace ver2.Forms
{
    partial class FormProjects
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
            descriptiontxt = new TextBox();
            titletxt = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            addbtn = new Button();
            projectgridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)projectgridview).BeginInit();
            SuspendLayout();
            // 
            // descriptiontxt
            // 
            descriptiontxt.Location = new Point(140, 75);
            descriptiontxt.Name = "descriptiontxt";
            descriptiontxt.Size = new Size(240, 23);
            descriptiontxt.TabIndex = 35;
            // 
            // titletxt
            // 
            titletxt.Location = new Point(140, 21);
            titletxt.Name = "titletxt";
            titletxt.Size = new Size(240, 23);
            titletxt.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(18, 78);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 33;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(18, 21);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 32;
            label2.Text = "Title:";
            // 
            // button3
            // 
            button3.Location = new Point(486, 21);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 38;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(438, 59);
            button2.Name = "button2";
            button2.Size = new Size(94, 32);
            button2.TabIndex = 37;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            addbtn.Location = new Point(386, 21);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 36;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // projectgridview
            // 
            projectgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            projectgridview.Location = new Point(12, 124);
            projectgridview.Name = "projectgridview";
            projectgridview.Size = new Size(624, 326);
            projectgridview.TabIndex = 39;
            // 
            // FormProjects
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(projectgridview);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addbtn);
            Controls.Add(descriptiontxt);
            Controls.Add(titletxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormProjects";
            Text = "FormProjects";
            ((System.ComponentModel.ISupportInitialize)projectgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptiontxt;
        private TextBox titletxt;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button addbtn;
        private DataGridView projectgridview;
    }
}