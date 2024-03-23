using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechStore.Models;

namespace TechStore.Controllers
{
    public class ProductosController : Controller
    {
        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Producto producto)
        {
            if (ModelState.IsValid)
            {
                // Aquí puedes agregar la lógica para guardar el producto en la base de datos o realizar otras operaciones.
                // Por ahora, simplemente redireccionamos a la página de inicio.
                return RedirectToAction("Index", "Home");
            }
            return View(producto);
        }
    }
}