﻿using mainMasterpiesce.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Diagnostics;
using Microsoft.Ajax.Utilities;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Web.UI.WebControls;

namespace mainMasterpiesce.Controllers
{
    public class DoctorsInfoController : Controller
    {
        // GET: DoctorsInfo
        FindingpeaceEntities doc=new FindingpeaceEntities();

        //public ActionResult alldoctors(string therapistName, int? specializationsearch)
        //{
        //    var alldoctors = doc.doctors.ToList();
        //    var specialization = doc.specializations.ToList();

        //    if (therapistName != null)
        //    {
        //        var searchDoctor = doc.doctors.Where(c => c.doctorName.Contains(therapistName)).ToList();

        //        return View(Tuple.Create(searchDoctor, specialization));
        //    }
        //    else if (specializationsearch.HasValue)
        //    {
        //        var searchDoctor = doc.doctors.Where(c => c.specializationId == specializationsearch.Value).ToList();

        //        return View(Tuple.Create(searchDoctor, specialization));
        //    }
        //    else
        //    {
        //        return View(Tuple.Create(alldoctors, specialization));
        //    }
        //}


        public ActionResult alldoctors(string therapistName, string specializationsearch,string Male,string rating,string therapytype,string desc)
        {
         



            var alldoctors = doc.doctors.Where(c=>c.statedoctor==1).ToList();
            var specialization = doc.specializations.ToList();
            int therapyTypeInt, ratingInt;
            var accepteddoctors=doc.doctors.Where(c=>c.statedoctor==1).ToList();
       if(desc!=null&&desc=="highest")
            {
                var highestrate = doc.doctors.Where(c=>c.statedoctor == 1).OrderByDescending(c => c.ratingdoctor).ToList();

           
                return View(Tuple.Create(highestrate, specialization));
            }else if(desc != null && desc == "lowest")
            {

                var lowestprice = doc.doctors.Where(c => c.statedoctor == 1).OrderBy(c => c.pricePerHour).ToList();
                return View(Tuple.Create(lowestprice, specialization));

            }



            if (therapistName != null)
            {
                var searchDoctor = doc.doctors.Where(c => c.doctorName.Contains(therapistName)&&c.statedoctor==1).ToList();

                return View(Tuple.Create(searchDoctor, specialization));

            }

            //if (specializationsearch != null)
            //{
            //    var searchspaecialization = doc.doctors.Where(c => c.specializationId == Convert.ToInt16(specializationsearch)).ToList();

            //    return View(Tuple.Create(searchspaecialization, specialization));
            //}
            //male=
            if (Male != null && Male == Convert.ToString(1)&& rating==null&& therapytype==null)
            {

                var genderfiltering = doc.doctors.Where(c => c.Gender == true && c.statedoctor == 1).ToList();
                return View(Tuple.Create(genderfiltering, specialization));
            }
            else if (Male != null && Male == Convert.ToString(0) && rating == null && therapytype == null)
            {
                var genderfiltering0 = doc.doctors.Where(c => c.Gender == false && c.statedoctor == 1).ToList();
                return View(Tuple.Create(genderfiltering0, specialization));
            }
            //rating

            if (rating != null && therapytype == null && Male == null)
            {
                int ratingdecimalradio = Convert.ToInt16(rating);
                var ratingdoctor = doc.doctors.Where(c => c.statedoctor == 1 &&c.ratingint == ratingdecimalradio)
                                             .ToList();

                return View(Tuple.Create(ratingdoctor, specialization));








                //return View(Tuple.Create(ratingdoctor, specialization));
                //foreach (var item in ratingdoctor)
                //{
                //    //if (Convert.ToInt32(rating) ==Math.Round(Convert.ToDecimal(item.ratingdoctor)))
                //    //{
                //        int ratingIntt = Convert.ToInt32(rating);
                //         decimal RATINGDOCROUD =Math.Round(Convert.ToDecimal(item.ratingdoctor));
                //    if(ratingIntt == Convert.ToInt32(RATINGDOCROUD)) {






            }

            if (Male==null&&rating==null&& int.TryParse(therapytype, out therapyTypeInt))
            {
                var therapyfiltering= doc.doctors.Where(c => c.specializationId == therapyTypeInt && c.statedoctor == 1).ToList();
                return View(Tuple.Create(therapyfiltering, specialization));

            }
            //1 all exist and female


            if (int.TryParse(therapytype, out therapyTypeInt) && int.TryParse(rating, out ratingInt)&& Male == Convert.ToString(0))
            {
                var generalfiltering = doc.doctors.Where(c => c.specializationId == therapyTypeInt && c.ratingint == ratingInt&& c.Gender == false && c.statedoctor == 1).ToList();
                return View(Tuple.Create(generalfiltering, specialization));
            }
            //all exist and maleALL
            if (int.TryParse(therapytype, out therapyTypeInt) && int.TryParse(rating, out ratingInt) && Male == Convert.ToString(1))
            {
                var generalfiltering = doc.doctors.Where(c => c.specializationId == therapyTypeInt && c.ratingint == ratingInt && c.Gender == true && c.statedoctor == 1).ToList();
                return View(Tuple.Create(generalfiltering, specialization));
            }
            //2exist gender and thyarapytyprgender=0
            if(Male== Convert.ToString(0)&& int.TryParse(therapytype, out therapyTypeInt) && rating ==null) { 
            
                var filtergendtherapy0=doc.doctors.Where(c=>c.Gender==false&&c.specializationId==therapyTypeInt && c.statedoctor == 1).ToList();

                return View(Tuple.Create(filtergendtherapy0, specialization));


            }
            //2exist gender and thyarapytyprgender=1
            if (Male == Convert.ToString(1) && int.TryParse(therapytype, out therapyTypeInt) && rating == null)
            {

                var filtergendtherapy1 = doc.doctors.Where(c => c.Gender == true && c.specializationId == therapyTypeInt && c.statedoctor == 1).ToList();

                return View(Tuple.Create(filtergendtherapy1, specialization));


            }   //2exist therapytype and rating...
            if (Male ==null&& int.TryParse(therapytype, out therapyTypeInt) && int.TryParse(rating, out ratingInt))
            {

                var filterratingtherapy = doc.doctors.Where(c => c.ratingint == ratingInt && c.specializationId == therapyTypeInt && c.statedoctor == 1).ToList();

                return View(Tuple.Create(filterratingtherapy, specialization));


            }
            //2exist gender and rating=0
            if (Male == Convert.ToString(0) && therapytype == null && int.TryParse(rating, out ratingInt))
            {

                var filtergendrating0 = doc.doctors.Where(c => c.Gender == false && c.ratingint == ratingInt && c.statedoctor == 1).ToList();

                return View(Tuple.Create(filtergendrating0, specialization));


            }
            //2exist gender and rating=1
            if (Male == Convert.ToString(1) && therapytype==null && int.TryParse(rating, out ratingInt))
            { 

                var filtergendrating1 = doc.doctors.Where(c => c.Gender == true && c.ratingint == ratingInt && c.statedoctor == 1).ToList();

                return View(Tuple.Create(filtergendrating1, specialization));


            }
           

            return View(Tuple.Create(alldoctors, specialization));
        }

