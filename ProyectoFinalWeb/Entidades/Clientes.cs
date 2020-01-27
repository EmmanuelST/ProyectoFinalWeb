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
        public decimal LimiteCredito { get; set; }
        public decimal LimiteVenta { get; set; }
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
