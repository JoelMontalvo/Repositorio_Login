using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace Login
{
    public partial class RuperarContraseña : Form
    {
        public RuperarContraseña(string usuario)
        {
            InitializeComponent();
            lbl_usuario.Text = usuario;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            CN_Usuarios ObjetoCN = new CN_Usuarios();
            if (txt_mascota.Text != "")
            {
                ObjetoCN.DesbloquearUsuario(lbl_usuario.Text, txt_mascota.Text);

                string contra = ObjetoCN.RecuperarContra(lbl_usuario.Text,txt_mascota.Text).Rows[0][0].ToString();

                MessageBox.Show("Su contraseña es: " + contra);
                this.Hide();


            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
