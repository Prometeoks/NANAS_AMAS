using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entPedido
    {

        public string codPedido { get; set; }
        public string dni_empleador { get; set; }
        public string edad_minima { get; set; }
        public string edad_maxima { get; set; }
        public string puesto { get; set; }
        public string funciones { get; set; }
        public string rutina { get; set; }
        public string observaciones { get; set; }
        public string estado { get; set; }
        public DateTime hora_de_inicio { get; set; }
        public DateTime hora_final { get; set; }
        public string cant_horas { get; set; }
        public float sueldo { get; set; }
        public string modalidad { get; set; }
        public int usuario_id { get; set; }

    }
}