        public ActionResult AddFeedback(int doctorId, [Bind(Include = "feedbackId,doctorId,patientId,rating,comment,title, statefeedback")] feedback feedback, string ADD,string rating,string title,string yourfeedback)
        {

            string ASPid = User.Identity.GetUserId();
            var patient = doc?.patients?.FirstOrDefault(c => c.Id == ASPid);

            if (patient != null)
            {
                var Mainid = patient.PatiantId;
                // do something with Mainid
          
            //var Mainid = doc.patients.FirstOrDefault(c => c.Id == ASPid).PatiantId;



           




            int ratingintfeedback =Convert.ToInt32(rating);

           
            feedback.title= title;
            feedback.comment = yourfeedback;
            feedback.rating = ratingintfeedback;
            feedback.patientId = Mainid;
            feedback.doctorId = doctorId;
            feedback.feedbacktime= DateTime.Now;
            feedback.statefeedback = 0;

            using (var db = new FindingpeaceEntities())
            {
                db.feedbacks.Add(feedback);
                db.SaveChanges();
                }
            }

            //int std = 5;
            //double fill = Convert.ToDouble(db.Students.FirstOrDefault(a => a.Student_ID == std).Wallet);
            //double total = fill + money;
            //db.Students.FirstOrDefault(a => a.Student_ID == std).Wallet = total;
            //db.SaveChanges();
            return RedirectToAction("singledoctor", new { id = doctorId });
        }


