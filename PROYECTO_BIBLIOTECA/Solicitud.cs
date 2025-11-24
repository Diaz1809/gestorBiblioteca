using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BIBLIOTECA
{
    public class Solicitud
    {
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public string Dni { get; set; }
        public string Distrito { get; set; }
        public string Encargado { get; set; }
        public string TipoLibro { get; set; }
        public string NombreLibro { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Estado { get; set; }
    }
}
