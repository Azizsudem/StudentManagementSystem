using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Models;

namespace StudentManagementSystemApp
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
            LoadStudents();
        }

        void LoadStudents()
        {
            using (var context = new ApplicationDbContext())
            {
                var students = context.Students.ToList();
                dataGridView1.DataSource = students;
            }
        }

        private void Add(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var student = new Student
                    {
                        StudentId = Convert.ToInt32(txtId.Text),
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Section = txtSection.Text,
                        Period = txtPeriod.Text ?? "",
                        Role = txtRole.Text ?? "",
                        Password = txtPassword.Text ?? ""
                    };

                    context.Students.Add(student);
                    context.SaveChanges();

                    LoadStudents();
                    MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var student = context.Students.FirstOrDefault(s => s.StudentId == id);

                    if (student != null)
                    {
                        context.Students.Remove(student);
                        context.SaveChanges();
                        LoadStudents();
                        MessageBox.Show("Kayıt Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridView1.CurrentRow.Cells[0].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : string.Empty;
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[1].Value.ToString() : string.Empty;
                txtSurname.Text = dataGridView1.CurrentRow.Cells[2].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[2].Value.ToString() : string.Empty;
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[3].Value.ToString() : string.Empty;
                txtPhone.Text = dataGridView1.CurrentRow.Cells[4].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[4].Value.ToString() : string.Empty;
                txtSection.Text = dataGridView1.CurrentRow.Cells[5].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[5].Value.ToString() : string.Empty;
                txtPeriod.Text = dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[6].Value.ToString() : string.Empty;
                txtRole.Text = dataGridView1.CurrentRow.Cells[7].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[7].Value.ToString() : string.Empty;
                txtPassword.Text = dataGridView1.CurrentRow.Cells[8].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[8].Value.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