        public PartialViewResult _comment(int?id)
        {
            string ASPid = User.Identity.GetUserId();
            var Mainid = doc.patients.FirstOrDefault(c => c.Id == ASPid).PatiantId;
            dynamic model = new ExpandoObject();
            model.feedback = doc.feedbacks.Where(c => c.patientId==Mainid).ToList();
            model.appointment = doc.appointments.Where(c => c.patientId==Mainid).ToList();
            model.doctor = doc.doctors.Where(c => c.doctorId == id).ToList();
         
          
            return PartialView("_comment", model);
        }

     

    public ActionResult singledoctor(int?id)
        {
            string ASPid = User.Identity.GetUserId();
            var patient = doc?.patients?.FirstOrDefault(c => c.Id == ASPid);
            if (patient != null)
            {
                var Mainid=patient.PatiantId;

          


                //var Mainid = doc.patients.FirstOrDefault(c => c.Id == ASPid).PatiantId;
            int flag = 0;   
          
            var appointmentexist=doc.appointments.Where(c=>c.doctorId==id&&c.patientId==Mainid).ToList();
            var reapcoment = doc.feedbacks.Where(c => c.doctorId == id && c.patientId == Mainid).ToList();

            int Iscommentexistinfeedback = 0;






            int Isexis = 0;
            foreach (var item in appointmentexist)
            {
                Isexis++;//have apointment ok
            }

            if (Isexis >= 1)
            {
                flag = 1;


            }










            foreach (var item in reapcoment)
            {


                Iscommentexistinfeedback++;





            }

            if(Iscommentexistinfeedback> 0)
            {

                flag = 2;
            }




           


        

            ViewBag.checkit = flag ;


            var SingleDoctor = doc.doctors.Where(c => c.doctorId == id).ToList();
            var feedback = doc.feedbacks.Where(c => c.doctorId == id).ToList();
          
            if (SingleDoctor != null)
            {
                return View(Tuple.Create(SingleDoctor, feedback));
            }
            }
            else
            {
                var SingleDoctor = doc.doctors.Where(c => c.doctorId == id).ToList();
                var feedback = doc.feedbacks.Where(c => c.doctorId == id).ToList();

                return View(Tuple.Create(SingleDoctor, feedback));

            }













            Session["countarrow"] =0;
            Session["count"] = 0;
            //Session["day"] = null;

            //Session["day"] = null;

            Session["counterbtn"] = 0;
            Session["day"] = DateTime.Now.ToString("dd/MM/yy");
            ViewBag.btn = "";
            System.Web.HttpContext.Current.Session["btnValues"] = "";
            return RedirectToAction("alldoctors");
        }


     

        public ActionResult doctorprofile()
        {
            

            return View();
        }

