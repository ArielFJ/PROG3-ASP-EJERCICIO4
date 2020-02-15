using Ejercicio4.Helper;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;


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
            return View(FuncBasica.DeterminarOperacion(model, OperacionesBasicas.Suma));
        }

        public IActionResult Resta()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Resta(OperandosViewModel model)
        {
            return View(FuncBasica.DeterminarOperacion(model,OperacionesBasicas.Resta));
        }

        public IActionResult Multiplicacion()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Multiplicacion(OperandosViewModel model)
        {
            return View(FuncBasica.DeterminarOperacion(model, OperacionesBasicas.Multiplicacion));
        }

        public IActionResult Division()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Division(OperandosViewModel model)
        {
            return View(FuncBasica.DeterminarOperacion(model, OperacionesBasicas.Division));
        }

    }
}
