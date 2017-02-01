using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppForTraining.Models;

namespace AppForTraining.Controllers
{
    public class HomeController : Controller
    {
        TrainAppContext dbContext = new TrainAppContext();

        [Authorize]
        public ActionResult Index()
        {
            var athletes = dbContext.Athletes;
            var trainingPlans = dbContext.TrainingPlans;
            var exercises = dbContext.Exercises;

            ViewBag.athletes = athletes;
            ViewBag.trainingPlans = trainingPlans;
            ViewBag.exercises = exercises;

            return View();
        }

    }
}
