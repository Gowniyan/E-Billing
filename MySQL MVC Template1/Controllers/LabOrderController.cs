using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MySQL_MVC_Template1.Controllers
{
    public class LabOrderController : Controller
    {
        //
        // GET: /LabOrder/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

    }
}
