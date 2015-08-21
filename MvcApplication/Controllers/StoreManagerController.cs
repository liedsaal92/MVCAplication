using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication.Models;

namespace MvcApplication.Controllers
{
    public class StoreManagerController : Controller
    {
        private MusicStoreEntities db = new MusicStoreEntities();

        //
        // GET: /Default1/

        public ActionResult Index()
        {
            var albums = db.albums.Include(a => a.Genre).Include(a => a.Artist);
            return View(albums.ToList());
        }

        //
        // GET: /Default1/Details/5

        public ActionResult Details(int id = 0)
        {
            album album = db.albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        //
        // GET: /Default1/Create

        public ActionResult Create()
        {
            ViewBag.genreId = new SelectList(db.genres, "genreId", "Name");
            ViewBag.artistId = new SelectList(db.Artists, "artistId", "Name");
            return View();
        }

        //
        // POST: /Default1/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(album album)
        {
            if (ModelState.IsValid)
            {
                db.albums.Add(album);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.genreId = new SelectList(db.genres, "genreId", "Name", album.genreId);
            ViewBag.artistId = new SelectList(db.Artists, "artistId", "Name", album.artistId);
            return View(album);
        }

        //
        // GET: /Default1/Edit/5

        public ActionResult Edit(int id = 0)
        {
            album album = db.albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.genreId = new SelectList(db.genres, "genreId", "Name", album.genreId);
            ViewBag.artistId = new SelectList(db.Artists, "artistId", "Name", album.artistId);
            return View(album);
        }

        //
        // POST: /Default1/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(album album)
        {
            if (ModelState.IsValid)
            {
                db.Entry(album).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.genreId = new SelectList(db.genres, "genreId", "Name", album.genreId);
            ViewBag.artistId = new SelectList(db.Artists, "artistId", "Name", album.artistId);
            return View(album);
        }

        //
        // GET: /Default1/Delete/5

        public ActionResult Delete(int id = 0)
        {
            album album = db.albums.Find(id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        //
        // POST: /Default1/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            album album = db.albums.Find(id);
            db.albums.Remove(album);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}