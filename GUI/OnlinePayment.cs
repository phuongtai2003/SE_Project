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
    public partial class OnlinePayment : Form
    {
        Home opener;
        int index = 0;
        int totalPrice;
        List<Panel> panels = new List<Panel>();
        public OnlinePayment(Home opener, int totalPrice)
        {
            InitializeComponent();
            this.opener = opener;
            this.totalPrice= totalPrice;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            index = 1;
            ChangeVisibility(index);
        }
        private void ChangeVisibility(int currentPage)
        {
            panels[currentPage].Visible = true;
            for (int i = 0; i < panels.Count; i++)
            {
                if (i != currentPage)
                {
                    panels[i].Visible = false;
                }
            }
        }

        private void GenerateQRCode()
        {
            QRCoder.QRCodeGenerator generator= new QRCoder.QRCodeGenerator();
            User user = UserBLL.Instance.CurrentUser;
            Destination dest = DestinationBLL.Instance.CurrentDestination;
            string paymentInfo = string.Format("User: {0} - Dest: {1} - {2} - {3} - {4} - Price: ${5}", user.UserName, dest.DestNum, dest.DestRoad, dest.DestWard, dest.DestDistrict, totalPrice);
            QRCoder.QRCodeData myData = generator.CreateQrCode(paymentInfo, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(myData);
            qrCodeScan.Image = code.GetGraphic(50); 
        }
        private void OnlinePayment_Load(object sender, EventArgs e)
        {
            panels.Add(pnlQRCode);
            panels.Add(pnlStartAgain);
            ChangeVisibility(0);
            GenerateQRCode();
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
    }
}
