using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatchApp.Models;

namespace WatchApp.Controllers
{
    public class WatchController : Controller
    {
        // GET: Watch
        public ActionResult Index()
        {

            using (Entities1 db = new Entities1()) 
            {
                return View(db.WatchTables.ToList());
            }
        }

        // GET: Watch/Details/5
        public ActionResult Details(int id)
        {
            using (Entities1 db = new Entities1())
            {
                return View(db.WatchTables.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Watch/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Watch/Create
        [HttpPost]
        public ActionResult Create(WatchTable watch, FormCollection frm)
        {
            try
            {
                string fileName = Path.GetFileNameWithoutExtension(watch.ImageFile.FileName);
                string extension = Path.GetExtension(watch.ImageFile.FileName);
                fileName = fileName + DateTime.Now.ToString("yymmssffff") + extension;
                watch.image = "~/Product_Images/" + fileName;
                fileName = Path.Combine(Server.MapPath("~/Product_Images/"), fileName);
                watch.ImageFile.SaveAs(fileName);



                // TODO: Add insert logic here
                using (Entities1 db = new Entities1())
                {
                    db.WatchTables.Add(watch);
                    db.SaveChanges();
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Watch/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Watch/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Watch/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Watch/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
