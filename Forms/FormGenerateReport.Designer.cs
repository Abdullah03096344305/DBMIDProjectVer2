namespace ver2.Forms
{
    partial class FormGenerateReport
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
            label7 = new Label();
            GenerateButton = new Button();
            QueryTextBox = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            label7.Location = new Point(231, 9);
            label7.Name = "label7";
            label7.Size = new Size(177, 25);
            label7.TabIndex = 38;
            label7.Text = "Generate Reports";
            // 
            // GenerateButton
            // 
            GenerateButton.BackColor = Color.FromArgb(0, 150, 136);
            GenerateButton.Font = new Font("Segoe UI", 11F);
            GenerateButton.ForeColor = Color.White;
            GenerateButton.Location = new Point(218, 311);
            GenerateButton.Name = "GenerateButton";
            GenerateButton.Size = new Size(195, 32);
            GenerateButton.TabIndex = 40;
            GenerateButton.Text = "Generate Report ";
            GenerateButton.UseVisualStyleBackColor = false;
            GenerateButton.Click += GenerateButton_Click;
            // 
            // QueryTextBox
            // 
            QueryTextBox.BackColor = Color.FromArgb(0, 150, 136);
            QueryTextBox.Font = new Font("Segoe UI", 11F);
            QueryTextBox.ForeColor = Color.White;
            QueryTextBox.Location = new Point(106, 56);
            QueryTextBox.Multiline = true;
            QueryTextBox.Name = "QueryTextBox";
            QueryTextBox.Size = new Size(433, 176);
            QueryTextBox.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 42;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(80, 251);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 43;
            label1.Text = "Pdf File Name:";
            // 
            // FormGenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(QueryTextBox);
            Controls.Add(GenerateButton);
            Controls.Add(label7);
            Name = "FormGenerateReport";
            Text = "FormGenerateReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button GenerateButton;
        private TextBox QueryTextBox;
        private TextBox textBox1;
        private Label label1;
    }
}