using Ejercicio4.Models;
using Microsoft.AspNetCore.Mvc;
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

    public enum OperacionesPrealgebra
    {
        Potencia,
        RaizCuadrada,
        RaizCubica,
        Factorial
    }

    public class Functions
    {
        public static OperandosViewModel DeterminarOperacionSuma(OperandosViewModel model, OperacionesBasicas op)
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
                return model;
            }
            return model;
        }

        public static OperandosViewModel DeterminarOperacionPrealgebra(OperandosViewModel model, OperacionesPrealgebra op)
        {
            model.Resultado = null;
            if (model.Num1.HasValue && model.Num2.HasValue)
            {
                switch (op)
                {
                    case OperacionesPrealgebra.Potencia:
                        model.Resultado = Math.Pow(model.Num1.Value, model.Num2.Value);
                        break;
                    case OperacionesPrealgebra.RaizCuadrada:
                        model.Resultado = Math.Sqrt(model.Num1.Value);
                        break;
                    case OperacionesPrealgebra.RaizCubica:
                        model.Resultado = Math.Cbrt(model.Num1.Value);
                        break;
                    case OperacionesPrealgebra.Factorial:
                        model.Resultado = Factorial(Convert.ToInt32(model.Num1.Value));
                        break;
                }
                return model;
            }
            return model;
        }

        static double Factorial(int n)
        {
            return n;
        }
    }
}