        public ActionResult Doctorprof()
        {
            return View();
        }
     
        
        public ActionResult booking(int?id,string day,string selectedSlot,string btnn,string close,string valueToRemove)    
        {
            int count = (int)(Session["countarrow"] ?? 0);
          
            ViewBag.weeks = count;


     
            ViewBag.weeks = count;


            var doctors = doc.doctors.Where(c => c.doctorId == id).ToList();

            var appointment = doc.appointments.Where(c => c.doctorId == id).ToList();
            var pricedoctor = doc.doctors.FirstOrDefault(c => c.doctorId == id).pricePerHour;

         
            dynamic data = new ExpandoObject();
     


            data.doctor = doctors;
           


            data.appoint = appointment;
            data.price = pricedoctor;
            ViewBag.InputStyle = "color:#20BBBD; font-weight:bold";
            if (day != null)
            {
                Session["day"] = day;
            }
       
            bool flagsession = true;

            //if (Session["day"] != null)
            //{
            //    flagsession = false;
            //}
            
          
            bool flag = false;
            if (day == null && Session["day"]!=null)
            {

                //ViewBag.currentday = DateTime.Now.AddDays(count ).ToString("dd/MM/yy");
                ////ViewBag.currentday = DateTime.Now.ToString("dddd");

        day= Session["day"].ToString();
                //flag = true;
            }
            ViewBag.currentday = day;
            if (day == null && Session["day"] == null)
            {

                ViewBag.currentday = DateTime.Now.AddDays(count).ToString("dd/MM/yy");
                //ViewBag.currentday = DateTime.Now.ToString("dddd");


                flag = true;
            }
          
       
            ViewBag.flagsession = flag;


            for (int i = ViewBag.weeks; i < ViewBag.weeks + 7; i++)
            {
                if(ViewBag.currentday == @DateTime.Now.AddDays(i).ToString("dd/MM/yy")){



                    flag = true;
                    
                }


            }


            ViewBag.flag = flag;
            //int couterbtnn = 0;

            //if (btnn != null)
            //{
            //    couterbtnn++;
            //}

            //for(int i = 0; i < couterbtnn; i++)
            //                {
            //    ViewBag.btn+=btnn;
            //}
            ViewBag.btn = System.Web.HttpContext.Current.Session["btnValues"] as string ?? string.Empty;

            string btnValuedate = Request.Form["btnn"];
            //DateTime dateTime = DateTime.Parse(btnValuedate);
            //string dateAndTime = dateTime.ToString("MM/dd/yyyy h:mm tt");


            //if (!string.IsNullOrEmpty(btnValuedate))
            //{
            //    DateTime dateTime = DateTime.Parse(btnValuedate);
            //    string dateAndTime = dateTime.ToString("MM/dd/yyyy h:mm tt");
            //    // use the dateAndTime value as needed
            //}



            // Get the value of the clicked button from the form data
            string btnValue = Request.Form["btnn"];
            ViewBag.flagcolor = false;
          bool  flagcolor = false;


            if (btnn == btnValue)
            {
                ViewBag.selectedslot = ";background-color: red;";

            }




            string buttonStyle = "background-color: #E9E9E9; margin-top: 20px;";
            ViewBag.ButtonStyle = buttonStyle;
            int btncount = (int)(Session["count"] ?? 0);
            bool flagbtnselectedseasion = false;
            if (!string.IsNullOrEmpty(btnValue))
            {
                btncount++;
                Session["count"] = btncount;

                //for (int i = 0; i < countbtn; i++)
                //{

                //}
             
                if (!string.IsNullOrEmpty(ViewBag.currentday))
                {
                    ViewBag.btn += btnValue + ViewBag.currentday.Substring(0, 5) + ",";

                    ViewBag.flagcolor = true;

                }

          
                    //ViewBag.flagcolor = flagcolor;

                    //if (!string.IsNullOrEmpty(valueToRemove))
                    //{
                    //    if (!string.IsNullOrEmpty(ViewBag.btn) && ViewBag.btn.Contains(btnValue + ViewBag.currentday.Substring(0, 5)))
                    //    {
                    //        ViewBag.btn = ViewBag.btn.Replace(btnValue + ViewBag.currentday.Substring(0, 5) + ",",string.Empty);
                    //    }


                    //}

                    // Append the value of the clicked button to the existing value of ViewBag.btn
                    //ViewBag.btn += btnValue + ViewBag.currentday.substring(0,2)+"     ";
                    flagbtnselectedseasion = true;

                // Store the updated value of ViewBag.btn in the session variable
                System.Web.HttpContext.Current.Session["btnValues"] = ViewBag.btn;
             
             
            }
            ViewBag.flagbtnselectedseasion = flagbtnselectedseasion;

           
            //ViewBag.counter= countbtn;

            Session["currentday"] = ViewBag.currentday;
            if (!string.IsNullOrEmpty(valueToRemove))
            {

                ViewBag.btn = ViewBag.btn.Replace(valueToRemove, string.Empty);

                if (System.Web.HttpContext.Current.Session["btnValues"] != null && System.Web.HttpContext.Current.Session["btnValues"].ToString().Contains(valueToRemove))
                {
                    string btnValues = System.Web.HttpContext.Current.Session["btnValues"].ToString();
                    btnValues = btnValues.Replace(valueToRemove, string.Empty);
                    System.Web.HttpContext.Current.Session["btnValues"] = btnValues;
                    btncount--;
                    Session["count"] = btncount;
                }


            }
            ViewBag.selectedsloot += Session["currentday"];
            Session["allprice"] = pricedoctor * Convert.ToInt32(Session["count"]);

            Session["doctorId"] = id;

            if (User.IsInRole("doctor"))
            {
                //viewBag.disabled = disabled;
                ViewBag.disabled = "disabled";
            }
            else
            {
                ViewBag.disabled = "";
            }


            return View(data);
        }


