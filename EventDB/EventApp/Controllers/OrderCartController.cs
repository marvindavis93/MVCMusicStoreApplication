using System;
using System.Web.Mvc;
using EventApp.Models;



namespace EventApp.Controllers
{
    public class OrderCartController : Controller
    {
        public ActionResult Index()
        {
           OrderCartViewModel vm = new OrderCartViewModel()
            {
                CartItems = CartId.CartItems()

            };
            return View(vm);
        }
        //GET:ORDERCART/ADDTOCART
        public ActionResult AddToCart(int id)
        {
            // OrderCart cart = new OrderCart();
          OrderCart cart = OrderCart.GetCartId(this.HttpContext);

            OrderCartSummaryViewModel vm = new OrderCartSummaryViewModel()
            {
                 cart.AddToCart(id)
        };
         
            cart.AddToCart(id);
            return View("_OrderSummary", vm) ;
            
        }
        //POST: ORDERCART/REMOVEFROMCART
        public ActionResult RemoveFromCart()
        {
            throw new NotImplementedException();
         
        }
    }
}      