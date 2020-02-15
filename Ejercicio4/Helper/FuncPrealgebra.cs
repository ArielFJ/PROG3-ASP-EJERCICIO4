using Ejercicio4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Helper
{

    public enum OperacionesPrealgebra
    {
        Potencia,
        RaizCuadrada,
        RaizCubica,
        Factorial
    }

    public class FuncPrealgebra
    {

        public static OperandosViewModel DeterminarOperacion(OperandosViewModel model, OperacionesPrealgebra op)
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
                model.Resultado = (Math.Round((double)model.Resultado * 10000)) / 10000;
                return model;
            }
            return model;
        }

        static double Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }

    }
}
