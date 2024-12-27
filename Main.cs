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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademicianList Formac = new AcademicianList();
            Formac.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AcademicianRegistration Formac = new AcademicianRegistration();
            Formac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList Formac = new StudentList();
            Formac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentRegistration Formac = new StudentRegistration();
            Formac.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes Formac = new Notes();
            Formac.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login Formac = new Login();
            Formac.Show();
        }
    }
}
