using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;
using Ejercicio4.Helper;


namespace Ejercicio4.Controllers
{
    public class BasicaController : Controller
    {       
        public IActionResult Suma()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Suma(OperandosViewModel model)
        {
            return View(Functions.DeterminarOperacionSuma(model, OperacionesBasicas.Suma));
        }

        public IActionResult Resta()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Resta(OperandosViewModel model)
        {
            return View(Functions.DeterminarOperacionSuma(model,OperacionesBasicas.Resta));
        }

        public IActionResult Multiplicacion()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Multiplicacion(OperandosViewModel model)
        {
            return View(Functions.DeterminarOperacionSuma(model, OperacionesBasicas.Multiplicacion));
        }

        public IActionResult Division()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Division(OperandosViewModel model)
        {
            return View(Functions.DeterminarOperacionSuma(model, OperacionesBasicas.Division));
        }

    }
}
