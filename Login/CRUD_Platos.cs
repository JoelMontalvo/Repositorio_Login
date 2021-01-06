using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Login
{
    public partial class CRUD_Platos : Form
    {

        //intanciamos el objeto de capa negocio
        CN_Platos ObjetoCN = new CN_Platos();

        public CRUD_Platos()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if (this.openFileDialog1.FileName.Equals("") == false)
                {
                    img_plato.Load(this.openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("no se pudo subir la imagen");
                }
            }
            catch (Exception)
            {


            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (img_plato.Image != null && txt_nomPlato.Text != "" && txt_precioPlato.Text != "")
            {


                ObjetoCN.InsertarPlato(txt_nomPlato.Text, txt_precioPlato.Text, img_plato);
                
                MessageBox.Show("Se guardo correctamente");
            Mostrar();


            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Panel_Insertar_Plato.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Panel_Insertar_Plato.Visible = true;
        }

          private void Mostrar()
          {
            
            tabla_platos.DataSource = ObjetoCN.MostrarPlatos();
           
            }
        private void CRUD_Platos_Load(object sender, EventArgs e)
        {
            Panel_Insertar_Plato.Visible = false;
        
        }

      

        private void button2_Click(object sender, EventArgs e)
        {

            ObjetoCN.EditarPlato(txt_nomPlato.Text,txt_precioPlato.Text,img_plato,lbl_idPlato.Text);
            MessageBox.Show("se edito correctamente");
            Mostrar();

        }

        private void tabla_platos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == tabla_platos.Columns["eliminar"].Index)
                {
                    int id = Convert.ToInt32(tabla_platos.SelectedCells[2].Value);

                    ObjetoCN.EliminarPlato(id);
                  
                    MessageBox.Show("Se elimino Correctamente");
  Mostrar();



                }

                if (e.ColumnIndex == tabla_platos.Columns["editar"].Index)
                {
                    Panel_Insertar_Plato.Visible = true;

                    lbl_idPlato.Text = tabla_platos.SelectedCells[2].Value.ToString();
                    txt_nomPlato.Text = tabla_platos.SelectedCells[3].Value.ToString();
                    txt_precioPlato.Text = tabla_platos.SelectedCells[4].Value.ToString();
                    byte[] b = (byte[])tabla_platos.SelectedCells[5].Value;
                    MemoryStream ms = new MemoryStream(b);
                    img_plato.Image = Image.FromStream(ms);
                }
            }
            catch (Exception)
            {


            }
        }
    }
}
