using Ejercicio4.Helper;
using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ejercicio4.Controllers
{
    public class PrealgebraController : Controller
    {        
        // POTENCIA //
        public IActionResult Potencia()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Potencia(OperandosViewModel model)
        {
            return View(FuncPrealgebra.DeterminarOperacion(model, OperacionesPrealgebra.Potencia));
        }

        // RAIZ CUADRADA //
        public IActionResult RaizCuadrada()
        {
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult RaizCuadrada(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncPrealgebra.DeterminarOperacion(model, OperacionesPrealgebra.RaizCuadrada));
        }

        // RAIZ CUBICA //
        public IActionResult RaizCubica()
        {            
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult RaizCubica(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncPrealgebra.DeterminarOperacion(model, OperacionesPrealgebra.RaizCubica));
        }

        // FACTORIAL //
        public IActionResult Factorial()
        {         
            return View(new OperandosViewModel());
        }

        [HttpPost]
        public IActionResult Factorial(OperandosViewModel model)
        {
            model.Num2 = 0;
            return View(FuncPrealgebra.DeterminarOperacion(model, OperacionesPrealgebra.Factorial));
        }
    }
}
