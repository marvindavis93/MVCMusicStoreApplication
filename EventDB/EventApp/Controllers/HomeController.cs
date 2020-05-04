using EventApp.Data;
using EventApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventApp.Controllers
{
    public class HomeController : Controller
    {
        private EventAppContext db = new EventAppContext();

        public ActionResult GetLastMinuteDeals()
        {
            DateTime futureDate = DateTime.Today.AddDays(2);
            var LastMinuteDeal = db.Events

            .Where(a => DateTime.Parse(a.EventStartDate) <= DateTime.Today)
            .Where(a => DateTime.Parse(a.EventStartDate) <= futureDate);
            throw new NotImplementedException();

        }

        public ActionResult EventSearch(string q)
        {

            var events = db.Events;
            return PartialView("_Eventsearch",events);

        }
      private List<Events> GetEvents(string searchString)
        {
            return db.Events
                    .Where(a => a.EventTitle.Contains(searchString))
                    .ToList();
        }
       public ActionResult GetState(string v)
        {
            var states = GetState(v);
                return PartialView("_StateSearch", states);

           


        }

        private object GetStates (string v)
        {
            return db.Events
               .Where(c => c.State.Contains(v))
                .ToList();
        }
       

        


     



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}