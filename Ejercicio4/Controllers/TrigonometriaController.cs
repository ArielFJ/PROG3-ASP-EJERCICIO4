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
    public class TrigonometriaController : Controller
    {
        // GET: /<controller>/
        public IActionResult Seno()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Seno(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Seno));
        }

        public IActionResult Coseno()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Coseno(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Coseno));
        }

        public IActionResult Tangente()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Tangente(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Tangente));
        }

        public IActionResult Cotangente()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Cotangente(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Cotangente));
        }

        public IActionResult Secante()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Secante(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Secante));
        }

        public IActionResult Cosecante()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Cosecante(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncTrigonometria.DeterminarOperacion(model, OperacionesTrigonometria.Cosecante));
        }
    }
}
