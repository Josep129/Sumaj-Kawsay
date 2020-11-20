using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sumaj_Kawsay.Controllers
{
    public class PacienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
