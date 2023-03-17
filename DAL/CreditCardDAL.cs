using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CreditCardDAL
    {
        private static CreditCardDAL instance;

        public static CreditCardDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new CreditCardDAL();
                return instance;
            }
        }
        private CreditCardDAL() { }

        public bool CardIsValid(string cardNum, int expMonth, int expYear, string securityCode, int price)
        {
            String sql = String.Format("SELECT * FROM CreditCard WHERE cardNum = '{0}' AND cardExpiredMonth = {1} AND cardExpiredYear = {2} and securityCode = '{3}' and balance >= {4}", cardNum, expMonth, expYear, securityCode, price);
            DataTable data = DatabaseProvider.Instance.ExecuteQueryCmd(sql);
            if(data.Rows.Count == 1)
            {
                int id = 0;
                foreach(DataRow row in data.Rows)
                {
                    id = int.Parse(row[0].ToString());
                }
                String updateBalance = String.Format("UPDATE CreditCard SET balance = balance - {0} WHERE cardId = {1}", price, id);
                DatabaseProvider.Instance.ExecuteNonQueryCmd(updateBalance);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
