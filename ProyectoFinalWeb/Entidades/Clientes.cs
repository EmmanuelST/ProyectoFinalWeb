using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalWeb.Entidades
{
    public class Clientes : Personas
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Debe establecer un limite de compras a credito")]
        public decimal LimiteCredito { get; set; }
        [Required(ErrorMessage = "Debe establecer un limite de venta")]
        public decimal LimiteVenta { get; set; }
        [Required (ErrorMessage ="Ingrese un valance")]
        public decimal Balance { get; set; }


        public Clientes()
        {
            ClienteId = 0;
            LimiteCredito = 0;
            LimiteVenta = 0;
            Balance = 0;

        }
    }
}
