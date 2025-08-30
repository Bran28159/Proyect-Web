using Microsoft.AspNetCore.Mvc;

namespace Tarea1.Controllers
{
	public class Ejercicio2 : Controller
	{
		private List<string> nombres = new List<string>
		{
			"Ana", "Luis", "Carlos", "Marta", "Sofía", "Jorge", "Lucía", "Pedro", "Elena", "Diego"
		};

		public IActionResult Index()
		{
			return View();
		}
        //ejemplo http://localhost:5027/Ejercicio2/BuscarPosicion/posicion?=1

        public string BuscarPosicion(int posicion)
		{
			if (posicion < 0 || posicion >= nombres.Count)
			{
				return "Posición inválida";
			}

			return nombres[posicion];
		}
        //ejemplo http://localhost:5027/Ejercicio2/BuscarCadena/?nombre=Luis
        public int BuscarCadena(string nombre)
		{
			return nombres.FindIndex(n => n.Equals(nombre));
		}
	}
}
