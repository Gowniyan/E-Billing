using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ebilling.Controllers
{
    public class RefdocController : Controller
    {
        //
        // GET: /Refdoc/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Refdoc/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Refdoc/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Refdoc/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Refdoc/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Refdoc/Edit/5

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

        //
        // GET: /Refdoc/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Refdoc/Delete/5

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
