using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StudentManagementSystemApp.Models;

namespace StudentManagementSystemApp.View
{
    public partial class StudentList : Form
    {
        private readonly ApplicationDbContext _context;
        private DataTable _studentTable;

        public StudentList()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadStudents();
        }
        void LoadStudents()
        {
            try
            {
                // Veritabanından öğrencileri al
                var students = _context.Students.ToList();

                _studentTable = new DataTable();
                _studentTable.Columns.Add("id", typeof(int));
                _studentTable.Columns.Add("name", typeof(string));
                _studentTable.Columns.Add("surname", typeof(string));
                _studentTable.Columns.Add("email", typeof(string));
                _studentTable.Columns.Add("phone", typeof(string));
                _studentTable.Columns.Add("section", typeof(string));
                _studentTable.Columns.Add("period", typeof(string));

                foreach (var student in students)
                {
                    _studentTable.Rows.Add(student.StudentId, student.Name, student.Email, student.Phone);
                }

                ListStudent.DataSource = _studentTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            if (_studentTable != null)
            {
                try
                {
                    DataView dv = _studentTable.DefaultView;

                    // Filtreleme
                    if (!string.IsNullOrEmpty(Search.Text))
                    {
                        dv.RowFilter = string.Format("convert(id, 'System.String') LIKE '%{0}%' OR name LIKE '%{0}%'", Search.Text);
                    }
                    else
                    {
                        dv.RowFilter = string.Empty;
                    }

                    ListStudent.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Arama sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration Formac = new StudentRegistration();
            Formac.Show();
        }
    }
}
