using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public static class TicketFunctions
    {
        public static string printTicket(string name, decimal ticketPrice)
        {
            string formattedPrice = string.Format("{0:C}", ticketPrice);

            return $"{ name } : { formattedPrice}";
        }
    }
}
