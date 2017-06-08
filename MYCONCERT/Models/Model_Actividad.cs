using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MYCONCERT.Models
{
    public class ActividadViewModel

    {
        public int idActividad { get; set; }
        public bool tipoActividad { get; set; }
        public int idPais { get; set; }
        public string pais { get; set; }
        public string ubicacion { get; set; }
        public DateTime fechaInicial { get; set; }
        public DateTime fechaFinal { get; set; }
        public string descripcion { get; set; }


    }
}