using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio4.Helper;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio4.Controllers
{
    public class PrealgebraController : Controller
    {        
        public IActionResult Potencia()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Potencia(OperandosViewModel model)
        {
            return View(Functions.DeterminarOperacionPrealgebra(model, OperacionesPrealgebra.Potencia));
        }
    }
}
