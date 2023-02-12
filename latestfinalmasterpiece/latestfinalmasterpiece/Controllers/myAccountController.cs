using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace latestfinalmasterpiece.Controllers
{
    public class myAccountController : Controller
    {
        // GET: myAccount
        public ActionResult signin()
        {
            return View();
        }


        public ActionResult signup()
        {
            return View();
        }
    }
}