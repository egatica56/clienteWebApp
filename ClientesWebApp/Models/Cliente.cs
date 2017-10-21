using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientesWebApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public int Edad { get; set; }

        public string Rut { get; set; }

        public int? CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}