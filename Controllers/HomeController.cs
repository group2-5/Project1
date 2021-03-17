using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Project1.Models;
using Microsoft.Extensions.Logging;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        //bring in a FormInfoContext
        private FormInfoContext context { get; set; }
        //Constructor. When this is called, build an instance of FormInfoContext
        public HomeController(FormInfoContext con)
        {
            context = con;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp_2()
        {
            //returns all available time openings
            return View(context.Times
                .OrderBy(t => t.TimeID)
                .Where(t => t.TourId == null));
        }

        [HttpPost]
        public IActionResult SignUp_2(int timeID)
        {
            //assigns time id to a variable that we pass into the ViewBag in order to connect the Time and Group info
            TimeInfo TimeInfo = context.Times.Where(t => t.TimeID == timeID).FirstOrDefault();
            
            ViewBag.TimeInfo = TimeInfo;

            return View("Form_3");
        }

        [HttpGet]
        public IActionResult Form_3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form_3(FormInfo appt, int timeID)
        {
            //make sure the model being passed in is valid
            if (ModelState.IsValid)
            {
                //assign tour values to variables in database
                context.Forms.Add
                    (
                        new FormInfo
                        {
                            NameOfGroup = appt.NameOfGroup,
                            SizeOfGroup = appt.SizeOfGroup,
                            Email = appt.Email,
                            Phone = appt.Phone
                        }
                    );

                //save the changes to the database
                context.SaveChanges();

                //Variable to hold the tou id
                var lastappt = context.Forms.Max(x => x.TourId);

                //variable to hold the timeid
                var AssignedTime = context.Times.Where(t => t.TimeID == timeID).FirstOrDefault();

                //gives that timeslot the tourid
                AssignedTime.TourId = lastappt;

                //save data to database
                context.SaveChanges();

                //go home
                return View("Index");
            }

            else
            {
                //make viewbag the previous id and return it to the same page
                ViewBag.TimeInfo = context.Times.Where(t => t.TimeID == timeID).FirstOrDefault();
                return View("Form_3");
            }

        }
        public IActionResult Display_4()
        {
            //create list to display the information 
            List<string> ListOfApps = new List<string>();

            foreach (var x in context.Times)
            {
                //For every timeslot, if the appointmentid is not null (there is an associated appointment)
                if (x.TourId != null)
                {
                    //make sure that the tourid's match each other
                    var disApps = context.Forms.Where(a => a.TourId == x.TourId).FirstOrDefault();
                
                    //put the time variable and group variables together and add the string to the list
                    ListOfApps.Add(string.Format((x.Time).ToString() + " " + disApps.NameOfGroup + " " + disApps.SizeOfGroup + " " + disApps.Phone + " " + disApps.Email));
                }
            }

            //return the view and pass it the list of appointments
            return View(ListOfApps);
        }
    }

}
