using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logUser
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logUser _instancia = new logUser();
        //privado para evitar la instanciación directa
        public static logUser Instancia
        {
            get
            {
                return _instancia;
            }
        }
        #endregion singleton

        public List<entUser> ListarUser()
        {
            return datUser.Instancia.ListarUser();
        }


        public void InsertaUser(entUser user)
        {
            datUser.Instancia.InsertaUser(user);
        }


    }
}
