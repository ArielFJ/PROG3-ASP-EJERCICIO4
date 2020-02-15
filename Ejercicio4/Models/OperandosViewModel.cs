using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio4.Models
{
    public class OperandosViewModel
    {
        [Required]
        [Display(Name = "Número 1")]
        public double? Num1 { get; set; }

        [Display(Name = "Número 2")]
        [Required]
        public double? Num2 { get; set; }


        public double? Resultado { get; set; }
    }
}
