using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        MusicStoreEntities storeDB = new MusicStoreEntities();
        public ActionResult Index()
        {
            // Get most popular albums
            var albums = GetTopSellingAlbums(5);
            return View(albums);
        }
        public ActionResult detalles(int id)
        {
            var album = new album {Title="Matisse: " + id };
            return View(album);
        }
        private List<album> GetTopSellingAlbums(int count)
        {
            // Group the order details by album and return
            // the albums with the highest count
            return storeDB.albums
            .OrderByDescending(a => a.OrderDetails.Count())
            .Take(count)
             .ToList();
        }

    }
}