        public ActionResult UpdateInputClass(int doctorId)
        {
            ViewBag.inputClass = "active";
            return RedirectToAction("booking", new { id = doctorId });
        }
        public ActionResult plusweeks(int doctorId, string arrow)
        {
            int count = (int)(Session["countarrow"] ?? 0);

            count+=7;
            ViewBag.weeks = count;

            // Store the updated count value in session state
            Session["countarrow"] = count;




         
               
          










            return RedirectToAction("booking", new { id = doctorId });
        }
        public ActionResult minusWeek(int doctorId, string arrow)
        {
            int count = (int)(Session["countarrow"] ?? 0);

            if (count > 0)
            {


           
            count -= 7;
            ViewBag.weeks = count;

        



            // Store the updated count value in session state
            Session["countarrow"] = count;



            }


            return RedirectToAction("booking", new { id = doctorId });
        }
        //public ActionResult RemoveValue( int doctorId, string valueToRemove)
        //{
        //    if(!string.IsNullOrEmpty(ViewBag.btn))
        //    {

        //        ViewBag.btn = ViewBag.btn.Replace(valueToRemove, "");
        //    }
      
        //    return RedirectToAction("booking", new { id = doctorId });
        //}


        //public ActionResult RemoveButton(int index)
        //{
        //    if (ViewBag.btn != null && ViewBag.btn.Count > index)
        //    {
        //        ViewBag.btn.RemoveAt(index);
        //    }
        //    return RedirectToAction("booking", new { id = doctorId });
        //}

        //public ActionResult RemoveBtn(int doctorId,string close, string index )
        //{
        //    if (ViewBag.btn != null)
        //    {
        //        var btnValues = ViewBag.btn.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
        //        // Remove the value from the array of btnValues
        //        btnValues.RemoveAt(Convert.ToInt32(index));
        //        // Join the remaining values back into a comma-separated string
        //        var newBtnValue = string.Join(",", btnValues);
        //        // Store the new string back in ViewBag.btn
        //        ViewBag.btn = newBtnValue;
        //    }

        //    // Return the view with the updated data
        //    return RedirectToAction("booking", new { id = doctorId });
        //}

        public ActionResult selectedslot(int doctorId, string arrow,string day,string btnn)
        {
            //int count = (int)(Session["count"] ?? 0);


            //ViewBag.weeks = count;

            //// Store the updated count value in session state
            //Session["count"] = count;

            //if (!string.IsNullOrEmpty(selectedSlot))
            //{
            //    DateTime d = DateTime.Parse(selectedSlot);
            //    string dateOnly = d.ToString("MM/dd/yyyy");

                ViewBag.selectedsloot += Session["currentday"];
            //// rest of your code here
            //if (Session["day"] != null)
            //{
            //    day = Session["day"].ToString();

            //}
            ViewBag.btn = btnn;

            int slotcount = 0;


            ViewBag.slotCount = slotcount;



            return RedirectToAction("booking", new { id = doctorId });
        }
        public ActionResult determinday(int doctorId, string date,string day)
        {
            int count = (int)(Session["count"] ?? 0);

            count -= 7;
            ViewBag.weeks = count;

            // Store the updated count value in session state
            Session["count"] = count;






            return RedirectToAction("booking", new { id = doctorId });
        }



        //public ActionResult AddFeedback(int doctorId, [Bind(Include = "feedbackId,doctorId,patientId,rating,comment,title, statefeedback")] feedback feedback, string ADD, string rating, string title, string yourfeedback)
        //{
        //    string ASPid = User.Identity.GetUserId();
        //    var Mainid = doc.patients.FirstOrDefault(c => c.Id == ASPid).PatiantId;



        //    int ratingintfeedback = Convert.ToInt32(rating);


        //    feedback.title = title;
        //    feedback.comment = yourfeedback;
        //    feedback.rating = ratingintfeedback;
        //    feedback.patientId = Mainid;
        //    feedback.doctorId = doctorId;
        //    feedback.feedbacktime = DateTime.Now;
        //    feedback.statefeedback = 0;

        //    using (var db = new FindingpeaceEntities())
        //    {
        //        db.feedbacks.Add(feedback);
        //        db.SaveChanges();
        //    }












        [Authorize(Roles = "patient")]
        public ActionResult checkout(int? id)
        {

            string slots = Session["btnValues"].ToString();


            string[] tableslots = slots.Split(',');

       




            var AspId = User.Identity.GetUserId();

            var doctors = doc.doctors.Where(c => c.doctorId == id).ToList();

            var appointmentt = doc.appointments.Where(c => c.doctorId == id).ToList();
            var pricedoctor = doc.doctors.FirstOrDefault(c => c.doctorId == id).pricePerHour;
            var patient = doc.patients.FirstOrDefault(c => c.Id == AspId).PatiantId;
            //var doctorId = doc.doctors.FirstOrDefault(c => c.doctorId == id).doctorId;

            dynamic data = new ExpandoObject();


            data.doctor = doctors;
            data.appoint = appointmentt;

            data.price = pricedoctor;
          
            

            return View(data);
        }

