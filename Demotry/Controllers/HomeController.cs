using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelClass;
using DataBaseConnect.Db.Dbopertions;

namespace Demotry.Controllers
{
    public class HomeController : Controller
    {
        StudentRepository repository = null;
        public HomeController()

        {
            repository = new StudentRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(StudentModel model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddStudent(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issucess = "Added Record";

                }
                return View();
            }
            return View("Index");
        }


    }
}