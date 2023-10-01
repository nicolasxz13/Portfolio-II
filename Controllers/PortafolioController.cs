using Microsoft.AspNetCore.Mvc;

namespace Portafolio.Controllers
{
    public class Portafolio : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/projects")]
        public ViewResult getAllProjects()
        {
            List<string> projectslist = new List<string>()
            {
                "Tren Ciudad",
                "Hexagon PetStore",
                "CSW",
                "MDA"
            };
            ViewBag.projects = projectslist;
            return View();
        }

        [HttpGet]
        [Route("/contact")]
        public ViewResult contact()
        {
            return View();
        }
    }
}
