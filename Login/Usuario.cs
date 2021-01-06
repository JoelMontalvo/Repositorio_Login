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
    public partial class Usuario : Form
    {
        private CN_Pedidos ObjetoCN = new CN_Pedidos();

        public Usuario(String nom)
        {
            InitializeComponent();
            lblnombre.Text = nom;
            lbl_nombreRecibo.Text = nom;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void perfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new perfil().ShowDialog();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panelCalculadora.Width == 0)
            {
                panelCalculadora.Width = 139;

            } else
            if (panelCalculadora.Width == 139)
            {
                panelCalculadora.Width = 0;
            }

        }

        private void mostrarPlatos() {
            CN_Platos ObjetoCN = new CN_Platos();

            tabla_menu.DataSource = ObjetoCN.MostrarPlatos();
            tabla_menu.Columns[0].Visible = false;
            tabla_menu.Columns[3].Visible = false;
        }
        private void mostrarPedidos()
        {
            CN_Pedidos ObjetoCN = new CN_Pedidos();

            tabla_pedido.DataSource = ObjetoCN.MostrarPedidos();
            tabla_pedido.Columns[1].Visible = false;
        }

            
        private void mostrarRecibo()
        {
            CN_Pedidos ObjetoCN = new CN_Pedidos();

            tabla_recibo.DataSource = ObjetoCN.MostrarPedidos();
            lbl_totalRecibo.Text = lbl_Total.Text;
            tabla_recibo.Columns[0].Visible = false;

        }
         
        private void Mostrartotal ()
            {
              double total = 0;
            foreach (DataGridViewRow row  in tabla_pedido.Rows)
            {
            
              total += (Convert.ToDouble(row.Cells["precio_pedido"].Value) * Convert.ToDouble(row.Cells["cantidad_pedido"].Value));
               
                
            }
             lbl_Total.Text = total.ToString();
            }

        private void Usuario_Load(object sender, EventArgs e)
        {
            mostrarPlatos();
            mostrarPedidos();
            panel_recibo.Visible = false;
            Mostrartotal();
        }

   

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            if (panelCalculadora.Width==139)
            {
                panelCalculadora.Width = 0;
               Calculadora calc = new Calculadora();
                calc.MdiParent = this;
                calc.Show();

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

        string nombre;
        string precio;
        private void tabla_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            nombre = tabla_menu.SelectedCells[1].Value.ToString();

           precio = tabla_menu.SelectedCells[2].Value.ToString();
            byte[] b = (byte[])tabla_menu.SelectedCells[3].Value;
            MemoryStream ms = new MemoryStream(b);
            img_plato.Image = Image.FromStream(ms);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (tabla_menu.SelectedRows.Count > 0)
            {

                ObjetoCN.InsertarPedido(nombre, precio, num_cantidad.Value.ToString());
                mostrarPedidos();
                Mostrartotal();
                panel_pedidos.Visible = true;
                num_cantidad.Value = 1;
                
            }
            else
            {
                MessageBox.Show("Seleccione su pedido porfavor");
            }


           

        }

        private void btn_enviarPedido_Click(object sender, EventArgs e)
        {

            panel_recibo.Visible = true;
            mostrarRecibo();
            panel_menu.Visible = false;


        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel_recibo.Visible = false;
            ObjetoCN.BorrarPedido();
            mostrarPedidos();
            panel_menu.Visible = true;
            Mostrartotal();
            panel_pedidos.Visible = false;


        }

        private void tabla_pedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == tabla_pedido.Columns["eliminar"].Index)
            {
                ObjetoCN.EliminarPedido(tabla_pedido.SelectedCells[1].Value.ToString());
                mostrarPedidos();
                Mostrartotal();
               
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            panel_menu.Visible = true;
        }

        private void hora_Tick(object sender, EventArgs e)
        {
            // metodo para obtener el tiempo de nuestra computadora
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss tt");

        }
    }
}
