using BLL;
using DAL;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtUsernameReg.Text.Length != 0 && txtPasswordReg.Text.Length!=0 && txtPersonalIdReg.Text.Length != 0)
            {
                string userName = txtUsernameReg.Text;
                string password = txtPasswordReg.Text;
                string personalId = txtPersonalIdReg.Text;
                bool created = UserBLL.Instance.CreateAccount(userName, password, personalId);
                MessageBox.Show(created ? "Account created! Login with the same credentials" : "There has been an account with the same credentials!");
            }
            else
            {
                MessageBox.Show("Please enter all of the information");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
