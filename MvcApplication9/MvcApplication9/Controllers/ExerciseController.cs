using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppForTraining.Models;

namespace AppForTraining.Controllers
{
    public class ExerciseController : Controller
    {

        TrainAppContext db = new TrainAppContext();

        [HttpGet]
        [Authorize]
        public ViewResult AddExerciseInputsPage()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult AddExerciseThanksPage(Exercise exercise)
        {
            db.Exercises.Add(exercise);
            db.SaveChanges();

            return View();
        }
        /*public string AddExercise(Exercise exercise)
        {
            db.Exercises.Add(exercise);
            db.SaveChanges();

            return "Спасибо за добавление упражнения <a href=\"/Home/\">Перейти на главную страницу</a>";

        }*/
    }
}
