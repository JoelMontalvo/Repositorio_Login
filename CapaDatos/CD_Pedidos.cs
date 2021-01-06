using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class CD_Pedidos
    {
        // instanciamos la conexion
        private CD_Conexion cn = new CD_Conexion();

        //transact sql
        DataTable tabla = new DataTable();
        SqlCommand cm = new SqlCommand();
        SqlDataReader leer;

        // metodo para mostrar Pedido
        public DataTable MostrarPedido()
        {
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "MostrarPedidos";
            cm.CommandType = CommandType.StoredProcedure;
            leer = cm.ExecuteReader();
            tabla.Load(leer);
            cn.CerrarConexion();
            return tabla;
        }

        //metodo insertar pedido

        public void InsertarPedido(string nom_pedido, double precio_pedido, int cantidad_pedido) {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "InsertarPedidos";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@nom_pedido",nom_pedido);
            cm.Parameters.AddWithValue("@precio_pedido",precio_pedido);
            cm.Parameters.AddWithValue("@cantidad_pedido",cantidad_pedido);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }
        //Metodo para eliminar pedido

        public void EliminarPedido(int id_pedido)
        {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "EliminarPedidos";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id_pedido", id_pedido);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }

        // metodo para borrar pedido
        public void BorrarPedido()
        {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "BorrarPedido";
            cm.CommandType = CommandType.StoredProcedure;
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }


    }
}
