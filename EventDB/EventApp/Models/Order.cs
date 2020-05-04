using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EventApp.Models;

namespace EventApp.Models
{
    public class Order
    {
        [Key]
        public int CartId { get; set; }
        public string OrderId { get; set; }
        public string EventId { get; set; }
        public string OrderNumber { get; set; }
       
        public string EventTitle { get; set;}

        public int NumberofTickets { get; set; }

        public DateTime DateCreated { get; set; }

    }
}