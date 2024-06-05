using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logTrabajador
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTrabajador _instancia = new logTrabajador();
        //privado para evitar la instanciación directa
        public static logTrabajador Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion singleton

        public List<entTrabajador> ListarTrabajadores()
        {
            return datTrabajador.Instancia.ListarTrabajadores();
        }
        public void InsertaModalidad(entTrabajadorModalidad trabajador)
        {
            datTrabajador.Instancia.InsertaModalidad(trabajador);
        }
        public List<entTrabajadorModalidad> ListarTrabajadoresModalidad()
        {
            return datTrabajador.Instancia.ListarTrabajadoresModalidad();
        }
        public List<entTrabajadorPuesto> BuscarTrabajadorPuesto(string id)
        {
            return datTrabajador.Instancia.BuscarTrabajadorPuesto(id);
        }

        public List<entTrabajadorModalidad> BuscarTrabajadorModalidad(int id)
        {
            return datTrabajador.Instancia.BuscarTrabajadorModalidad(id);
        }
        public List<entTrabajadorDni> BuscarTrabajadorDni(string id)
        {
            return datTrabajador.Instancia.BuscarTrabajadorDni(id);
        }
        public void InsertaTrabajador(entTrabajadorInsertar trabajador)
        {
            datTrabajador.Instancia.InsertaTrabajador(trabajador);
        }
        public bool EliminarTrabajador(entTrabajador trabajador)
        {
            return datTrabajador.Instancia.EliminarTrabajador(trabajador);
        }
    }
}
