using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class CD_Usuario
    {
        //instanciamos la conexion
        private CD_Conexion cn = new CD_Conexion();

        //instancimos propiedades del sql
        SqlCommand cm = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        //metodo para insertar usuario mediante procedimiento almacenado
        public void InsertarUsuario(string usu_nombre,string usu_usuario,string usu_contra,string usu_pregunta) {
                  //abrimos la conexion en el sqlcomand 
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "InsertarUsuario";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@usu_nombre", usu_nombre);
            cm.Parameters.AddWithValue("@usu_tipo", 1);
            cm.Parameters.AddWithValue("@usu_usuario", usu_usuario);
            cm.Parameters.AddWithValue("@usu_contra", usu_contra);
            cm.Parameters.AddWithValue("@usu_estado", 1);
            cm.Parameters.AddWithValue("@usu_pregunta", usu_pregunta);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
        
        }

        //Metodo para buscar un usuario
        public DataTable BuscarUsuario(string usu_usuario) {
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "BuscarUsuario";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@usu_usuario",usu_usuario);
            leer = cm.ExecuteReader();
            tabla.Load(leer);
            cm.Parameters.Clear();
            cn.CerrarConexion();

            return tabla;
        }
        // Metodo para bloquear un usuario
        public void BloquearUsuario( string usu_usuario)
        {
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "BloquearUsuario";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@usu_usuario",usu_usuario);
            cm.Parameters.AddWithValue("@usu_estado",0);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();
        }

        //metodo para desbloquear
        public void DesbloquearUsuario(string usu_usuario, string usu_pregunta)
        {
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "DesbloquearUsuario";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@usu_usuario",usu_usuario);
            cm.Parameters.AddWithValue("@usu_estado",1);
            cm.Parameters.AddWithValue("@usu_pregunta",usu_pregunta);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }
        //metodo recuperar contraseña 
        public DataTable RecuperarContra(string usu_usuario,string usu_pregunta)
        {
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "RecuperarContraseña";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@usu_usuario",usu_usuario);
            cm.Parameters.AddWithValue("@usu_pregunta",usu_pregunta);
            leer = cm.ExecuteReader();
            tabla.Load(leer);
            cm.Parameters.Clear();
            cn.CerrarConexion();

            return tabla;
        }


    }
}
