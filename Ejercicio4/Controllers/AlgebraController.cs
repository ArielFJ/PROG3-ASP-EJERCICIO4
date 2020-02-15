using Ejercicio4.Helper;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio4.Controllers
{
    public class AlgebraController : Controller
    {
        // GET: /<controller>/
        public IActionResult Logaritmo()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Logaritmo(OperandosViewModel model)
        {
            return View(FuncAlgebra.DeterminarOperacion(model, OperacionesAlgebra.Logaritmo));
        }

        public IActionResult Neperiano()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Neperiano(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncAlgebra.DeterminarOperacion(model, OperacionesAlgebra.Neperiano));
        }

        public IActionResult Exponencial()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Exponencial(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncAlgebra.DeterminarOperacion(model, OperacionesAlgebra.Exponencial));
        }
    }
}
