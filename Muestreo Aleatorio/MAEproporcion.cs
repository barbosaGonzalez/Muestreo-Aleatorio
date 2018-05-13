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
    public partial class MAEproporcion : Form
    {
        MEP M = new MEP();
        int i = 2;
        bool bandera = true;

        public MAEproporcion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (bandera)
                textBox1.Clear();
            if (txtNPoblacionEstrato.Text != "" && txtNMuestraEstrato.Text != "" && txtNProporcionEstrato.Text != "")
            {
                bandera = false;
                M.agregarDatos(Convert.ToInt32(txtNTotal.Text), Convert.ToInt32(txtNPoblacionEstrato.Text), Convert.ToInt32(txtNMuestraEstrato.Text), Convert.ToInt32(txtNProporcionEstrato.Text), Convert.ToInt32(txtTotalMuestra.Text), Convert.ToDouble(txtZ.Text), Convert.ToDouble(txtPresicion.Text));
                textBox1.Text += "N" + (i - 1).ToString() + "\tn" + (i - 1).ToString() + "\tA" + (i - 1).ToString() + Environment.NewLine + txtNPoblacionEstrato.Text + "\t" + txtNMuestraEstrato.Text + "\t" + txtNProporcionEstrato.Text + Environment.NewLine+"-------------------"+Environment.NewLine+Environment.NewLine;
                txtNMuestraEstrato.Clear();
                txtNPoblacionEstrato.Clear();
                txtNProporcionEstrato.Clear();
                txtNPoblacionEstrato.Select();
                label4.Text = "N" + i.ToString() + " (Total de Población del Estrato" + i.ToString() + ")";
                label5.Text = "n" + i.ToString() + " (Total de Muestra tomada  Estrato " + i.ToString() + ")";
                label6.Text = "A" + i.ToString() + " (Total de resu. posi. del Estrato " + i.ToString() + ")";
                i++;
            }
            else if (txtNPoblacionEstrato.Text == "" && txtNMuestraEstrato.Text == "" && txtNProporcionEstrato.Text == "")
                btnCalcular.Select();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtAsignacion.Clear();
            M.CalcularPestr();
            M.CalcularTgorrito();
            M.CalcularDesviacionEstandar();
            M.CalcularVarianza();
            M.calcularIntervaloPest();
            M.calcularIntervaloTGorrito();
            M.calcularTamañoMuestraMedia();
            M.calcularTamañoPoblacion();
            txtPestr.Text = M.resultadoPestr.ToString();
            txtTgorrito.Text = M.Tgorrito.ToString();
            txtVarianza.Text = M.Varianza.ToString();
            txtDesviacion.Text = M.DesviacionEstandar.ToString();
            txtInteraloPestMenor.Text = M.IntervaloPest[0].ToString()+" <P< "+ M.IntervaloPest[1].ToString();
            txtIntervaloProbabTMenor.Text = M.IntervaloTgorrito[0].ToString()+" <T< "+M.IntervaloTgorrito[1].ToString();
            txtNMuestra.Text = M.tamanoMuestra.ToString();
            txtNPoblacion.Text = M.tamanoPoblacion.ToString();
            string cadena = "";
            for (int i = 0; i < M.totalEstratos; i++)
            {
                cadena += "Estrato " + (i+1) + " = " + Math.Truncate((M.datosEstrato[i, 0] / M.totalPoblacion) * M.tamanoPoblacion).ToString() + Environment.NewLine;
            }
            txtAsignacion.Text = cadena;
        }

        private void txtNTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAsignacion.Clear();
            txtAsignacion.Text = "Asignacion de la muestra";
            textBox1.Clear();
            textBox1.Text = "Elementos";
            txtDesviacion.Clear();
            txtInteraloPestMenor.Clear();
            txtIntervaloProbabTMenor.Clear();
            txtNMuestra.Clear();
            txtNMuestraEstrato.Clear();
            txtNPoblacion.Clear();
            txtNPoblacionEstrato.Clear();
            txtNProporcionEstrato.Clear();
            txtNTotal.Clear();
            txtPestr.Clear();
            txtPresicion.Clear();
            txtTgorrito.Clear();
            txtTotalMuestra.Clear();
            txtVarianza.Clear();
            txtZ.Clear();
        }
    }
}
