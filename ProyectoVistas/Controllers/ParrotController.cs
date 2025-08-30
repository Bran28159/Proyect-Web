using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoVistas.Models;
using Newtonsoft.Json;

namespace ProyectoVistas.Controllers;

public class ParrotController : Controller
{
    public List<Parrot> lstParrot = null;
    public ParrotController()
    {
        var myJsonString = System.IO.File.ReadAllText("Models/Parrot.json");
        lstParrot = JsonConvert.DeserializeObject<List<Parrot>>(myJsonString);
    }

    public IActionResult Index()
    {
        return View(lstParrot);
    }

    public IActionResult Find(String parrot)
    {
        List<Parrot> lstResultParrot = new List<Parrot>();

        foreach (var item in lstParrot)
        {
            if (item.Name.ToLower().Contains(parrot.ToLower()))
                lstResultParrot.Add(item);
        }
        return View("Index", lstResultParrot);

    }
    public IActionResult Details(int id)
    {

        foreach (var item in lstParrot)
        {
            if (item.Id == id)
                return View(item);

        }
        return View(new Parrot());

    }

    }
