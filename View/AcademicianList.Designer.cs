namespace StudentManagementSystemApp
{
    partial class AcademicianList
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
            Search = new TextBox();
            AddAcademician = new Button();
            ListStudent = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ListStudent).BeginInit();
            SuspendLayout();
            // 
            // Search
            // 
            Search.Location = new Point(593, 78);
            Search.Name = "Search";
            Search.Size = new Size(377, 27);
            Search.TabIndex = 5;
            Search.Text = "🔎";
            // 
            // AddAcademician
            // 
            AddAcademician.Location = new Point(12, 36);
            AddAcademician.Name = "AddAcademician";
            AddAcademician.Size = new Size(173, 69);
            AddAcademician.TabIndex = 6;
            AddAcademician.Text = "Akademisyen Kayıt Et";
            AddAcademician.UseVisualStyleBackColor = true;
            // 
            // ListStudent
            // 
            ListStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListStudent.BackgroundColor = SystemColors.ControlLight;
            ListStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListStudent.Location = new Point(12, 128);
            ListStudent.Name = "ListStudent";
            ListStudent.RowHeadersWidth = 51;
            ListStudent.Size = new Size(958, 482);
            ListStudent.TabIndex = 4;
            // 
            // AcademicianList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 647);
            Controls.Add(Search);
            Controls.Add(AddAcademician);
            Controls.Add(ListStudent);
            Name = "AcademicianList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AcademicianList";
            ((System.ComponentModel.ISupportInitialize)ListStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Search;
        private Button AddAcademician;
        private DataGridView ListStudent;
    }
}