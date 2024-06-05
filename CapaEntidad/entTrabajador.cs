using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entTrabajador
    {
        public int idTrabajador { get; set; }
        public string cTrabajador { get; set; }
        public string dni { get; set; }
        public string gradoInstruccion { get; set; }
        public string evaluacionPsicologica { get; set; }
        public string ubicacionArchivo { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaCierre { get; set; }
        public int salario { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int mes { get; set; }
        public int año { get; set; }
        public string razon { get; set; }
        public int userId { get; set; }
        public int codCitas { get; set; }
    }
    public class entTrabajadorDni
    {
        public int idTrabajador { get; set; }
        public string dni { get; set; }
    }
    public class entTrabajadorPuesto
    {
        public string puesto { get; set; }
        public int idTrabajador { get; set; }

    }
    public class entTrabajadorInsertar
    {
        public string dni { get; set; }
        public string cTrabajador { get; set; }
        public string gradoInstruccion { get; set; }
        public string puesto { get; set; }
        public string evaluacionPsicologica { get; set; }
        public string ubicacionArchivo { get; set; }
        public TimeSpan horaInicio { get; set; }
        public TimeSpan horaCierre { get; set; }
        public int salario { get; set; }
        public DateTime fechaRegistro { get; set; }
        public int mes { get; set; }
        public int año { get; set; }
        public string razon { get; set; }
        public int userId { get; set; }
        public int codCitas { get; set; }
    }

    public class entTrabajadorModalidad
    {
        public Boolean camaDentro { get; set; }
        public Boolean camaAfuera { get; set; }
        public string porDias { get; set; }
        public Boolean medioTiempoM { get; set; }
        public Boolean medioTiempoT { get; set; }
        public Boolean turnoNoche { get; set; }
        public int codTrabajador { get; set; }
    }
}
