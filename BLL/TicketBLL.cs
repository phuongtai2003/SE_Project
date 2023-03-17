using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TicketBLL
    {
        private static TicketBLL instance;

        public static TicketBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TicketBLL();
                return instance;
            }
        }
        private TicketBLL() { }

        public void CreateTicket(string destId, string userId,int amount) {
            TicketDAL.Instance.CreateTicket(destId, userId ,amount);
        }
    }
}
