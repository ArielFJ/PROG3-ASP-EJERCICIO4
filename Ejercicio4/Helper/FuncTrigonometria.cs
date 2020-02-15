using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Helper
{

    public enum OperacionesTrigonometria
    {
        Seno,
        Coseno,
        Tangente,
        Cotangente,
        Secante,
        Cosecante
    }

    public class FuncTrigonometria
    {

        public static OperandosViewModel DeterminarOperacion(OperandosViewModel model, OperacionesTrigonometria op)
        {
            model.Resultado = null;
            if (model.Num1.HasValue && model.Num2.HasValue)
            {
                double grados = (model.Num1.Value * Math.PI) / 180;
                switch (op)
                {
                    case OperacionesTrigonometria.Seno:
                        model.Resultado = Math.Sin(grados);
                        break;
                    case OperacionesTrigonometria.Coseno:
                        model.Resultado = Math.Cos(grados);
                        break;
                    case OperacionesTrigonometria.Tangente:
                        model.Resultado = Math.Tan(grados);
                        break;
                    case OperacionesTrigonometria.Cotangente:
                        model.Resultado = 1 / Math.Tan(grados);
                        break;
                    case OperacionesTrigonometria.Secante:
                        model.Resultado = 1 / Math.Cos(grados);
                        break;
                    case OperacionesTrigonometria.Cosecante:
                        model.Resultado = 1 / Math.Sin(grados);
                        break;
                }
                model.Resultado = (Math.Round((double)model.Resultado * 10000)) / 10000;
                return model;
            }
            return model;
        }

    }
}
