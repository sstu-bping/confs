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
    public class ConferenceController : Controller
    {
        private ConfsContext db = new ConfsContext();

        // GET: /Conference/
        public ActionResult Index()
        {
            return View(db.Conferences.ToList());
        }

        // GET: /Conference/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceModel conferencemodel = db.Conferences.Find(id);
            if (conferencemodel == null)
            {
                return HttpNotFound();
            }
            return View(conferencemodel);
        }

        // GET: /Conference/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Conference/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,Description,StartDate")] ConferenceModel conferencemodel)
        {
            if (ModelState.IsValid)
            {
                //conferencemodel.
                db.Conferences.Add(conferencemodel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conferencemodel);
        }

        // GET: /Conference/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceModel conferencemodel = db.Conferences.Find(id);
            if (conferencemodel == null)
            {
                return HttpNotFound();
            }
            return View(conferencemodel);
        }

        // POST: /Conference/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,Description,StartDate")] ConferenceModel conferencemodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conferencemodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conferencemodel);
        }

        // GET: /Conference/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConferenceModel conferencemodel = db.Conferences.Find(id);
            if (conferencemodel == null)
            {
                return HttpNotFound();
            }
            return View(conferencemodel);
        }

        // POST: /Conference/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ConferenceModel conferencemodel = db.Conferences.Find(id);
            db.Conferences.Remove(conferencemodel);
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
