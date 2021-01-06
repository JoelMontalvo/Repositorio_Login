using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CN_Pedidos
    {
        // instanciamos mi objeto de CapaDatos
        private CD_Pedidos ObjetoCD = new CD_Pedidos();

        // metodo para mostrar Pedidos
        public DataTable MostrarPedidos()
        {
            DataTable tabla = new DataTable();

            tabla = ObjetoCD.MostrarPedido();

            return tabla;

        }

        // meotdo insertar pedido

        public void InsertarPedido(string nom_pedido, string precio_pedido, string cantidad_pedido)
        {

            ObjetoCD.InsertarPedido(nom_pedido, Convert.ToDouble(precio_pedido), Convert.ToInt32(cantidad_pedido));

        }

        // metodo para eliminar un pedido
        public void EliminarPedido(string id_pedido)
        {

            ObjetoCD.EliminarPedido(Convert.ToInt32(id_pedido));

        }

        // meotod para borrar el pedido
        public void BorrarPedido()
        {

            ObjetoCD.BorrarPedido();
        }
    }

    }
