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
    public partial class MAS : Form
    {
        public MAS()
        {
            InitializeComponent();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lsbDatos.Items.Add(double.Parse(txtValores.Text));
            txtValores.Clear();
            txtValores.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumadatos = 0,  varianza = 0, intervalo = Convert.ToDouble(txtIntervalo.Text);
            int Elementos = 0, total = int.Parse(txtTotal.Text), presicion = int.Parse(txtPrecicion.Text);
            double [] Datos = new double [lsbDatos.Items.Count];

            for (int i = 0; i < lsbDatos.Items.Count; i++)
            {
                Datos[i] = Convert.ToDouble(lsbDatos.Items[i]);
                Elementos++;
            }

            //Media Muestral
            for (int i = 0; i < Elementos; i++)
                sumadatos += Datos[i];
            double MediaMuestal = sumadatos / Elementos;
            MediaMuestal = Math.Round(MediaMuestal, 4);
            txtMediaMuestral.Text = MediaMuestal.ToString();

            //Varianza Muestral
            for (int i = 0; i < Elementos; i++)
                varianza += Math.Pow(Datos[i], 2);
            double VarianzaMuestral = (varianza - (Elementos * Math.Pow(MediaMuestal, 2))) / (Elementos - 1);
            VarianzaMuestral = Math.Round(VarianzaMuestral, 4);
            txtVarianzaMuestral.Text = VarianzaMuestral.ToString();

            //Varianza y Desviacion Estandar de Media Muestral
            double a = total - Elementos;
            double VarianzaMedia = (a/total)*(VarianzaMuestral/Elementos);
            VarianzaMedia = Math.Round(VarianzaMedia, 4);
            txxtVarianzaMediaMuestal.Text = VarianzaMedia.ToString();
            double Desviacion = Math.Sqrt(VarianzaMedia);
            Desviacion = Math.Round(Desviacion, 4);
            txtDesviacion.Text = Desviacion.ToString();

            //Intervalo de Confianza del promedio de la muestra
            double ICpromedioPositivo, ICpromedioNegativo;
            ICpromedioNegativo = MediaMuestal - (intervalo * Desviacion);
            ICpromedioNegativo = Math.Round(ICpromedioNegativo, 4);
            ICpromedioPositivo = MediaMuestal + (intervalo * Desviacion);
            ICpromedioPositivo = Math.Round(ICpromedioPositivo, 4);
            txtICPromedio.Text = ICpromedioNegativo.ToString() + " <= M <= " + ICpromedioPositivo.ToString();

            //Estimacion Puntual Media Poblacional
            double T = total * MediaMuestal;
            txtEstimacion.Text = T.ToString();

            //Intervalo de confianza de la media poblacional
            double ICMediaPositivo, ICMediaNegativo;
            ICMediaNegativo = T - (total * intervalo * Desviacion);
            ICMediaNegativo = Math.Round(ICMediaNegativo, 4);
            ICMediaPositivo = T + (total * intervalo * Desviacion);
            ICMediaPositivo = Math.Round(ICMediaPositivo, 4);
            txtICMediaPoblacional.Text = ICMediaNegativo.ToString() + " <= T <= " + ICMediaPositivo.ToString();

            //Muestra Necesaria
            double d1 = (presicion / 100.00) * MediaMuestal;
            //double arriba = total * (intervalo * intervalo) * VarianzaMuestral;
            //double abajo = (total * (d1*d1))+((intervalo*intervalo)*VarianzaMuestral);
            double n1 = (total * (intervalo * intervalo) * VarianzaMuestral) / ((total * (d1 * d1)) + ((intervalo * intervalo) * VarianzaMuestral));
            n1 = Math.Round(n1, 0);
            txtMuestraNecesaria.Text = n1.ToString();

            //Muestra definitiva
            double d2 = (presicion / 100.00) * T;
            double n2 = (Math.Pow(total, 2) * Math.Pow(intervalo, 2) * VarianzaMuestral) / (Math.Pow(d2, 2) + total * Math.Pow(intervalo, 2) * VarianzaMuestral);
            n2 = Math.Round(n2, 0);
            txtMuestraDefinitiva.Text = n2.ToString();
        }

        private void txtValores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)  //Entra
            {
                lsbDatos.Items.Add(double.Parse(txtValores.Text));
                txtValores.Clear();
                txtValores.Select();
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            txtDesviacion.Clear();
            txtEstimacion.Clear();
            txxtVarianzaMediaMuestal.Clear();
            txtICMediaPoblacional.Clear();
            txtICPromedio.Clear();
            txtIntervalo.Clear();
            txtMediaMuestral.Clear();
            txtMuestraDefinitiva.Clear();
            txtMuestraNecesaria.Clear();
            txtPrecicion.Clear();
            txtTotal.Clear();
            txtValores.Clear();
            txtVarianzaMuestral.Clear();
            lsbDatos.Items.Clear();
        }
    }
}
