using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Models;

namespace StudentManagementSystemApp.View
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
            LoadNote();
        }

        void LoadNote()
        {
            using (var context = new ApplicationDbContext())
            {
                // Notes tablosundaki tüm notları alıyoruz
                var notes = context.Notes.ToList();
                dataGridView1.DataSource = notes;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Hücre değerlerini alıyoruz
                lessonId.Text = dataGridView1.CurrentRow.Cells[0].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[0].Value.ToString() : string.Empty;
                studentId.Text = dataGridView1.CurrentRow.Cells[1].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[1].Value.ToString() : string.Empty;
                lessonNote.Text = dataGridView1.CurrentRow.Cells[2].Value != DBNull.Value ? dataGridView1.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNote_Click(object sender, EventArgs e)
        {
            try
            {
                // Girilen değerleri alıyoruz
                if (int.TryParse(lessonId.Text, out int lessonIdValue) &&
                    int.TryParse(studentId.Text, out int studentIdValue) &&
                    int.TryParse(lessonNote.Text, out int examNoteValue)) 
                {
                    using (var context = new ApplicationDbContext())
                    {
                        var note = new Note
                        {
                            LessonId = lessonIdValue,
                            StudentId = studentIdValue,
                            ExamNote = examNoteValue, 
                        };

                        context.Notes.Add(note);  
                        context.SaveChanges();    

                        LoadNote();  
                        MessageBox.Show("Kayıt Ekleme Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz veri girişi. Lütfen geçerli sayısal değerler girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
