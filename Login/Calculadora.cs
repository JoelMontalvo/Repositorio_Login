
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        //Creamos las variables que vamos a usar
        double primero;
        double segundo;
        double resultado;
        String operador;


        //mostramos los botones presionados en el txbox que va ser la salida 
        private void button6_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "7";
        }

        private void btb0_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "6";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + "9";
        }

        private void btncoma_Click(object sender, EventArgs e)
        {
            txtVentana.Text = txtVentana.Text + ",";
        }

        //configuramos los botones de los operadores
        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtVentana.Clear();
            txtvista.Clear();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            try
            {
                //designamos que operacion es al precionar el boton con la variable
                operador = "+";
                primero = double.Parse(txtVentana.Text);//capturamos y transformamos a valor numerico el valor ingresado
                txtVentana.Clear();//limpiamos la ventana
                txtvista.Text = primero.ToString() + operador;//mostramos el dato capturado y la operacion 
                txtVentana.Clear();//limpiamos la ventana

            }
            catch (Exception)
            {
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            try
            {
                //designamos que operacion es al precionar el boton con la variable
                operador = "-";
                primero = double.Parse(txtVentana.Text);//capturamos y transformamos a valor numerico el valor ingresado
                txtVentana.Clear();//limpiamos la ventana
                txtvista.Text = primero.ToString() + operador;//mostramos el dato capturado y la operacion 
                txtVentana.Clear();//limpiamos la ventana

            }
            catch (Exception)
            {
            }
        }

        private void btnpotencia_Click(object sender, EventArgs e)
        {
            try
            {
                //designamos que operacion es al precionar el boton con la variable
                operador = "^";
                primero = double.Parse(txtVentana.Text);//capturamos y transformamos a valor numerico el valor ingresado
                txtVentana.Clear();//limpiamos la ventana
                txtvista.Text = primero.ToString() + operador;//mostramos el dato capturado y la operacion 
                txtVentana.Clear();//limpiamos la ventana

            }
            catch (Exception)
            {
            }
        }

        private void btbdividir_Click(object sender, EventArgs e)
        {
            try
            {
                //designamos que operacion es al precionar el boton con la variable
                operador = "/";
                primero = double.Parse(txtVentana.Text);//capturamos y transformamos a valor numerico el valor ingresado
                txtVentana.Clear();//limpiamos la ventana
                txtvista.Text = primero.ToString() + operador;//mostramos el dato capturado y la operacion 
                txtVentana.Clear();//limpiamos la ventana

            }
            catch (Exception)
            {
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //designamos que operacion es al precionar el boton con la variable
                operador = "*";
                primero = double.Parse(txtVentana.Text);//capturamos y transformamos a valor numerico el valor ingresado
                txtVentana.Clear();//limpiamos la ventana
                txtvista.Text = primero.ToString() + operador;//mostramos el dato capturado y la operacion 
                txtVentana.Clear();//limpiamos la ventana
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnigual_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtVentana.Text != "")
                {
                    //capturamos el segundo valor y lo transformamos 
                    segundo = double.Parse(txtVentana.Text);

                    //usamos un switch para evaluar que operador es y realizar esa operacion con cada case
                    switch (operador)
                    {
                        case "+":
                            resultado = primero + segundo;
                            txtVentana.Text = resultado.ToString();
                            txtvista.Text = txtvista.Text + segundo;

                            break;
                        case "-":
                            resultado = primero - segundo;
                            txtVentana.Text = resultado.ToString();
                            txtvista.Text = txtvista.Text + segundo;

                            break;
                        case "*":
                            resultado = primero * segundo;
                            txtVentana.Text = resultado.ToString();
                            txtvista.Text = txtvista.Text + segundo;

                            break;
                        case "/":
                            resultado = primero / segundo;
                            txtVentana.Text = resultado.ToString();
                            txtvista.Text = txtvista.Text + segundo;
                            break;
                        case "^":
                            resultado = Math.Pow(primero, segundo);
                            txtVentana.Text = string.Format("{00:##}",resultado);
                            txtvista.Text =  txtvista.Text + segundo;
                            break;

                        default:
                            txtvista.Text = txtVentana.Text + "=";
                            break;

                    }
                }
            }
            catch (Exception)
            {
            }
        }
        private void btnraiz_Click(object sender, EventArgs e)
        {
            // si esta vacio capturmaos el error y no se hace ninguna accion
            try
            {
   //capturamos el valor ingresado
            primero = double.Parse(txtVentana.Text);
            resultado = Math.Sqrt(primero); //realizamos al opreacion y la capturamos en un variable
            String prim = txtVentana.Text;
            txtVentana.Text = resultado.ToString();//imprimimos en ventana el resultado transformando a string  
            txtvista.Text = "Raiz(" + prim + ")"; //mostramos la operacion que hemos realizado
            }
            catch (Exception)
            {

            }
         
        }




        // metodo para mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
