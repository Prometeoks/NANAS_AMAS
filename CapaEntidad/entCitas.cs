using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCitas
    {
        public int codCitas { get; set; }
        public string nombres { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string celular { get; set; }
        public DateTime fechaEntrevista { get; set; }
        public TimeSpan horaEntrevista { get; set; }
        public int edad { get; set; }
        public string refLlegada { get; set; }
        public string rangoEdad { get; set; }
        public int mes { get; set; }
        public int año { get; set; }
        public string distrito { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string direccion { get; set; }
        public string refDomicilio { get; set; }
        public int UserId { get; set; }
        public string dni { get; set; }
        public string codFecha
        {
            get
            {
                return "COD: " + codCitas + " - FECHA: " + fechaEntrevista.ToString("yyyy-MM-dd");
            }
        }
    }

    public class entCitasBuscar
    {
        public string dni { get; set; }
        public DateTime fechaEntrevista { get; set; }
        public int codCitas { get; set; }

        public string codFecha
        {
            get
            {
                return "COD: " + codCitas + " - FECHA: " + fechaEntrevista.ToString("yyyy-MM-dd");
            }
        }
    }


}
