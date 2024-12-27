namespace StudentManagementSystemApp.View
{
    partial class Notes
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
            dataGridView1 = new DataGridView();
            lessonId = new TextBox();
            studentId = new TextBox();
            lessonNote = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddNote = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(518, 623);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lessonId
            // 
            lessonId.Location = new Point(707, 82);
            lessonId.Name = "lessonId";
            lessonId.Size = new Size(246, 27);
            lessonId.TabIndex = 1;
            // 
            // studentId
            // 
            studentId.Location = new Point(707, 147);
            studentId.Name = "studentId";
            studentId.Size = new Size(246, 27);
            studentId.TabIndex = 2;
            // 
            // lessonNote
            // 
            lessonNote.Location = new Point(707, 213);
            lessonNote.Name = "lessonNote";
            lessonNote.Size = new Size(246, 27);
            lessonNote.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 89);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 4;
            label1.Text = "Ders Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(610, 154);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 5;
            label2.Text = "Öğrenci Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(610, 220);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "Ders Notu";
            // 
            // AddNote
            // 
            AddNote.Location = new Point(823, 285);
            AddNote.Name = "AddNote";
            AddNote.Size = new Size(130, 60);
            AddNote.TabIndex = 7;
            AddNote.Text = "Ekle";
            AddNote.UseVisualStyleBackColor = true;
            AddNote.Click += AddNote_Click;
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 647);
            Controls.Add(AddNote);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lessonNote);
            Controls.Add(studentId);
            Controls.Add(lessonId);
            Controls.Add(dataGridView1);
            Name = "Note";
            Text = "Note";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox lessonId;
        private TextBox studentId;
        private TextBox lessonNote;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddNote;
    }
}