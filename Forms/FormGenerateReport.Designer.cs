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
            addbtn = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(231, 9);
            label7.Name = "label7";
            label7.Size = new Size(182, 30);
            label7.TabIndex = 38;
            label7.Text = "Generate Reports";
            label7.Click += label7_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.FromArgb(0, 150, 136);
            addbtn.Font = new Font("Segoe UI", 11F);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(218, 89);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(195, 32);
            addbtn.TabIndex = 40;
            addbtn.Text = "Report --> 1";
            addbtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 150, 136);
            button2.Font = new Font("Segoe UI", 11F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(218, 153);
            button2.Name = "button2";
            button2.Size = new Size(195, 32);
            button2.TabIndex = 42;
            button2.Text = "Report --> 2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 150, 136);
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(218, 212);
            button1.Name = "button1";
            button1.Size = new Size(195, 32);
            button1.TabIndex = 43;
            button1.Text = "Report --> 3";
            button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 150, 136);
            button3.Font = new Font("Segoe UI", 11F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(218, 274);
            button3.Name = "button3";
            button3.Size = new Size(195, 32);
            button3.TabIndex = 44;
            button3.Text = "Report --> 4";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(0, 150, 136);
            button4.Font = new Font("Segoe UI", 11F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(218, 336);
            button4.Name = "button4";
            button4.Size = new Size(195, 32);
            button4.TabIndex = 45;
            button4.Text = "Report --> 5";
            button4.UseVisualStyleBackColor = false;
            // 
            // FormGenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(addbtn);
            Controls.Add(label7);
            Name = "FormGenerateReport";
            Text = "FormGenerateReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button addbtn;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}