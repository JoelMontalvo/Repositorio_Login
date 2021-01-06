using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace CapaDatos
{
   public class CD_Platos
    {
        //Instacioamos la conexion
      private  CD_Conexion cn = new CD_Conexion();
        //Isntanciamos las propiedades sql
        SqlCommand cm = new SqlCommand();
        DataTable tabla = new DataTable();
        SqlDataReader leer;

 

        //Metodo para insertar platos
        public void InsertarPlato(string nom_plato, double precio_plato, PictureBox img_plato) {
            //instaciamos la conexion
            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "InsertarPlato";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@nom_plato",nom_plato);
            cm.Parameters.AddWithValue("@precio_plato",precio_plato);
            //instanciamos un memory string 
            MemoryStream ms = new MemoryStream();
            // Se guarda la imagen del picturebox en el memory straeam 
            img_plato.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            cm.Parameters.AddWithValue("@img_plato",ms.GetBuffer());
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();
        }

        //metodo para mostrar platos
        public DataTable MostrarPlatos() {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "MostrarPlatos";
            cm.CommandType = CommandType.StoredProcedure;
            leer = cm.ExecuteReader();
            tabla.Load(leer);
            cn.CerrarConexion();

            return tabla;
        }
        // metodo para editar plato

        public void EditarPlato( string nom_plato, double precio_plato, PictureBox img_plato, int id_plato) {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "EditarPlatos";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id_plato", id_plato);
            cm.Parameters.AddWithValue("@nom_plato", nom_plato);
            cm.Parameters.AddWithValue("@precio_plato", precio_plato);
            MemoryStream ms = new MemoryStream();
            // Se guarda la imagen del picturebox en el memory straeam 
            img_plato.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            cm.Parameters.AddWithValue("@img_plato", ms.GetBuffer());
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }

        // metodo para eliminar platos
        public void EliminarPlato(int id_plato)
        {

            cm.Connection = cn.AbrirConexion();
            cm.CommandText = "EliminarPlatos";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@id_plato", id_plato);
            cm.ExecuteNonQuery();
            cm.Parameters.Clear();
            cn.CerrarConexion();

        }

    }
}
