using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Helper
{

    public enum OperacionesBasicas
    {
        Suma,
        Resta,
        Multiplicacion,
        Division
    }

    public class FuncBasica
    {

        public static OperandosViewModel DeterminarOperacion(OperandosViewModel model, OperacionesBasicas op)
        {
            model.Resultado = null;
            if (model.Num1.HasValue && model.Num2.HasValue)
            {
                switch (op)
                {
                    case OperacionesBasicas.Suma:
                        model.Resultado = model.Num1.Value + model.Num2.Value;
                        break;
                    case OperacionesBasicas.Resta:
                        model.Resultado = model.Num1.Value - model.Num2.Value;
                        break;
                    case OperacionesBasicas.Multiplicacion:
                        model.Resultado = model.Num1.Value * model.Num2.Value;
                        break;
                    case OperacionesBasicas.Division:
                        model.Resultado = model.Num1.Value / model.Num2.Value;
                        break;
                }
                model.Resultado = (Math.Round((double)model.Resultado * 10000)) / 10000;
                return model;
            }
            return model;
        }

    }
}
