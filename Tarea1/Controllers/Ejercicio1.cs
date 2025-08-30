using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Text.Encodings.Web;

namespace Tarea1.Controllers
{
	public class Ejercicio1 : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
        // ejemplo http://localhost:5027/Ejercicio1/Convertir?cadena=hoalmundo
        public string Convertir(string cadena)
		{
			// Convertir a mayusculas e invertir la cadena
			string cadenaMayusculasInvertida = "";
			cadena.ToUpper().Reverse().ToList().ForEach(c => cadenaMayusculasInvertida += c);

			return HtmlEncoder.Default.Encode($"Cadena al reves y en mayusculas: {cadenaMayusculasInvertida}");
		}
        // ejemplo http://localhost:5027/Ejercicio1/Comparar/?cadena1=hola&cadena2=hola
        public bool Comparar(string cadena1, string cadena2)
		{
			return cadena1.Equals(cadena2);
		}

		public IActionResult Perfil()
		{
			return View();
		}
	}
}
