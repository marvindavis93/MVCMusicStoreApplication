using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventApp.Data;
using EventApp.Models;
using EventApplication.Models;

namespace EventApp.Controllers
{
    public class Order : Controller
    {
        private EventAppContext db = new EventAppContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            ShoppingCartViewModel vm = new ShoppingCartViewModel()
            {
                CartItems = cart.GetCartItems(),
                
            };
            return View(vm);
        }

        //GET: ShoppingCart/AddToCart/7
        public ActionResult AddToCart(int id )
        {

           // ShoppingCart cart =new  ShoppingCart();
           ShoppingCart cart =ShoppingCart.GetCart(this.HttpContext);

            cart.AddToCart(id);

            return RedirectToAction("Index");
        }
        //Post: ShoppingCart/RemoveFromCart/7
        [HttpPost]
        public ActionResult RemoveFromCart(int eventId)
        {
            ShoppingCart cart = ShoppingCart.GetCart(this.HttpContext);

            Events event = db.Carts.SingleOrDefault(c => c.RecordId == id).EventSelected;

            int newItemCount = cart.RemoveFromCart(id);

            cart.RemoveFromCart(id);

            ShoppingCartRemoveViewModel vm = new ShoppingCartRemoveViewModel()
            {
              DeleteId = id,
            
            ItemCount = newItemCount,
            Message = event.Title + " has been removed from the cart"

            }
            return Order(vm);
       
        }
    }
