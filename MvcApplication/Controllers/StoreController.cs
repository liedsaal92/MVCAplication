using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class StoreController : Controller
    {
        
        // GET: /Store/
        MusicStoreEntities _objEntities = new MusicStoreEntities();

        public ActionResult Index()
        {
           var genres = _objEntities.genres.ToList();
           return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            var gente = new Genre { Name = genre };
            return View(gente);
        }
        public string Details(int id)
        {
            string mensaje = "store.browse, ID=" + id;            
            return "hello from store.details"+mensaje;
        }

    }
}
