using EventApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApp.Models
{
    public class OrderCart
    {
        private EventAppContext db = new EventAppContext();
        public string OrderCartId;
        public Order GetOrder()
        {
            Order order = db.Orders.SingleOrDefault(c => c.OrderId == this.OrderCartId);
            return order;
        }
        public event GetEvent()
            {
            Order order = db.Orders.SingleOrDefault(c => c.OrderId == this.OrderCartId)
        

        Event eventSelected = Order.EventSelected;
        return eventSelected;

    }
}