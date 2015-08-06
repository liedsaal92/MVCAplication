using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            return View();
        }
        public string Browse(string gente)
        {
            string mensaje = HttpUtility.HtmlEncode("store.browse, gente="+gente);
            return mensaje;
        }
        public string Details(int id)
        {
            string mensaje = "store.browse, ID=" + id;            
            return "hello from store.details"+mensaje;
        }

    }
}
