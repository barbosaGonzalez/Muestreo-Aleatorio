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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MAS frm = new MAS();   //Llama al segundo formulario
            this.Hide();
            frm.ShowDialog();   //Ejecuta el Segundo Formulario sin permitir regresarse al primer formulario
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MAE frm = new MAE();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MASproporcion frm = new MASproporcion();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MAEproporcion frm = new MAEproporcion();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Establecer la Fecha y la Hora
            lblHora.Text = Convert.ToString(DateTime.Now);
        }
    }
}
