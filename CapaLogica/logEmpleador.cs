using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class logEmpleador
    {

        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logEmpleador _instancia = new logEmpleador();
        //privado para evitar la instanciación directa
        public static logEmpleador Instancia
        {
            get
            {
                return _instancia;
            }
        }

        public List<entEmpleador> ListarEmpleadores()
        {
            return datEmpleador.Instancia.ListarEmpleadores();
        }

        public entEmpleadorMotivo ListarEmpleadorMotivo(string id)
        {
            return datEmpleador.Instancia.EmpleadorMotivo(id);
        }

        public List<entEmpleador> ListarEmpleadorPorDni(string id)
        {
            return datEmpleador.Instancia.ListarEmpleadorPorDni(id);
        }
        public void InsertarEmpleador(entEmpleador empleador)
        {
            datEmpleador.Instancia.InsertarEmpleador(empleador);
        }

        public bool EditarEmpleador(entEmpleador empleador)
        {
            return datEmpleador.Instancia.EditarEmpleador(empleador);
        }

        public bool EliminarEmpleador(entEmpleador empleador)
        {
            return datEmpleador.Instancia.EliminarEmpleador(empleador);
        }
    }
}