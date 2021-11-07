using System;
using System.Collections.Generic;
using Xunit;
using OpenClosedPrinciple;

namespace UnitTests
{
    public class AttendeeSystemTest
    {
        [Fact]
        public void testWithDifferentAttendees()
        {
            // generate attendees list
            List<IAttendee> attendees = new List<IAttendee>
            {
                   new AdultAttendee("Corey Sandheagan")
                 , new AdultAttendee("Jamie Rozenstruik")
                 , new ChildAttendee("Michael Chandler")
                 , new AdultAttendee("Colby Covington")
            };

            List<string> expectedTicketPage = new List<string>
            {
                  TicketFunctions.printTicket("Corey Sandheagan" , TicketPriceConstants.adult)
                , TicketFunctions.printTicket("Jamie Rozenstruik", TicketPriceConstants.adult)
                , TicketFunctions.printTicket("Michael Chandler" , TicketPriceConstants.child)
                , TicketFunctions.printTicket("Colby Covington"  , TicketPriceConstants.adult)
            };
            
            List<string> actualTicketPage = new List<string>
            {
                  attendees[0].printTicket()
                , attendees[1].printTicket()
                , attendees[2].printTicket()
                , attendees[3].printTicket()
            };

            Assert.Equal(expectedTicketPage, actualTicketPage);


        }
    }
}
