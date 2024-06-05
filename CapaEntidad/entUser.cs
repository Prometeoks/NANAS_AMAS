using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entUser
    {
        public int usuario_id { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string contraseña { get; set; }
        public string correo_electronico { get; set; }
        public string username { get; set; }

    }
}
