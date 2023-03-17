using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            register = null;
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsernameLogin.Text.Length != 0 && txtPasswordLogin.Text.Length != 0)
            {
                string userName = txtUsernameLogin.Text;
                string password = txtPasswordLogin.Text;
                bool status = UserBLL.Instance.CheckLogin(userName, password);
                if (!status)
                {
                    MessageBox.Show("Invalid credentials");
                }
                else
                {
                    this.Hide();
                    Home home = new Home(this);
                    home.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter all of the information");
            }
        }
    }
}
