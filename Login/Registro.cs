using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" && txt_usuario.Text == "" && txt_pass.Text == "" && txt_pass2.Text == "" && txt_pregunta.Text == "") {
                MessageBox.Show("Todo los campos son obligatorios");
            }
            else if (txt_pass.Text == txt_pass2.Text)
            {
                //instanciamos un objeto de la capa negocio
                CN_Usuarios ObjetoCN = new CN_Usuarios();

                if (ObjetoCN.BuscarUsuario(txt_usuario.Text).Rows.Count == 1)
                {
                    MessageBox.Show("El usuario ya existe\n Elija otro");

                }
                else
                {
                    
                    ObjetoCN.InsertarDatos(txt_nombre.Text, txt_usuario.Text, txt_pass.Text, txt_pregunta.Text);
                   MessageBox.Show("Datos guardados exitosamente");

                }


            }
            else
            {
                MessageBox.Show("Contresaña no coincide");
                
            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //para transformar los caracteres a letras
            if (txt_pass.Text != "")
            {
                if (txt_pass.PasswordChar == '•')
                {
                    txt_pass.PasswordChar = '\0';
                    pictureBox7.BackColor = Color.FromArgb(52, 78, 86);
                }
                else
                {
                    txt_pass.PasswordChar = '•';
                    pictureBox7.BackColor = Color.White;
                }
                txt_pass.Focus();


            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (txt_pass2.Text != "")
            {
                if (txt_pass2.PasswordChar == '•')
                {
                    txt_pass2.PasswordChar = '\0';
                    pictureBox3.BackColor = Color.FromArgb(52, 78, 86);
                }
                else
                {
                    txt_pass2.PasswordChar = '•';
                    pictureBox3.BackColor = Color.White;
                }
                txt_pass2.Focus();


            }
        }
    }
}
