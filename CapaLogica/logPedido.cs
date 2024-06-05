using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;


    namespace CapaLogica
    {
        public class logPedido
        {
            #region Singleton
            // Patrón Singleton
            private static readonly logPedido _instancia = new logPedido();
            // Constructor privado para evitar la instanciación directa
            private logPedido() { }

            public static logPedido Instancia
            {
                get
                {
                    return _instancia;
                }
            }
            #endregion Singleton

            public List<entPedido> ListarPedidos()
            {
                return datPedido.Instancia.ListarPedidos();
            }

            public List<entPedido> BuscarPedidoPorCodigo(string codPedido)
            {
                return datPedido.Instancia.BuscarPedidoPorCodigo(codPedido);
            }

            public void InsertaPedido(entPedido pedido)
            {
                datPedido.Instancia.InsertaPedido(pedido);
            }

            public bool EditarPedido(entPedido pedido)
            {
                return datPedido.Instancia.EditarPedido(pedido);
            }

            public bool EliminarPedido(string codPedido)
            {
                return datPedido.Instancia.EliminarPedido(codPedido);
            }
        }
    }

