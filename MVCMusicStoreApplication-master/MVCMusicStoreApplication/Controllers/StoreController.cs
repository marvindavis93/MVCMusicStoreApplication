using MVCMusicStoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStoreApplication.Controllers
{
    public class StoreController : Controller
    {
        private MVCMusicStoreDB db = new MVCMusicStoreDB();
      
        
        
        
        // GET: Store
        public ActionResult Browse()
        {
            return View(db.Genres.ToList());
        }

        public ActionResult Index(int id )
        {
            var genres = db.Albums.Where(a => a.GenreId == id);
            return View(genres.ToList());
        }

        public ActionResult Details(int id)
        {
            Album album = db.Albums.Find(id);
            return View(album);
        }
    }

}