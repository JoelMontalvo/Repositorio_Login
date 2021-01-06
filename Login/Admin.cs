using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Login
{
    public partial class Admin : Form
    {
        public Admin(String nom)
        {
            InitializeComponent();
            lblNombre.Text = nom;
       
        }

        int edit = 0;
        
        //instanciamos un objeto de nuestra CapaNegocio
        private CN_Platos ObjetoCN = new CN_Platos();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        //metodo para mostrar platos
        private void mostrar()
        {
            CN_Platos ObjetoCN = new CN_Platos();
            tabla_platos.DataSource = ObjetoCN.MostrarPlatos();
            tabla_platos.Columns[5].Visible = false;
        }
        private void limpiar()
        {
            txt_nombrePlato.Clear();
            txt_precioPLato.Clear();
            imagen_plato.Image = null;

        }

        //Metodo para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pi(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    imagen_plato.Load(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            { 
            }
    
        }

        private void btn_guardarPlato_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombrePlato.Text !="" && txt_precioPLato.Text != "" && imagen_plato.Image!=null) {


                    if (edit==0)
                {
         ObjetoCN.InsertarPlato(txt_nombrePlato.Text,txt_precioPLato.Text,imagen_plato);
                    MessageBox.Show("Se guardo correctamente");
                    limpiar();
                    mostrar();
                    edit = 0;

                }
                else
                {
                    ObjetoCN.EditarPlato(txt_nombrePlato.Text, txt_precioPLato.Text,imagen_plato,tabla_platos.SelectedCells[2].Value.ToString());
                    MessageBox.Show("Se edito Correctamente");
                    mostrar();
                    limpiar();
                    edit = 0;


                }

                }
                else
                {
                    MessageBox.Show("No se permite datos vacios");
                }
              
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
          

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void tabla_platos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == tabla_platos.Columns["eliminar"].Index)
            {
                
                ObjetoCN.EliminarPlato(Convert.ToInt32 (tabla_platos.SelectedCells[2].Value));
                mostrar();
                limpiar();
                MessageBox.Show("Se elimino correctamente");
               

            }
            if (e.ColumnIndex == tabla_platos.Columns["editar"].Index)
            {
                txt_nombrePlato.Text = tabla_platos.SelectedCells[3].Value.ToString();
                txt_precioPLato.Text = tabla_platos.SelectedCells[4].Value.ToString();
                
                byte[] b = (byte[])tabla_platos.SelectedCells[5].Value;
                MemoryStream ms = new MemoryStream(b);
                imagen_plato.Image = Image.FromStream(ms);
                edit = 1;

            }

        }

        int estado = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
            panel_platos.Visible = true;
                estado = 0;
            }
            else if(estado == 0)
            {
                panel_platos.Visible = false;
                estado = 1;
            }        

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
