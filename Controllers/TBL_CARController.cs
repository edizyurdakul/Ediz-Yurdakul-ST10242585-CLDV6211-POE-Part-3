using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ediz_Yurdakul_ST10242585_CLDV6211_POE_Part_3.Models;

namespace Ediz_Yurdakul_ST10242585_CLDV6211_POE_Part_3.Controllers
{
    public class TBL_CARController : Controller
    {
        private TheRideYouRent_Entities db = new TheRideYouRent_Entities();

        // GET: TBL_CAR
        public async Task<ActionResult> Index()
        {
            var tBL_CAR = db.TBL_CAR.Include(t => t.TBL_CAR_MODEL);
            return View(await tBL_CAR.ToListAsync());
        }

        // GET: TBL_CAR/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_CAR tBL_CAR = await db.TBL_CAR.FindAsync(id);
            if (tBL_CAR == null)
            {
                return HttpNotFound();
            }
            return View(tBL_CAR);
        }

        // GET: TBL_CAR/Create
        public ActionResult Create()
        {
            ViewBag.CAR_MODEL_ID = new SelectList(db.TBL_CAR_MODEL, "CAR_MODEL_ID", "CAR_MODEL");
            return View();
        }

        // POST: TBL_CAR/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CAR_NO,CAR_MODEL_ID,KILOMETRES_TRAVELLED,SERVICE_KILOMETRES,AVAILABLE")] TBL_CAR tBL_CAR)
        {
            if (ModelState.IsValid)
            {
                db.TBL_CAR.Add(tBL_CAR);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CAR_MODEL_ID = new SelectList(db.TBL_CAR_MODEL, "CAR_MODEL_ID", "CAR_MODEL", tBL_CAR.CAR_MODEL_ID);
            return View(tBL_CAR);
        }

        // GET: TBL_CAR/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_CAR tBL_CAR = await db.TBL_CAR.FindAsync(id);
            if (tBL_CAR == null)
            {
                return HttpNotFound();
            }
            ViewBag.CAR_MODEL_ID = new SelectList(db.TBL_CAR_MODEL, "CAR_MODEL_ID", "CAR_MODEL", tBL_CAR.CAR_MODEL_ID);
            return View(tBL_CAR);
        }

        // POST: TBL_CAR/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CAR_NO,CAR_MODEL_ID,KILOMETRES_TRAVELLED,SERVICE_KILOMETRES,AVAILABLE")] TBL_CAR tBL_CAR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tBL_CAR).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CAR_MODEL_ID = new SelectList(db.TBL_CAR_MODEL, "CAR_MODEL_ID", "CAR_MODEL", tBL_CAR.CAR_MODEL_ID);
            return View(tBL_CAR);
        }

        // GET: TBL_CAR/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TBL_CAR tBL_CAR = await db.TBL_CAR.FindAsync(id);
            if (tBL_CAR == null)
            {
                return HttpNotFound();
            }
            return View(tBL_CAR);
        }

        // POST: TBL_CAR/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            TBL_CAR tBL_CAR = await db.TBL_CAR.FindAsync(id);
            db.TBL_CAR.Remove(tBL_CAR);
            await db.SaveChangesAsync();
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
