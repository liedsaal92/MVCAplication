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
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres=new List<Genre>
            {
            new Genre{name="Disco 1"},
            new Genre{name="Disco 2"},
            new Genre{name="Disco 3"},
            new Genre{name="Disco 4"}
           };
           return View(genres);
        }
        public ActionResult Browse(string genre)
        {
            var gente = new Genre { name = genre };
            return View(gente);
        }
        public string Details(int id)
        {
            string mensaje = "store.browse, ID=" + id;            
            return "hello from store.details"+mensaje;
        }

    }
}
