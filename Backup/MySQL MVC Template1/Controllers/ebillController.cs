using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySQL_MVC_Template1.Models;

namespace Ebilling.Controllers
{
    public class ebillController : Controller
    {
        //
        // GET: /ebill/

        public ActionResult Index()
        {
            
            return View();
        }

        //
        // GET: /ebill/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ebill/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ebill/Create

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
        // GET: /ebill/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ebill/Edit/5

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
        // GET: /ebill/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ebill/Delete/5

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
