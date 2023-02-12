using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace latestfinalmasterpiece.Controllers
{
    public class DoctorsController : Controller
    {
        // GET: Doctors
        public ActionResult alldoctors()
        {
            return View();
        }


        public ActionResult singledoctor()
        {
            return View();
        }
    }
}