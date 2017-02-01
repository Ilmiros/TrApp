using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using AppForTraining.Content;

namespace AppForTraining.Models
{
    public class TrainingAppDbInitializer : CreateDatabaseIfNotExists<TrainAppContext>
    {
        protected override void Seed(TrainAppContext context)
        {
            context.Athletes.Add(new Athlete
            {
                LastName = "Замалиев",
                FirstName = "Ильмир",
                MiddleName = "Фанисович",
                AthleteTarget = Target.Набор_массы,
                Gender = true
            });
            context.Athletes.Add(new Athlete
            {
                LastName = "Замалиева",
                FirstName = "Диана",
                MiddleName = "Расимовна",
                AthleteTarget = Target.Похудение,
                Gender = false
            });
            context.Athletes.Add(new Athlete
            {
                LastName = "Набиуллин",
                FirstName = "Марат",
                MiddleName = "Исфатович",
                AthleteTarget = Target.Набор_массы,
                Gender = true
            });
            context.Athletes.Add(new Athlete
            {
                LastName = "Гусева",
                FirstName = "Анастасия",
                MiddleName = "Витальевна",
                AthleteTarget = Target.Похудение,
                Gender = false
            });

            context.Exercises.Add(new Exercise
            {
                Title = "Приседания со штангой на спине",
                TechnologyDescription = "Снимаешь штангу со стоек и приседаешь"
            });
            context.Exercises.Add(new Exercise
            {
                Title = "Бег на дорожке",
                TechnologyDescription = "Встаешь на дорожку и бежишь"
            });
            context.Exercises.Add(new Exercise
            {
                Title = "Жим лежа на горизонтальной скамье",
                TechnologyDescription = "Ложишься и жмешь что есть дури!"
            });

            //context.TrainingPlans.Add(new TrainingPlan { IdAthlete = context.Athletes.First().AthleteId, trainingPlanTarget = Target.Набор_массы});

            base.Seed(context);
        }
    }
}