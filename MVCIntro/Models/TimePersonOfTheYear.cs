using System;
using System.Collections.Generic;
using System.IO;
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
            List<TimePersonOfTheYear> people = new List<TimePersonOfTheYear>();

            // Set path to grab file to current directory.
            string filePath = Environment.CurrentDirectory;
            // Set new path
            string newPath = Path.GetFullPath(Path.Combine(filePath, @"wwwroot\personOfTheYear.csv"));
            // Read CSV file into a string array.
            string[] allPeople = File.ReadAllLines(newPath);

            for (int i = 0; i < allPeople.Length; i++)
            {
                string[] items = allPeople[i].Split(',');
            }
            return peopleList;
        }
    }
}
