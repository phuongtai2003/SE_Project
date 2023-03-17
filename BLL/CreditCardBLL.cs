using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CreditCardBLL
    {
        private static CreditCardBLL instance;

        public static CreditCardBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CreditCardBLL();
                return instance;
            }
        }
        private CreditCardBLL() { }

        public bool CheckCard(string cardNum, int expMonth, int expYear, string securityCode, int price)
        {
            bool validPayment = CreditCardDAL.Instance.CardIsValid(cardNum, expMonth, expYear, securityCode, price);
            return validPayment;
        }
    }
}
