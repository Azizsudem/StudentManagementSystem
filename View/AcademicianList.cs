using StudentManagementSystemApp.Models;
using StudentManagementSystemApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemApp
{
    public partial class AcademicianList : Form
    {
        private readonly ApplicationDbContext _context;
        private DataTable _academicianTable;

        public AcademicianList()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            LoadAcademicians();
        }

        public object ListAcademician { get; private set; }

        void LoadAcademicians()
        {
            try
            {
                // Veritabanından akademisyenleri al
                var academicians = _context.Academicians.ToList();

                _academicianTable = new DataTable();
                _academicianTable.Columns.Add("id", typeof(int));
                _academicianTable.Columns.Add("name", typeof(string));
                _academicianTable.Columns.Add("surname", typeof(string));
                _academicianTable.Columns.Add("email", typeof(string));
                _academicianTable.Columns.Add("phone", typeof(string));
                _academicianTable.Columns.Add("department", typeof(string));

                foreach (var academician in academicians)
                {
                    _academicianTable.Rows.Add(academician.AcadId, academician.Name, academician.Email, academician.Phone);
                }

                //ListAcademician.DataSource = _academicianTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
