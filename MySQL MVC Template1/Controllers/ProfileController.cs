using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySQL_MVC_Template1.Models;

namespace Ebilling.Controllers
{
    public class ProfileController : Controller
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
        public ActionResult Create(profilemaster master)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    using (var ent = new mydb_finalEntities2())
                    {
                        master.createddate = DateTime.Now;
                        master.deleted = 0;
                        ent.profilemasters.Add(master);
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
            profilemaster master = null;
            if (ModelState.IsValid)
            {
                using (var ent = new mydb_finalEntities2())
                {
                    master = ent.profilemasters.Find(id);
                }
            }
            return View(master);
        }

        [HttpPost]
        public ActionResult Edit(profilemaster master)
        {
            profilemaster master_tmp = null;
            using (var ent = new mydb_finalEntities2())
            {
                master_tmp = ent.profilemasters.Find(master.profileid);
                master_tmp.profilename = master.profilename;
                master_tmp.profiledescription = master.profiledescription;
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
            profilemaster master_tmp = null;
            using (var ent = new mydb_finalEntities2())
            {
                master_tmp = ent.profilemasters.Find(id);
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
            List<profilemaster> master = null;
            using (var ent = new mydb_finalEntities2())
            {
                master = ent.profilemasters.Where(m => m.deleted == 0).ToList();
            }
            return View(master);
        }
    }
}
