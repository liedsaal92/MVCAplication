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
            var gente = _objEntities.genres.Include("Albums").Single(C => C.Name == genre);
            return View(gente);
        }
        public ActionResult Details(int id)
        {
            var genre = _objEntities.albums.Find(id);
            return View(genre);
        }

    }
}
