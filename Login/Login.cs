using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using CapaNegocio;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        
        // creamos la cadena de conexion, el @ acepta los caracteres especiales
        SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=login;Integrated Security=True");
        SqlConnection con1 = new SqlConnection(@"Data Source=MSI;Initial Catalog=login;Integrated Security=True");
        //inicializamos el contador

        int intentos = 0;
        // creamos un metodo para el proceso de acceso
        public void Logear(String usu, String contra)
        {
            try
            {
                //Primero abrimos la conexion para las consultas
                con.Open();
                con1.Open();


                //preparamos al conexion a la DB
                SqlCommand cmd = new SqlCommand("select usu_nombre, usu_tipo from tbl_Usuarios " +
                    " Where usu_usuario = @usuario and CONVERT(varchar(50),DECRYPTBYPASSPHRASE('pass',usu_contra)) = @contra ", con);
                SqlCommand cmd1 = new SqlCommand("select usu_usuario, usu_estado from tbl_Usuarios " +
                    "where usu_usuario = @usu", con1);


                // pasamos los parametros de la consulta 
                cmd.Parameters.AddWithValue("usuario", usu);
                cmd.Parameters.AddWithValue("contra", contra);
                cmd1.Parameters.AddWithValue("usu",usu);


                //armamos la consulta y estructura 
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);
                //CREAMOS UNA TABLA 
                DataTable dt = new DataTable();
                DataTable dt1 = new DataTable();
                // LLENAMOS NUESTRA TABLA CON LOS DATOS DE LA TABLA
                sda.Fill(dt);
                sda1.Fill(dt1);

                //EVALUAMOS SI NUESTRA CONSULTA NOS DEVUELVE una fila
                if (dt.Rows.Count == 1 && dt1.Rows[0][1].Equals(1))
                {
                    //si se encuentra datos ocultamos el login
                    this.Hide();
                    //evaluamos que tipo de usuario esta ingresando 
                    if (dt.Rows[0][1].Equals(0))
                    {
                        //extraemos el nombre de la consulta
                        string nombre = dt.Rows[0][0].ToString();
                        // mandamos el parametro del nombre al formulario del administrador
                        new Admin(nombre).Show();

                    }
                    else if (dt.Rows[0][1].Equals(1))
                    {
                        string nombre = dt.Rows[0][0].ToString();
                        new Usuario(nombre).Show();
                    }
                } //Si no encuentra ningun resultado realizamos una nueva consulta para verificar si existe el usuario o no 
                else
                {
                    
                  //si esxiste la consulta nos devuelve una fila 
                    if (dt1.Rows.Count == 1)
                    {
                        //capturamos el estado si esta bloqueado y interumpimos su acceso con un return
                        if (dt1.Rows[0][1].Equals(0))
                        {
                            MessageBox.Show("El usuario " + txtnombre.Text + " esta bloqueado");
                            lbl_recuperar.Visible = true;
                            return;
                        }
                        //se cuanta los intentos cada ves que se equivoca en la contarseña
                        intentos++;
                        MessageBox.Show("Contraseña incorrecta \n" +
                            "Intento:" + intentos);
                        //limpia campo
                        txtcontra.Text = "";
                        txtcontra.Focus();
                        // si los intentos llegan a 3 se bloquea el acceso
                        if (intentos >= 3)
                        {
                            CN_Usuarios ObjetoCN = new CN_Usuarios();//instanciamos el objeto de la capanegocio 
                            MessageBox.Show("A excedido el numero de intentos\n Se bloqueara su acceso");
                            ObjetoCN.BloquearUsuario(txtnombre.Text);//llamamos el metodo para bloquear el usuario
                            lbl_recuperar.Visible = true;
                            
                         
                        }
                    }
                    else
                    {
                        //muetsra mensaje si no existe el usuario y limpia campos 
                        MessageBox.Show("El usuario no existe");
                        txtnombre.Text = "";
                        txtcontra.Text = "";
                        txtnombre.Focus();//el curso inicia en el campo establecido
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // cerramos la conexion
                con1.Close();
                con.Close();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // verificar si los capos estan vacios
            if (txtnombre.Text != "" && txtcontra.Text != "")
            {


                //llamamos al metodo para validar el usuario
                Logear(txtnombre.Text, txtcontra.Text);
            }
            else
            {
                //si esta vacio los campos muestra mensaje
                MessageBox.Show("Usuario y conraseña son campos obligatorios");
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // metodo para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lbl_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro re = new Registro();
            re.Show();
            this.Hide();

        }
       
        //Metodo para ocultar y mostrar contraseña
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtcontra.Text!="") {
               if (txtcontra.PasswordChar == '•')
               {
                txtcontra.PasswordChar = '\0';
                pictureBox7.BackColor = Color.FromArgb(52, 78, 86);
               }
            else
            {
                txtcontra.PasswordChar = '•';
                pictureBox7.BackColor = Color.White;
            }

            txtcontra.Focus();
            }
            
            
        }

        //Metodo para abrir el formulario para recuperar la contraseña
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtnombre.Text != "" || txtcontra.Text != "")
            {
            new RuperarContraseña(txtnombre.Text).ShowDialog();
                txtcontra.Text = "";
                txtcontra.Focus();

            }

        
        }
    }
}
