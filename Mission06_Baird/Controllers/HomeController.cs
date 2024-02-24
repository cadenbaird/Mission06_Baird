using Microsoft.AspNetCore.Mvc;
using Mission06_Baird.Models; // Import your models namespace
using System.Diagnostics;

namespace Mission06_Baird.Controllers
{
    public class HomeController : Controller
    {
        private MovieSubmmisionContext _context; // Define a private field for the database context

        // Constructor to initialize the database context
        public HomeController(MovieSubmmisionContext context)
        {
            _context = context;
        }

        // Action method for the home page
        public IActionResult Index()
        {
            return View();
        }

        // Action method for the "Get to Know" page
        public IActionResult GetToKnow()
        {
            return View();
        }

        // Action method to display the submit movie form (GET request)
        [HttpGet]
        public IActionResult SubmitMovie()
        {
            return View();
        }

        // Action method to handle form submission and save movie submission to the database (POST request)
        [HttpPost]
        public IActionResult SubmitMovie(MovieSubmission response)
        {
            // Add the submitted movie to the database
            _context.Submissions.Add(response);
            _context.SaveChanges();

            // Redirect to a confirmation page and pass the submitted movie data
            return View("Confirmation", response);
        }

        public IActionResult MovieList ()
        {
            //Linq
            var submissions = _context.Submissions
                .OrderBy(x => x.Title).ToList();

            return View(submissions);
        }
    }
}

