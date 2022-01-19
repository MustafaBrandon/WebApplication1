using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class mainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult GradeForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GradeForm(GradesModel model)
        {
            return View();
        }
    }
}
