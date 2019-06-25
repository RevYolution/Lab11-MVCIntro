using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntro.Models
{
    public class TimePersonOfTheYear
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }

        public static List<TimePersonOfTheYear> GetPeople(int firstYear, int secondYear)
        {
            return peopleList;
        }
    }
}
