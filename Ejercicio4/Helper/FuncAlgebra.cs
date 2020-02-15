using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Helper
{

    public enum OperacionesAlgebra
    {
        Logaritmo,
        Neperiano,
        Exponencial
    }

    public class FuncAlgebra
    {

        public static OperandosViewModel DeterminarOperacion(OperandosViewModel model, OperacionesAlgebra op)
        {
            model.Resultado = null;
            if (model.Num1.HasValue && model.Num2.HasValue)
            {
                switch (op)
                {
                    case OperacionesAlgebra.Logaritmo:
                        model.Resultado = Math.Log10(model.Num2.Value) / Math.Log10(model.Num1.Value) ;
                        break;
                    case OperacionesAlgebra.Neperiano:
                        model.Resultado = Math.Log(model.Num1.Value);
                        break;
                    case OperacionesAlgebra.Exponencial:
                        model.Resultado = Math.Exp(model.Num1.Value);
                        break;
                }
                model.Resultado = (Math.Round((double)model.Resultado * 10000))/10000;
                return model;
            }
            return model;
        }

    }
}
