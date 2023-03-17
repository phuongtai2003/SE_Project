using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TicketDAL
    {
        private static TicketDAL instance;

        public static TicketDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketDAL();
                return instance;
            }
        }
        private TicketDAL() { }

        public void CreateTicket(string destId, string userId ,int amount)
        {
            string sql = string.Format("INSERT INTO Ticket (destId, customerId, amount) VALUES ({0}, {1}, {2})", int.Parse(destId), int.Parse(userId), amount);
            DatabaseProvider.Instance.ExecuteNonQueryCmd(sql);
        }
    }
}
