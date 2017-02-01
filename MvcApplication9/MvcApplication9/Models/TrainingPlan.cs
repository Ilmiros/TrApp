using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppForTraining.Content;

namespace AppForTraining.Models
{
    public class TrainingPlan
    {
        public int TrainingPlanId { get; set; }
        public int IdAthlete { get; set; }
        public Target trainingPlanTarget { get; set; }
    }
}