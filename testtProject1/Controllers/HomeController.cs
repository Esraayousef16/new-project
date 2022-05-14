using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testtProject1.Models;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace testtProject1.Controllers
{

    public class HomeController : Controller
    {
         private IDMBDataBaseEntities db = new IDMBDataBaseEntities();
      
        [HttpGet]
        public ActionResult Index()
        {
            Moviee obj = db.Moviees.FirstOrDefault();
            return View(obj);
        }

        public ActionResult logIn()
        {
            return View();
        }
        [HttpGet]
        public ActionResult new_acc()
        {
            ViewBag.fn = "";
            ViewBag.ln = "";
            ViewBag.img = "";
            ViewBag.pass = "";
            ViewBag.email = "";
            return View();
        }
        [HttpPost]
        public ActionResult new_acc(Userr userModel)
        {
            db.Userrs.Add(userModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult movie_profile()
        {
            Moviee obj = db.Moviees.FirstOrDefault();
            return View();
        }
        [HttpGet]
        public ActionResult directorProfile()
        {
            Directorr obj = db.Directorrs.FirstOrDefault();
            return View();
        }

        [HttpGet]
        public ActionResult actorProfile()
        {
            Actorr obj =  db.Actorrs.FirstOrDefault();
            return View(obj);
        }

    }
}