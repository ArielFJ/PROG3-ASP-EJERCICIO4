using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            return DeterminarOperacion(model, "+");
        }

        public IActionResult Resta()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Resta(OperandosViewModel model)
        {
            return DeterminarOperacion(model, "-");
        }

        public IActionResult Multiplicacion()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Multiplicacion(OperandosViewModel model)
        {
            return DeterminarOperacion(model, "*");
        }

        public IActionResult Division()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Division(OperandosViewModel model)
        {
            return DeterminarOperacion(model, "/");
        }

        ViewResult DeterminarOperacion(OperandosViewModel model, string op)
        {
            model.Resultado = null;
            if (ModelState.IsValid)
            {
                switch (op)
                {
                    case "+":
                        model.Resultado = model.Num1 + model.Num2;
                        break;
                    case "-":
                        model.Resultado = model.Num1 - model.Num2;
                        break;
                    case "*":
                        model.Resultado = model.Num1 * model.Num2;
                        break;
                    case "/":
                        model.Resultado = model.Num1 / model.Num2;
                        break;
                }
                return View(model);
            }
            return View(model);
        }
    }
}
