using mainMasterpiesce.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mainMasterpiesce.Controllers
{
    public class DoctorEnrollingController : Controller
    {
       FindingpeaceEntities db=new FindingpeaceEntities();
        // GET: DoctorEnrolling
        [Authorize(Roles = "doctor")]
        public ActionResult EnrollDoctor()
        {
            //var mainId = User.Identity.GetUserId();
            //var doctors=db.doctors.Where(c=>c.Id==mainId).ToList(); 

            dynamic data = new ExpandoObject();

            var specializations = db.specializations.ToList();
            

            data.Specializations = specializations;
            //data.doctor = doctors;

            return View(data);


            
        }
    }
}