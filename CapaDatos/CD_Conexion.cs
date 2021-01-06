using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class CD_Conexion
    {
        //cadena de conxion
        private SqlConnection cn = new SqlConnection(@"Data Source=MSI;Initial Catalog=login;Integrated Security=True");


        // metodo a programar abrir conexion 

        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
       
        }
        // metodo a programar cerrrar conexion 
        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;

        }

    }
}
