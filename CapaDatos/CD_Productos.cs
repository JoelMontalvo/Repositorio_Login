using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class CD_Productos
    {
        //instanciamos la calse conexion simpre debe ser privada
        private CD_Conexion cn = new CD_Conexion();

        //propiedades del sql
        SqlDataReader leer; //lee una consulta o query
        DataTable tabla = new DataTable(); 
        SqlCommand comand = new SqlCommand();
            
        // mostrar prodcuto con metodo almacenado
        public DataTable Mostrar()
        {
            //procedimento almacenado
            comand.Connection = cn.AbrirConexion(); //abrimos al conexion
            comand.CommandText = "MostrarProducto"; //pasamos el nombre del procediiento almacenado
            comand.CommandType = CommandType.StoredProcedure;// que tipo de comando (proceso)
            leer = comand.ExecuteReader(); // leer la consulta y me ejecute el procedmiento
            tabla.Load(leer); //pasamos los datos de la consulta a una tabla
            cn.CerrarConexion();//cerramos la conexion

            return tabla;//retornamos la tabla con los datos de la consulta
        }

        //insertar producto con metodo almacenado

        public void Insertar(string pro_nombre, int pro_cantidad)
        {
            comand.Connection = cn.AbrirConexion();
            comand.CommandText = "InsertarProducto";
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.AddWithValue("@pro_nombre",pro_nombre); //pasamos los parametros al procedimeinto almacenado
            comand.Parameters.AddWithValue("@pro_cantidad",pro_cantidad);
            comand.ExecuteNonQuery(); //ejecutamos la consulta 
            comand.Parameters.Clear();//limpiamos los parametros almacenados
            cn.CerrarConexion();

            

        }
        


    }
}
