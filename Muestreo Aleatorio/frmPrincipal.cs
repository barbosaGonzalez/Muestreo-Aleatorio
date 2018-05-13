using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muestreo_Aleatorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Establecer la Fecha y la Hora
            lblHora.Text = DateTime.Now.ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Poner el cursos en el TextBox
            txtNombre.Select();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)   //Si se presiona enter se ejecuta el programa
            {
                Verificar();   //Manda llamar a la funcion Verificar
            }
        }

        private void bntLogear_Click(object sender, EventArgs e)
        {
            Verificar();   //Manda llamar a la funcion Verificar
        }

        //Funcion Verificar donde Compara el Usuario y la Contraseña
        private void Verificar()
        {
            //Compara el usuario y contraseña
            if (txtNombre.Text == "Edsel" && txtContraseña.Text == "e.-94B:_41")   //Si es correcta la comparacion
            {
                Form1 frm = new Form1();   //Llama al segundo formulario
                this.Hide();
                frm.ShowDialog();   //Ejecuta el Segundo Formulario sin permitir regresarse al primer formulario
                this.Show();
                txtNombre.Clear();   //Borra lo que tenga la Caja de Texto Nombre
                txtContraseña.Clear();   //Borra lo que tenga la Caja de Texto Contraseña
                //Poner el cursos en el TextBox
                txtNombre.Select();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña Incorrectos");   //Muestra mensaje de error
                txtNombre.Clear();   //Borra lo que tenga la Caja de Texto Nombre
                txtContraseña.Clear();   //Borra lo que tenga la Caja de Texto Contraseña
                //Poner el cursos en el TextBox
                txtNombre.Select();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
