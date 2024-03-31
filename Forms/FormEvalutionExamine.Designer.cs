namespace ver2.Forms
{
    partial class FormEvalutionExamine
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
            label1 = new Label();
            evaluationgridview = new DataGridView();
            comboBox1 = new ComboBox();
            ObtainedMarksTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            buttonAddEvaluation = new Button();
            ((System.ComponentModel.ISupportInitialize)evaluationgridview).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 25);
            label1.TabIndex = 10;
            label1.Text = "Select Project and Evaluate";
            // 
            // evaluationgridview
            // 
            evaluationgridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            evaluationgridview.EditMode = DataGridViewEditMode.EditProgrammatically;
            evaluationgridview.Location = new Point(12, 28);
            evaluationgridview.Name = "evaluationgridview";
            evaluationgridview.Size = new Size(624, 267);
            evaluationgridview.TabIndex = 11;
            evaluationgridview.CellContentClick += evaluationgridview_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(270, 331);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ObtainedMarksTextBox
            // 
            ObtainedMarksTextBox.Location = new Point(270, 394);
            ObtainedMarksTextBox.Name = "ObtainedMarksTextBox";
            ObtainedMarksTextBox.Size = new Size(198, 23);
            ObtainedMarksTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13F);
            label2.Location = new Point(113, 331);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 14;
            label2.Text = "Evaluation Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13F);
            label3.Location = new Point(113, 394);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 15;
            label3.Text = "Obtained Marks";
            // 
            // buttonAddEvaluation
            // 
            buttonAddEvaluation.Location = new Point(530, 360);
            buttonAddEvaluation.Name = "buttonAddEvaluation";
            buttonAddEvaluation.Size = new Size(75, 23);
            buttonAddEvaluation.TabIndex = 16;
            buttonAddEvaluation.Text = "Add";
            buttonAddEvaluation.UseVisualStyleBackColor = true;
            buttonAddEvaluation.Click += buttonAddEvaluation_Click;
            // 
            // FormEvalutionExamine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 462);
            Controls.Add(buttonAddEvaluation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ObtainedMarksTextBox);
            Controls.Add(comboBox1);
            Controls.Add(evaluationgridview);
            Controls.Add(label1);
            Name = "FormEvalutionExamine";
            Text = "FormEvalutionExamine";
            Load += FormEvalutionExamine_Load;
            ((System.ComponentModel.ISupportInitialize)evaluationgridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView evaluationgridview;
        private ComboBox comboBox1;
        private TextBox ObtainedMarksTextBox;
        private Label label2;
        private Label label3;
        private Button buttonAddEvaluation;
    }
}