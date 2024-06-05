using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entEmpleador
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string celular1 { get; set; }
        public string celular2 { get; set; }
        public string direccion { get; set; }
        public string distrito { get; set; }
        public string provincia { get; set; }
        public string departamento { get; set; }
        public string ref_domicilio { get; set; }
        public string transporte_publico { get; set; }
        public Boolean lista_excluidos { get; set; } 
        public string motivo_excluido { get; set; }
        public string modo_contacto { get; set; }
        public int usuario_id { get; set; }

    }

    public class entEmpleadorMotivo { 
        public string motivo { get; set; }
    
    }

    //public class entCitasBuscar
    //{
    //    public string dni { get; set; }
    //    public DateTime fechaEntrevista { get; set; }
    //    public int codCitas { get; set; }

    //    public string codFecha
    //    {
    //        get
    //        {
    //            return "COD: " + codCitas + " - FECHA: " + fechaEntrevista.ToString("yyyy-MM-dd");
    //        }
    //    }
    //}
}
