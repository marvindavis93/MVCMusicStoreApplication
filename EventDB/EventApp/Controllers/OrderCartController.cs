using System;
using System.Web.Mvc;
using EventApp.Models;



namespace EventApplication.Controllers
{
    public class OrderCartController : Controller
    {
        public ActionResult Index()
        {
           OrderCartViewModel vm = new OrderCartViewModel()
            {
                CartItems = OrderCart.CartItems()

            };
            return View(vm);
        }
        //GET:ORDERCART/ADDTOCART
        public ActionResult AddToCart(int id)
        {
            // OrderCart cart = new OrderCart();
          OrderCart cart = OrderCart.GetCart(this.HttpContext);
            cart.AddToCart(id);

            
        }
        //POST: ORDERCART/REMOVEFROMCART
        public ActionResult RemoveFromCart()
        {

            throw new NotImplementedException();
        }
    }
}      