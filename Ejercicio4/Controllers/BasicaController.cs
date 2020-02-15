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
            model.Resultado = null;
            if (ModelState.IsValid)
            {
                model.Resultado = model.Num1 + model.Num2;
                return View(model);
            }
            return View(model);
        }
    }
}
