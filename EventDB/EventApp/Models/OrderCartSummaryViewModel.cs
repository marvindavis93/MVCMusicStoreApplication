using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventApp.Models;
using EventApp.Data;

namespace EventApp.Models
{
    public class OrderCartSummaryViewModel
    {
        public string EventTitle;

        public int OrderNumber;

        public int NumberOfTickets;

        public string OrderStatus;

    }
}