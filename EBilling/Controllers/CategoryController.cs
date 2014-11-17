using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ebilling.Models;

namespace Ebilling.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Profile/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Profile/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Profile/Create

        public ActionResult Create()
        {
            return View("Edit");
        }


        //
        // POST: /Profile/Create

        [HttpPost]
        public ActionResult Create(categorymaster master)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    using (var ent = new EBillingdb_finalEntities())
                    {
                        master.createddate = DateTime.Now;
                        master.deleted = 0;
                        ent.categorymasters.Add(master);
                        ent.SaveChanges();
                    }
                }
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Edit(int id)
        {
            categorymaster master = null;
            if (ModelState.IsValid)
            {
                using (var ent = new EBillingdb_finalEntities())
                {
                    master = ent.categorymasters.Find(id);
                }
            }
            return View(master);
        }

        [HttpPost]
        public ActionResult Edit(categorymaster master)
        {
            categorymaster master_tmp = null;
            using (var ent = new EBillingdb_finalEntities())
            {
                master_tmp = ent.categorymasters.Find(master.categoryid);
                master_tmp.categoryname = master.categoryname;
                master_tmp.categorydescription = master.categorydescription;
                master_tmp.createddate = master.createddate;
                master_tmp.modifieddate = DateTime.Now;
                ent.SaveChanges();
            }
            return RedirectToAction("List");
        }
        //
        // GET: /Profile/Delete/5

        public ActionResult Delete(int id)
        {
            categorymaster master_tmp = null;
            using (var ent = new EBillingdb_finalEntities())
            {
                master_tmp = ent.categorymasters.Find(id);
                master_tmp.modifieddate = DateTime.Now;
                master_tmp.deleted = 1;
                ent.SaveChanges();
            }
            return RedirectToAction("List");
        }

        //
        // POST: /Profile/Delete/5

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


        public ActionResult List()
        {
            List<categorymaster> master = null;
            using (var ent = new EBillingdb_finalEntities())
            {
                master = ent.categorymasters.Where(m => m.deleted == 0).ToList();
            }
            return View(master);
        }
    }
}
