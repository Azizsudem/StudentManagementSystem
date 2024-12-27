using Microsoft.EntityFrameworkCore;
using StudentManagementSystemApp.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace StudentManagementSystemApp
{
    public class ApplicationDbContext : DbContext
    {
        // Veritabanı bağlantısını yapılandırıyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=studentmanagementsystem;Uid=root;Pwd=123456;",
                    new MySqlServerVersion(new Version(8, 0, 32))); 
            }
        }
        // Tabloları DbSet olarak tanımlıyoruz
        public DbSet<Student> Students { get; set; }
        public DbSet<Academician> Academicians { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}
