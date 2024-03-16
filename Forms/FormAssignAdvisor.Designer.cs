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
            ((System.ComponentModel.ISupportInitialize)groupgridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupgridview
            // 
            groupgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            groupgridview.Location = new Point(12, 12);
            groupgridview.Name = "groupgridview";
            groupgridview.Size = new Size(624, 164);
            groupgridview.TabIndex = 42;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 272);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(624, 178);
            dataGridView1.TabIndex = 43;
            // 
            // FormAssignAdvisor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(dataGridView1);
            Controls.Add(groupgridview);
            Name = "FormAssignAdvisor";
            Text = "FormAssignAdvisor";
            ((System.ComponentModel.ISupportInitialize)groupgridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView groupgridview;
        private DataGridView dataGridView1;
    }
}