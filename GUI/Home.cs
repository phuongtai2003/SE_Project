using BLL;
using DTO;
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
    public partial class Home : Form
    {
        List<Panel> panels = new List<Panel>();
        Form opener;
        int index = 0;
        int ticketAmount = 0;
        public Home(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        public void Reset()
        {
            index = 0;
            ChangeVisibility(index);
            LoadOnStart();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadDestination()
        {
            cboWard.Enabled = false;
            cboRoad.Enabled = false;
            cboNumber.Enabled = false;
            List<String> districts = DestinationBLL.Instance.GetDistrict();
            cboDistrict.Items.Clear();
            foreach (String d in districts)
            {
                cboDistrict.Items.Add(d);
            }
        }

        private void LoadTicketsAmount()
        {
            cboTicketAmount.Items.Clear();
            for(int i = 1; i<=100; i++)
            {
                cboTicketAmount.Items.Add(i);
            }
            Destination currentDest = DestinationBLL.Instance.CurrentDestination;
            lblDestinationAmount.Text = String.Format("{0} - {1} - Ward {2} - District {3}", currentDest.DestNum, currentDest.DestRoad, currentDest.DestWard, currentDest.DestDistrict);

        }
        private void LoadOnStart()
        {
            panels.Clear();
            panels.Add(pnlDestination);
            panels.Add(pnlAmount);
            panels.Add(pnlPayment);
            ChangeVisibility(index);
            btnAmount.Enabled = false;
            btnDestination.Enabled = false;
            btnPayment.Enabled = false;
            LoadDestination();

        }
        private void Home_Load(object sender, EventArgs e)
        {
            LoadOnStart();
        }

        private void ChangeVisibility(int currentPage)
        {
            panels[currentPage].Visible = true;
            for(int i = 0; i < panels.Count; i++)
            {
                if(i != currentPage)
                {
                    panels[i].Visible = false;
                }
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            opener.Show();
        }

        private void cboDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboWard.Enabled = true;
            cboWard.Items.Clear();
            cboWard.Text = "";
            List<String> wards = DestinationBLL.Instance.GetWards(cboDistrict.SelectedItem.ToString());
            foreach(String ward in wards)
            {
                cboWard.Items.Add(ward);
            }
        }

        private void cboWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboRoad.Enabled = true;
            cboRoad.Items.Clear();
            cboRoad.Text = "";
            List<String> roads = DestinationBLL.Instance.GetRoads(cboDistrict.SelectedItem.ToString(), cboWard.SelectedItem.ToString());
            foreach (String r in roads)
            {
                cboRoad.Items.Add(r);
            }
        }

        private void cboRoad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNumber.Enabled = true;
            cboNumber.Items.Clear();
            cboNumber.Text = "";
            List<String> numbers = DestinationBLL.Instance.GetNumbers(cboDistrict.SelectedItem.ToString(), cboWard.SelectedItem.ToString(), cboRoad.SelectedItem.ToString());
            foreach(String n in numbers)
            {
                cboNumber.Items.Add(n);
            }
        }

        private void btnDestNext_Click(object sender, EventArgs e)
        {
            if(cboDistrict.Text.Length>0 && cboWard.Text.Length>0 && cboRoad.Text.Length >0 && cboNumber.Text.Length > 0)
            {
                String district = cboDistrict.Text.ToString();
                String ward = cboWard.Text.ToString();
                String road = cboRoad.Text.ToString();
                String number = cboNumber.Text.ToString();
                DestinationBLL.Instance.SetDestination(district, ward,road, number);
                index = 1;
                ChangeVisibility(index);
                LoadTicketsAmount();
            }
            else
            {
                MessageBox.Show("Please choose your destination");
            }
        }

        private void btnAmountNext_Click(object sender, EventArgs e)
        {
            if(cboTicketAmount.Text.Length > 0)
            {
                ticketAmount = int.Parse(cboTicketAmount.SelectedItem.ToString());
                index = 2;
                ChangeVisibility(index);
                lblTotalPrice.Text = String.Format("${0}", ticketAmount);
                Destination currentDest = DestinationBLL.Instance.CurrentDestination;
                lblPaymentDestination.Text = String.Format("{0} - {1} - Ward {2} - District {3}", currentDest.DestNum, currentDest.DestRoad, currentDest.DestWard, currentDest.DestDistrict);
            }
            else
            {
                MessageBox.Show("Please choose the ticket amount");
            }
        }
        private void GoToPreviousPage()
        {
            index--;
            ChangeVisibility(index);
        }
        private void btnAmountReturn_Click(object sender, EventArgs e)
        {
            GoToPreviousPage();
        }

        private void btnPaymentBack_Click(object sender, EventArgs e)
        {
            GoToPreviousPage();
        }

        private void creditCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreditCardPayment creditCard = new CreditCardPayment(this, ticketAmount);
            creditCard.ShowDialog();
            creditCard = null;
            this.Show();
        }

        private void qrCode_Click(object sender, EventArgs e)
        {
            this.Hide();
            OnlinePayment onlinePayment = new OnlinePayment(this, ticketAmount);
            onlinePayment.ShowDialog();
            onlinePayment = null;
            this.Show();
        }
    }
}
