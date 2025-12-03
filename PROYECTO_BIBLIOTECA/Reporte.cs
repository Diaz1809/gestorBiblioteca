using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_BIBLIOTECA
{
    internal class Reporte
    {
        public string id { get; set; } = "";
        public string Cliente { get; set; } = "";
        public string TipoLibro { get; set; } = "";
        public string Dni { get; set; } = "";
        public string Distrito { get; set; } = "";
        public string Encargado { get; set; } = "";
        public string FechaInicio { get; set; } = "";
        public string FechaFin { get; set; } = "";
    }
}
