using mainMasterpiesce.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace mainMasterpiesce.Controllers
{
    public class DoctorEnrollingController : Controller
    {
       
        //public ActionResult STDform([Bind(Include = "Student_ID,Id,Name,Email,Password,NationalNum,Grad,Pic,Status,PhoneNumber,BirthFile,PersonalIdFile,CertificateFile,Gender,Major_ID,Wallet")] Student student, HttpPostedFileBase Pic1, HttpPostedFileBase PersonalIdFile1, HttpPostedFileBase CertificateFile1, HttpPostedFileBase BirthFile1)
       FindingpeaceEntities db=new FindingpeaceEntities();
        // GET: DoctorEnrolling
        [Authorize(Roles = "doctor")]
     
        public ActionResult EnrollDoctor()
        {
          
            var mainId=User.Identity.GetUserId();
            dynamic data = new ExpandoObject();

            var specializations = db.specializations.ToList();
            var doct=db.doctors.Where(c=>c.Id==mainId).ToList();

         

          
          
            data.Specializations = specializations;
            data.doc = doct;
            //data.doctor = doctors;

            return View(data);


            
        }







        [HttpPost]
        public ActionResult EnrollDoctor([Bind(Include = "Id,locationdoctor,doctorName,email,phoneNumber,qualiification,specialization,startedate,idCardfile,picdoctor,certificationfile,PersonalIdFile,CertificateFile,birthfile,specializationId,statedoctor,earningDoctortotal,AmountsDue,IBAN,Gender,infodoctor,pricePerHour,ratingdoctor,ratingint")] doctor doctorr, string location, string locationLink, string price, string qualif, string Iban, string exp, string info, int specializationId, HttpPostedFileBase PersonalIdFile1, HttpPostedFileBase Certification, HttpPostedFileBase BirthFile1, HttpPostedFileBase ExperienceFile1)
        {
            var doctorId = User.Identity.GetUserId();
            var doctor = db.doctors.FirstOrDefault(d => d.Id == doctorId);

            dynamic data = new ExpandoObject();

            var specializations = db.specializations.ToList();
            var doct = db.doctors.Where(c=>c.Id==doctorId).ToList();
            data.Specializations = specializations;
            data.doc = doct;
            if (ModelState.IsValid)
            {
                if (PersonalIdFile1 != null)
                {
                    //string fileName = Path.GetFileName(image.FileName);
                    string path = Server.MapPath("~/FormalFile/") + PersonalIdFile1.FileName;
                    PersonalIdFile1.SaveAs(path);
                    doctor.idCardfile = PersonalIdFile1.FileName;
                }

                if (Certification != null)
                {
                    //string fileName = Path.GetFileName(cv.FileName);
                    string path = Server.MapPath("~/FormalFile/") + Certification.FileName;
                    Certification.SaveAs(path);
                    doctor.certificationfile = Certification.FileName;
                }
                if (ExperienceFile1 != null)
                {
                    //string fileName = Path.GetFileName(cv.FileName);
                    string path = Server.MapPath("~/FormalFile/") + ExperienceFile1.FileName;
                    ExperienceFile1.SaveAs(path);
                    doctor.experience = ExperienceFile1.FileName;
                }

                if (BirthFile1 != null)
                {
                    //string fileName = Path.GetFileName(cv.FileName);
                    string path = Server.MapPath("~/FormalFile/") + BirthFile1.FileName;
                    BirthFile1.SaveAs(path);
                    doctor.birthfile = BirthFile1.FileName;
                }
                var SPECIALIZATIONNAME = db.specializations.FirstOrDefault(C => C.specializationId == specializationId).namespecialization;
                doctor.pricePerHour = Convert.ToInt16(price);
                doctor.qualiification = qualif;
                doctor.locationdoctor = location + "," + locationLink;
                doctor.specialization= SPECIALIZATIONNAME;
                doctor.infodoctor = info;
                if (specializationId != null)
                {

                    doctor.specializationId = specializationId;
                }


                ViewBag.doctorname = doctor.doctorName;

                string[] nameParts = Regex.Replace(User.Identity.Name, "[^a-zA-Z]+", " ").Split(' ');
                string firstName =nameParts[0];

                db.SaveChanges();

                doctor.statedoctor = 0;

                TempData["swal_message"] = $"Dr-{firstName}\tYour registration has been submitted and is waiting for approval. You will receive an email notification when your account has been accepted.";
                ViewBag.title = "success";
                ViewBag.icon = "success";
                ViewBag.redirectUrl = Url.Action("Index", "mainHome");

                return View("EnrollDoctor", data);
            }



            data.Specializations = specializations;
            data.doc = doct;


            //data.doctor = doctors;
        

            return View("EnrollDoctor", data);



        }



    }
}