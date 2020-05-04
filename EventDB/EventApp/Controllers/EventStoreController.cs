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
    public class EventStoreController : Controller
    {
        private EventAppContext db = new EventAppContext();

        // GET: EventStore

        public ActionResult Browse()
        {
            return View(db.Events.ToList());
        }

        public ActionResult Index(int id)
        {
            var events = db.Events.Where(a => a.EventsId == id);
            return View(events.ToList());
        }

        
        }
    }

