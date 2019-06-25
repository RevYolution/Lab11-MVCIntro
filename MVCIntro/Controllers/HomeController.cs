using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCIntro.Models;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Shows main view for input of start and end year for search page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        /// <summary>
        /// Takes in data from the POST form and redirects to results page with the given parameters.
        /// </summary>
        /// <param name="firstYear">Starting search year</param>
        /// <param name="secondYear">Ending search year</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int firstYear, int secondYear)
        {
            return RedirectToAction("Results", new { firstYear, secondYear });
        }

        /// <summary>
        /// Presents the user with the Person of the Year search results based on year provided.
        /// </summary>
        /// <param name="firstYear">Starting search year</param>
        /// <param name="secondYear">Ending search year</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Results(int firstYear, int secondYear)
        {
            IEnumerable<TimePersonOfTheYear> people = TimePersonOfTheYear.GetPeople(firstYear, secondYear);
            return View(people);
        }
    }
}
