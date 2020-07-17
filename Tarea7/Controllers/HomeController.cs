using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tarea7.Models;
using Tarea7.Utils;

namespace Tarea7.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult  Index()
        {
            return View();
        }

        public ActionResult  Create()
        {
            Ticket Ticket1 = new Ticket();
            Ticket1.AbreCajon();  //abre el cajon
            Ticket1.TextoCentro("Reyfi Vasquez Maria"); // imprime en el centro 
            Ticket1.LineasGuion();
            Ticket1.TextoCentro("Probando"); // imprime en el centro 
            Ticket1.LineasGuion();
            Ticket1.TextoCentro("Queloque");
            Ticket1.TextoExtremo("Total", "$1,000,0000");
            Ticket1.TextoCentro("Reyfi Vasquez Maria");
            Ticket1.TextoCentro("   ");
            Ticket1.TextoCentro("   ");
            Ticket1.TextoCentro("   ");
            Ticket1.TextoCentro("   ");
            Ticket1.TextoCentro("   ");
            Ticket1.CortaTicket();

            Ticket1.ImprimirTicket("Ticket");
            

            return Redirect("Index");
        }

        public IActionResult  Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult  Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult  Error()
        {
            return View();
        }
    }
}
