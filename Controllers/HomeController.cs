using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Project1.Models;

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
        public IActionResult SignUp_2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form_3()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form_3(FormInfo i)
        {
            //Passes a model that will then add an entry in the database
            //Add the FormInfo information that was just passed in
            if (ModelState.IsValid)
            {
                context.Forms.Add(i);
                context.SaveChanges();
            }
            return View();
        }
        public IActionResult Display_4()
        {
            return View(context.Forms);
        }
    }

}
