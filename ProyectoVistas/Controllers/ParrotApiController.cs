using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProyectoVistas.Models;
using Newtonsoft.Json;

namespace ProyectoVistas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParrotApiController : ControllerBase
    {
        public List<Parrot> lstParrot = null;

        public ParrotApiController()
        {
            var myJsonString = System.IO.File.ReadAllText("Models/Parrot.json");
            lstParrot = JsonConvert.DeserializeObject<List<Parrot>>(myJsonString);
        }

        // GET: api/parrotapi
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(lstParrot); // Solo cambia el return
        }

        // GET: api/parrotapi/find?parrot=guacamaya
        [HttpGet("find")]
        public IActionResult Find(string parrot)
        {
            List<Parrot> lstResultParrot = new List<Parrot>();

            foreach (var item in lstParrot)
            {
                if (item.Name.ToLower().Contains(parrot.ToLower()))
                    lstResultParrot.Add(item);
            }

            return Ok(lstResultParrot); // Solo cambia el return
        }

        // GET: api/parrotapi/details/1
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            foreach (var item in lstParrot)
            {
                if (item.Id == id)
                    return Ok(item); // Solo cambia el return
            }

            return Ok(new Parrot()); // Igual aquí
        }
    }
}
