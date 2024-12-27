using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Models;

namespace StudentManagementSystemApp
{
    public partial class AcademicianRegistration : Form
    {
        public AcademicianRegistration()
        {
            InitializeComponent();
            LoadAcademicians();  
        }

        
        void LoadAcademicians()
        {
            using (var context = new ApplicationDbContext())
            {
                var academicians = context.Academicians.ToList();
                dataGridView1.DataSource = academicians;  
            }
        }

        
        private void Add(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var academician = new Academician
                    {
                        AcadId = Convert.ToInt32(txtId.Text),
                        Name = txtName.Text,
                        Surname = txtSurname.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhone.Text,
                        Section = txtSection.Text,
                        Status = txtStatus.Text ?? "",
                        Role = txtRole.Text ?? "", 
                        Password = txtPassword.Text ?? ""
                    };

                    context.Academicians.Add(academician);  
                    context.SaveChanges();  

                    LoadAcademicians();  
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
                    var academician = context.Academicians.FirstOrDefault(a => a.AcadId == id); 

                    if (academician != null)
                    {
                        context.Academicians.Remove(academician);  
                        context.SaveChanges();  
                        LoadAcademicians();  
                        MessageBox.Show("Kayıt Silme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Akademisyen Bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtStatus.Text = dataGridView1.CurrentRow.Cells[6].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[6].Value.ToString() : string.Empty;
                txtRole.Text = dataGridView1.CurrentRow.Cells[7].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[7].Value.ToString() : string.Empty;
                txtPassword.Text = dataGridView1.CurrentRow.Cells[8].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[8].Value.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AcademicianRegistration_Load(object sender, EventArgs e)
        {
            LoadAcademicians();
        }
    }
}
