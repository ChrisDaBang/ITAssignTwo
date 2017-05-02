using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ITAssignTwo.Models;
using ITAssignTwo.Data;

namespace ITAssignTwo.Controllers
{
    public class HomeController : Controller
    {
        public ApplicationDbContext Context { get;}
        public HomeController(ApplicationDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            AboutModel model = new AboutModel(Context);

            return View(model);
        }

        public IActionResult Contact()
        {
            ContactModel model = new ContactModel();

            return View(model);
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            GalleryModel model = new GalleryModel(); 

            return View(model);
        }
    }
}
