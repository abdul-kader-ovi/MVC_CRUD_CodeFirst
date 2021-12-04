using MVCCodeFirst_TrainingAcademySln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst_TrainingAcademySln.Controllers
{
    public class TrainerController : Controller
    {
        ApplicationDbContext dbobj = new ApplicationDbContext();
        // GET: Trainer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateTrainerAjax()
        {
            var Model = dbobj.Trainers.ToList();
            return View(Model);
        }
        public ActionResult TrainerAjaxFormExample(Trainer obj)
        {

            dbobj.Trainers.Add(obj);
            dbobj.SaveChanges();
            IEnumerable<Trainer> list = dbobj.Trainers.ToList();
            return View(list);
        }
    }
}