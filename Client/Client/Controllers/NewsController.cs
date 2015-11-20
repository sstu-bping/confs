using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Client.Models;
using Client.DAL;

namespace Client.Controllers
{
    public class NewsController : Controller
    {
        private ConfsContext db = new ConfsContext();

        // GET: /News/
        public ActionResult Index()
        {
            return View(db.News.ToList());
        }

        // GET: /News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsmodel = db.News.Find(id);
            if (newsmodel == null)
            {
                return HttpNotFound();
            }
            return View(newsmodel);
        }

        // GET: /News/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Title,Text,Date")] NewsModel newsmodel)
        {
            if (ModelState.IsValid)
            {
                db.News.Add(newsmodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(newsmodel);
        }

        // GET: /News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsmodel = db.News.Find(id);
            if (newsmodel == null)
            {
                return HttpNotFound();
            }
            return View(newsmodel);
        }

        // POST: /News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Title,Text,Date")] NewsModel newsmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(newsmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(newsmodel);
        }

        // GET: /News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NewsModel newsmodel = db.News.Find(id);
            if (newsmodel == null)
            {
                return HttpNotFound();
            }
            return View(newsmodel);
        }

        // POST: /News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsModel newsmodel = db.News.Find(id);
            db.News.Remove(newsmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
