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
            gendercombo = new ComboBox();
            label7 = new Label();
            addbtn = new Button();
            groupgridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)groupgridview).BeginInit();
            SuspendLayout();
            // 
            // gendercombo
            // 
            gendercombo.FormattingEnabled = true;
            gendercombo.Items.AddRange(new object[] { "Male", "Female" });
            gendercombo.Location = new Point(179, 12);
            gendercombo.Name = "gendercombo";
            gendercombo.Size = new Size(269, 23);
            gendercombo.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(45, 15);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 37;
            label7.Text = "Group:";
            // 
            // addbtn
            // 
            addbtn.Location = new Point(542, 12);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(94, 32);
            addbtn.TabIndex = 38;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = true;
            // 
            // groupgridview
            // 
            groupgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupgridview.Location = new Point(12, 74);
            groupgridview.Name = "groupgridview";
            groupgridview.Size = new Size(624, 384);
            groupgridview.TabIndex = 39;
            // 
            // FormGroup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(groupgridview);
            Controls.Add(addbtn);
            Controls.Add(label7);
            Controls.Add(gendercombo);
            Name = "FormGroup";
            Text = "FormGroup";
            ((System.ComponentModel.ISupportInitialize)groupgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox gendercombo;
        private Label label7;
        private Button addbtn;
        private DataGridView groupgridview;
    }
}