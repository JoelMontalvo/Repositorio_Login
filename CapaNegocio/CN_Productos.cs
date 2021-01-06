using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
   public class CN_Productos
    {
        //creamos un objeto de productos y consumimos de la capa de datos

        private CD_Productos ObjetoCD = new CD_Productos();
        
        //creamos un metodo para pasar los datos a la tabla 

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.Mostrar();
            return tabla;

        }

    }
}
