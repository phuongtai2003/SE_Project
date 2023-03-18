using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreditCardPayment : Form
    {
        Home opener;
        int totalPrice;
        int index;
        List<Panel> panels = new List<Panel>();
        public CreditCardPayment(Home opener, int totalPrice)
        {
            InitializeComponent();
            this.opener = opener;
            this.totalPrice = totalPrice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreditCardPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            opener.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtCardNumber.Text.Length> 0 && txtSecurityCode.Text.Length > 0 && cboMonth.Text.Length > 0 && cboYear.Text.Length > 0) {
                String cardNum = txtCardNumber.Text;
                String securityCode = txtSecurityCode.Text;
                int expMonth = int.Parse(cboMonth.SelectedItem.ToString());
                int expYear = int.Parse(cboYear.SelectedItem.ToString()) ;
                bool isValid = CreditCardBLL.Instance.CheckCard(cardNum, expMonth, expYear, securityCode, totalPrice);
                if (isValid)
                {
                    TicketBLL.Instance.CreateTicket(DestinationBLL.Instance.GetCurrentDestId(), UserBLL.Instance.GetCurrentUserId(), totalPrice);
                    index = 1;
                    ChangeVisibility(index);
                }
                else
                {
                    index = 2;
                    ChangeVisibility(index);
                }
            }
            else
            {
                MessageBox.Show("Please enter all of the information");
            }
        }

        private void LoadComboBox()
        {
            cboMonth.Items.Clear();
            cboYear.Items.Clear();
            for(int m = 1; m<=12; m++)
            {
                cboMonth.Items.Add(String.Format("{0:00}",m));
            }
            for(int y = 2023; y <= 2033; y++)
            {
                cboYear.Items.Add(String.Format("{0:00}", y));
            }
        }

        private void CreditCardPayment_Load(object sender, EventArgs e)
        {
            panels.Add(pnlCardInfo);
            panels.Add(pnlStartAgain);
            panels.Add(pnlPaymentFailed);
            ChangeVisibility(index);
            LoadComboBox();
            
        }

        private void ChangeVisibility(int currentPage)
        {
            panels[currentPage].Visible= true;
            for(int i = 0; i < panels.Count; i++)
            {
                if(i != currentPage)
                {
                    panels[i].Visible= false;
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuyAgain_Click(object sender, EventArgs e)
        {
            this.Close();
            opener.Reset();
        }

        private void btnTryAgainNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTryAgainYes_Click(object sender, EventArgs e)
        {
            index = 0;
            ChangeVisibility(index);
        }
    }
}
