using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoVistas.Models;

namespace ProyectoVistas.Controllers
{
    public class AboutController : Controller
    { public IActionResult Index()
        {
            // Puedes pasar datos a la vista si quieres usando ViewData o un modelo
            ViewData["Title"] = "Acerca de";
            return View();
        }
    }
}