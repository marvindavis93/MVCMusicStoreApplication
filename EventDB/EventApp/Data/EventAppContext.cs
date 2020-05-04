﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EventApp.Data;

namespace EventApp.Data
{
    public class EventAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EventAppContext() : base("name=EventAppContext")
        {
        }

        public System.Data.Entity.DbSet<EventApplication.Models.Events> Events { get; set; }

        public System.Data.Entity.DbSet<EventApplication.Models.EventType> EventTypes { get; set; }

        public System.Data.Entity.DbSet<EventApp.Models.Cart> Carts { get; set; }

        

    }
}