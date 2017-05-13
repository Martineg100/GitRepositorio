using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMiProyecto.ViewModel
{
    public class ClienteViewModel
    {
        public int? ClienteId { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }


    }
}