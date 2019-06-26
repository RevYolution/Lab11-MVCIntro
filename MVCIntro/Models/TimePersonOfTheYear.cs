using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntro.Models
{
    public class TimePersonOfTheYear
    {
        /// <summary>
        /// Gets/sets year of award
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets/sets honor given to person
        /// </summary>
        public string Honor { get; set; }

        /// <summary>
        /// Gets/sets name of person award is given to
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets country of origin of the person
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets/sets year person was born
        /// </summary>
        public int BirthYear { get; set; }

        /// <summary>
        /// Gets/sets year person died if applicable 
        /// </summary>
        public int DeathYear { get; set; }

        /// <summary>
        /// Gets/sets the title the person held at the time of the award.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets/sets the area the person is involved with
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets/sets the reason the person is receiving the person of the year title. 
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        /// Creates a list of people and all their attributes from the given CSV file.
        /// </summary>
        /// <param name="firstYear">First year of the search</param>
        /// <param name="secondYear">Last year of the search</param>
        /// <returns></returns>
        public static IEnumerable<TimePersonOfTheYear> GetPeople(int firstYear, int secondYear)
        {
            List<TimePersonOfTheYear> people = new List<TimePersonOfTheYear>();

            // Set path to grab file to current directory.
            string filePath = Environment.CurrentDirectory;
            // Set new path
            string newPath = Path.GetFullPath(Path.Combine(filePath, @"wwwroot\personOfTheYear.csv"));
            // Read CSV file into a string array.
            string[] allPeople = File.ReadAllLines(newPath);

            //Goes through the string array and separates all the items with a ','. 
            for (int i = 1; i < allPeople.Length; i++)
            {
                string[] items = allPeople[i].Split(',');

                people.Add(new TimePersonOfTheYear
                {
                    Year = Convert.ToInt32(items[0]),
                    Honor = items[1],
                    Name = items[2],
                    Country = items[3],
                    BirthYear = (items[4] =="") ? 0 : Convert.ToInt32(items[4]),
                    DeathYear = (items[5] == "") ? 0 : Convert.ToInt32(items[5]),
                    Title = items[6],
                    Category =items[7],
                    Context = items[8]
                });
            }

            //Selects only people within the bounds of the search years given. 
            IEnumerable<TimePersonOfTheYear> peopleList = people.Where(p => (p.Year >= firstYear) && (p.Year <= secondYear)).ToList();
            return peopleList;
        }


    }
}
