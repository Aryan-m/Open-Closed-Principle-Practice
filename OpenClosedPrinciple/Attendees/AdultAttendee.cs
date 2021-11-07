using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class AdultAttendee : IAttendee
    {
        public string   name   { get; set; }
        public decimal  ticketPrice { get { return TicketPriceConstants.adult; } }

        public string printTicket()
        {
            return TicketFunctions.printTicket(this.name, this.ticketPrice);
        }

        // Constructor
        public AdultAttendee(string name)
        {
            this.name        = name;
        }
    }
}
