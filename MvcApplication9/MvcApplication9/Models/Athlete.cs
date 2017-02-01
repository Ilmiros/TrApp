using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppForTraining.Content;

namespace AppForTraining.Models
{
    public class Athlete
    {
        public int AthleteId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public bool Gender { get; set; }
        public Target AthleteTarget { get; set; }
    }
}