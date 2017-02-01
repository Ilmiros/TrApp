using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppForTraining.Models
{
    public class TrainAppContext : DbContext
    {
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
    }
}