using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public interface IAttendee
    {
        string name { get; set; }
        decimal ticketPrice { get; }
        string printTicket();
    }
}
