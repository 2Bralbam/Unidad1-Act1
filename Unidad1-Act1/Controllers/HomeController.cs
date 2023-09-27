using Microsoft.AspNetCore.Mvc;
using Unidad1_Act1.Models.ViewModels;

namespace Unidad1_Act1.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index(IndexViewModel.Perfil vm)
		{
			IndexViewModel.Perfil PerfilDatos = new() 
			{ 
				Nombre="Bryan Alexis Bautista Muñoz",
				IdFoto=1,
				Carrera="Ingenieria en Sistemas Computacionales",
				Periodo="Enero-Junio",
				Semestre="7mo"
			};
			return View(PerfilDatos);
		}
		public IActionResult MiPerfil(MiPerfilViewModel vm) 
		{
			MiPerfilViewModel.MiPerfil PerfilCompleto = new() 
			{
				IdFoto=1,
				Nombre="Bryan Alexis",
				Apellido="Bautista Muñoz",
				Direccion="Calle 1",
				Telefono="1234567890",
				Email="",
				FechaNacimiento="201G0235@rcarbonifera.tecnm.mx",
				Genero="Masculino",
				Nacionalidad="Mexicana",
				Carrera="Ingenieria en Sistemas Computacionales",
				Semestre="7mo",
				NumeroCtrl="201G0235"

			};
			return View(PerfilCompleto);
		}
	}
}
