using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemApp.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (!txtid.Text.Trim().Equals(""))
            {
                if (!txtpassword.Text.Trim().Equals(""))
                {
                    username = txtpassword.Text;
                    password = txtpassword.Text;
                    MySqlCommand command = new MySqlCommand();
                }
            }
        }
    }
}