        public ActionResult ConfirmBooking(int id, [Bind(Include = "apointmentId,patientId,doctorId,starttime,endtime,doctornotes, patientnotes,apointmentprice,rating,medication,dosage,dosagefrequency,medicationinstructions,confirmappointment")] appointment appoint, string card_name)
        {

            string slots = Session["btnValues"].ToString();


            string[] tableslots = slots.Split(',');






            var AspId = User.Identity.GetUserId();

            var doctors = doc.doctors.Where(c => c.doctorId == id).ToList();

            var appointmentt = doc.appointments.Where(c => c.doctorId == id).ToList();
            var pricedoctor = doc.doctors.FirstOrDefault(c => c.doctorId == id).pricePerHour;
            var patient = doc.patients.FirstOrDefault(c => c.Id == AspId).PatiantId;
            //var doctorId = doc.doctors.FirstOrDefault(c => c.doctorId == id).doctorId;

            dynamic data = new ExpandoObject();


            data.doctor = doctors;
            data.appoint = appointmentt;

            data.price = pricedoctor;
            

            for (int i = 0; i < (tableslots.Length)-1; i++)
            {
                appoint.patientId = patient;
                appoint.doctorId = id;

                appoint.starttime = tableslots[i].ToString();

                if (!string.IsNullOrEmpty(tableslots[i]))
                {
                    //string startTime = tableslots[i];
                    //int hours = int.Parse(startTime.Substring(0, 2));
                    //int endHours = hours + 1;
                    //string endTime = endHours.ToString().PadLeft(2, '0') + startTime.Substring(2);
                 
                    if (@tableslots[i][1].ToString()==":")
                    {

                        int endtime = Convert.ToInt32(tableslots[i][0].ToString()) + 1;
                        appoint.endtime = endtime.ToString() + (tableslots[i].ToString()).Substring(1, 11);

                    }else if (@tableslots[i][1].ToString().Contains('2'))
                    {



                            int endtime = 1;
                        appoint.endtime =  (tableslots[i].ToString()).Replace("12", "1");

                        //int endtime =1;
                        //appoint.endtime = endtime.ToString()+ " :00 PM " + (tableslots[i].ToString()).Substring(7, 11);

                    }
                    else 
                    {
                        int endtime = Convert.ToInt32(tableslots[i][1].ToString()) + 1;
                      
                        if (tableslots[i][1].ToString() == "1")
                        {

                            appoint.endtime = (tableslots[i].ToString()).Replace("11", "12");

                        }
                        else if(tableslots[i][1].ToString() == "0")
                        {



                            appoint.endtime = (tableslots[i].ToString()).Replace("10", "11");

                        }

                    }
                     
                    // rest of your code here
                }


                //int endtime = Convert.ToInt32((tableslots[i].ToString())[0]) + 1;

  
                appoint.confirmappointment = 0;
                appoint.apointmentprice = pricedoctor;



          
         
                using (var db = new FindingpeaceEntities())
                {
                    db.appointments.Add(appoint);
                    db.SaveChanges();
                }
            }



            return RedirectToAction("succefullyBooking", new { id=id });
        }




        public ActionResult succefullyBooking(int? id)
        {

            string slots = Session["btnValues"].ToString();


            string[] tableslots = slots.Split(',');






            var AspId = User.Identity.GetUserId();

            var doctors = doc.doctors.Where(c => c.doctorId == id).ToList();

            var appointmentt = doc.appointments.Where(c => c.doctorId == id).ToList();
    
            var pricedoctor = doc.doctors.FirstOrDefault(c => c.doctorId == id).pricePerHour;
            var patient = doc.patients.FirstOrDefault(c => c.Id == AspId).PatiantId;

            var appointcurrentpatient = doc.appointments.Where(c => c.doctorId == id && c.patientId == patient).ToList();
            //var doctorId = doc.doctors.FirstOrDefault(c => c.doctorId == id).doctorId;

            dynamic data = new ExpandoObject();


            data.doctor = doctors;
            data.appoint = appointmentt;
            data.appointcurrentpatient = appointcurrentpatient;
            data.price = pricedoctor;



            return View(data);
        }




    }
}