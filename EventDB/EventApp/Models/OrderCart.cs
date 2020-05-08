using EventApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventApp.Models
{
    public class OrderCart
    {
        public string CartId;

        private EventAppContext db = new EventAppContext();

        public static OrderCart GetCart(HttpContextBase context)
        {
            OrderCart cart = new OrderCart();
            cart.CartId = cart.GetCartId(context);
            return cart;
        }

        internal  List<Cart> CartItems()
        {
            return db.Carts.Where(a => a.CartId == this.CartId).ToList();
        }

        private string GetCartId(HttpContextBase context)
        {
            const string CartSessionId = "CartId";


            string cartId;


            if (context.Session[CartSessionId] == null)
            {
                //Create A NEW CART id
                cartId = Guid.NewGuid().ToString();

                //save to the session date

                context.Session[CartSessionId] = cartId;
            }
            else
            {

                //RETURN THE EXISTING CART ID
                cartId = context.Session[CartSessionId].ToString();
            }


            return cartId;

        }

       


        public void AddToCart(int eventId)
        {



            //TODO; VERIFY THAT THE Event iD exists in the database
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.CartId );

            if (cartItem == null)
            {
                //Item is not in cart;add new item
                cartItem = new Cart()
                {
                    CartId = this.CartId,
                    EventId = eventId,
                    Count = 1,
                    DateCreated = DateTime.Today

                };
                db.Carts.Add(cartItem);
            }
            else
            {


                //Item is already in cart; increase item count (quantity)
                cartItem.Count++;
            }

            db.SaveChanges();


        }

        public int RemoveFromCart(int EventId)

        {
            Cart cartItem = db.Carts.SingleOrDefault(c => c.CartId == this.CartId && c.EventId == EventId);
            if (cartItem == null)
            {
                throw new NullReferenceException();

            }
            int newCount;

            if (cartItem.Count > 1)
            {
                cartItem.Count--;
                newCount = cartItem.Count;


                // Item is in the count / the count is > 1; decrement count
            }
            else
            {
                db.Carts.Remove(cartItem);
                newCount = 0;
                //The count <=0; remove from cart
            }
            db.SaveChanges();
            return newCount;
        }
    }
}
    