using CapaEntidad;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaLogica
{
    public class logCitas
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCitas _instancia = new logCitas();
        //privado para evitar la instanciación directa
        public static logCitas Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion singleton

        public List<entCitas> ListarCitas()
        {
            return datCitas.Instancia.ListarCitas();
        }
        public List<entCitasBuscar> BuscarCitaDni(string dni)
        {
            return datCitas.Instancia.BuscarCitaDni(dni);
        }


        public void InsertaCitas(entCitas citas)
        {
            datCitas.Instancia.InsertaCitas(citas);
        }
        public bool EditarCita(entCitas citas)
        {
            return datCitas.Instancia.EditarCita(citas);
        }

        public bool EliminarCita(entCitas citas)
        {
            return datCitas.Instancia.EliminarCita(citas);
        }
    }
}
