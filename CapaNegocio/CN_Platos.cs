using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Platos
    {
        //instanciamos un objeto de la apa datos de platos

     private   CD_Platos ObjetoCD = new CD_Platos();
        DataTable tabla = new DataTable();
        //metodo para ingresar un plato al menu
        public void InsertarPlato(string nom_plato, string precio_plato, PictureBox img_plato) {

            ObjetoCD.InsertarPlato(nom_plato, Convert.ToDouble(precio_plato),img_plato);

        }
        // metodo para mostrarplatos
        public DataTable MostrarPlatos()
        {
            tabla = ObjetoCD.MostrarPlatos();

            return tabla;
        }

        //metodo para editar plato
        public void EditarPlato(string nom_plato, string precio_plato, PictureBox img_plato, string id_plato)
        {

            ObjetoCD.EditarPlato(nom_plato, Convert.ToDouble(precio_plato), img_plato,Convert.ToInt32(id_plato));
        

        }

        //meotdo elimanr platos
        public void EliminarPlato(int id_plato) {

            ObjetoCD.EliminarPlato(id_plato);

        }
    }
}
