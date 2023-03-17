using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CreditCard
    {
        private String _cardNumber;
        private int _expMonth;
        private int _expYear;
        private String _securityCode;

        public String CardNumber { get { return _cardNumber; } }
        public int ExpMonth { get { return _expMonth; } }
        public int ExpYear { get { return _expYear; } }
        public String SecurityCode { get { return _securityCode; } }

        public CreditCard(string cardNum, int expMonth, int expYear, string securityCode)
        {
            _cardNumber= cardNum;
            _expMonth= expMonth;
            _expYear= expYear;
            _securityCode= securityCode;
        }
    }
}
