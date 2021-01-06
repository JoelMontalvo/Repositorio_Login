using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
   public class CN_Usuarios
    {
        //creamos un objeto de la CapaDatos 
       private CD_Usuario ObjetoCD = new CD_Usuario();

        //metodo para insertar Usuarios

        public void InsertarDatos(string nombre, string usuario,string contra,string pregunta)
        {

            ObjetoCD.InsertarUsuario(nombre, usuario, contra, pregunta);

        } 

       // metodo parra buscar usuario
       public DataTable BuscarUsuario( string usuario)
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.BuscarUsuario(usuario);
            return tabla;
        }

        //Metodo para bloquear usuario
        public void BloquearUsuario(string usuario)
        {
            ObjetoCD.BloquearUsuario(usuario);

        }

        //Metodo para desbloquear al usuario
        public void DesbloquearUsuario(string usuario,string pregunta)
        {
            ObjetoCD.DesbloquearUsuario(usuario,pregunta);

        }

        //metodo para recuperar contraseña

        public DataTable RecuperarContra(string usuario, string pregunta)
        {
            DataTable tabla = new DataTable();
            tabla = ObjetoCD.RecuperarContra(usuario,pregunta);

            return tabla;
        }

    }
}
