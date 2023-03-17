using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ticket
    {
        private Destination _dest;
        private User _customer;
        private int _amount;

        public Destination Dest { get { return _dest; } }
        public User Customer { get { return _customer; } }
        public int Amount { get { return _amount;} }

        public Ticket(Destination dest, User customer, int amount)
        {
            _dest = dest;
            _customer = customer;
            _amount = amount;
        }
    }
}
