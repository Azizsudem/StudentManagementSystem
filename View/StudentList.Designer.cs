namespace StudentManagementSystemApp.View
{
    partial class StudentList
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
            ListStudent = new DataGridView();
            Search = new TextBox();
            AddStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)ListStudent).BeginInit();
            SuspendLayout();
            // 
            // ListStudent
            // 
            ListStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListStudent.BackgroundColor = SystemColors.ControlLight;
            ListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListStudent.Location = new Point(12, 153);
            ListStudent.Name = "ListStudent";
            ListStudent.RowHeadersWidth = 51;
            ListStudent.Size = new Size(958, 482);
            ListStudent.TabIndex = 0;
            ListStudent.CellContentClick += ListStudent_CellContentClick;
            // 
            // Search
            // 
            Search.Location = new Point(593, 103);
            Search.Name = "Search";
            Search.Size = new Size(377, 27);
            Search.TabIndex = 1;
            Search.Text = "🔎";
            Search.TextChanged += Search_TextChanged;
            // 
            // AddStudent
            // 
            AddStudent.Location = new Point(12, 61);
            AddStudent.Name = "AddStudent";
            AddStudent.Size = new Size(173, 69);
            AddStudent.TabIndex = 7;
            AddStudent.Text = "Öğrenci Kayıt Et";
            AddStudent.UseVisualStyleBackColor = true;
            AddStudent.Click += AddStudent_Click;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 647);
            Controls.Add(AddStudent);
            Controls.Add(Search);
            Controls.Add(ListStudent);
            Name = "StudentList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)ListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ListStudent;
        private TextBox Search;
        private Button AddStudent;
    }
}