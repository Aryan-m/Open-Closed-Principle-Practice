using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class ChildAttendee : IAttendee
    {
        public string  name   { get; set; }
        public decimal ticketPrice { get { return TicketPriceConstants.child; } }

        public string printTicket()
        {
            return TicketFunctions.printTicket(this.name, this.ticketPrice);
        }

        // Constructor
        public ChildAttendee(string name)
        {
            this.name = name;
        }
    }
}
