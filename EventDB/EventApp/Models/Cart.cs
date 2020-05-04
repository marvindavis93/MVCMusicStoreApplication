using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApp.Models
{
    public class Cart
    {


        [Key]
         public int RecordId { get; set; }

        public string CartId { get; set; }

        public int OrderId { get; set; }

        public DateTime DateCreated { get; set; }
        public int EventId { get; internal set; }
        public int Count { get; internal set; }
    }
}