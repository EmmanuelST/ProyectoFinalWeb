using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalWeb.Entidades
{
    public class Personas
    {
        [Required(ErrorMessage = "Nombre no puede estar vacio")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Cedula no puede estar vacio")]
        [StringLength(11, ErrorMessage = "La longitud de cedula debe ser de 11")]
        public string Cedula { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es necesaria")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Direccion no puede estar vacio")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Celular no puede estar vacio")]
        [Phone(ErrorMessage = "No tiene le formato de un numero telefonico")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Telefono no puede estar vacio")]
        [Phone(ErrorMessage ="No tiene le formato de un numero telefonico")]
        public string Telefono { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int UsuarioId { get; set; }

        public Personas()
        {
            
            Nombres = string.Empty;
            Cedula = string.Empty;
            FechaNacimiento = DateTime.Now;
            Direccion = string.Empty;
            Celular = string.Empty;
            Telefono = string.Empty;
            FechaCreacion = DateTime.Now;
            UsuarioId = 0;
        }
    }
}
