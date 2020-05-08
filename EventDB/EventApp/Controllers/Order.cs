using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApp.Data;
using EventApp.Models;
using EventApplication.Models;
using EventApp.Models;

namespace EventApp.Controllers
{
    public class Order : Controller
    {
        private EventAppContext db = new EventAppContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);

            OrderCartViewModel vm = new OrderCartViewModel()
            {
                CartItems = cart.CartItems()

            };
            return View(vm);
        }

        //GET: ShoppingCart/AddToCart/7
        public ActionResult AddToCart(int id)
        {

            // ShoppingCart cart =new  ShoppingCart();
            OrderCart cart = OrderCart.GetCart(this.HttpContext);

            cart.AddToCart(id);

            return RedirectToAction("Index");
        }
        //Post: ShoppingCart/RemoveFromCart/7
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            OrderCart cart = OrderCart.GetCart(this.HttpContext);

           Events @event = db.Events.SingleOrDefault(c => c.EventsId == id);

            int newItemCount = cart.RemoveFromCart(id);



            OrderCartRemoveViewModel vm = new OrderCartRemoveViewModel()
            {
                DeleteEventId = id,
                NumberOfTickets = newItemCount,
                 Message =@event.EventTitle + " has been removed from the cart"

             };
            return Json(vm);
    }
    }
}
