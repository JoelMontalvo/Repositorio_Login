using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Login
{
    public partial class Productos : Form
    {
    
        // instanciamos mi objeto de capa negocio
        CN_Productos ObjetoCN = new CN_Productos();

        public Productos()
        {
            InitializeComponent();
        }
    

        private void Productos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        //Metodo para mostrar los datos en el datagrid
        private void MostrarProductos()
        {
            dgrv_productos.DataSource = ObjetoCN.MostrarProducto();

        }
    }
}
