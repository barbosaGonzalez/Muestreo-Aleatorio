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
    public partial class MASproporcion : Form
    {
        public MASproporcion()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtProporcion.Text), n = Convert.ToDouble(txtMuestra.Text), poblacion = Convert.ToDouble(txtPoblacion.Text);
            double intervalo = Convert.ToDouble(txtZ.Text), presicion = Convert.ToDouble(txtPresicion.Text);

            //Proporcion Verdadera
            double p = a / n;
            p = Math.Round(p, 4);
            txtP.Text = p.ToString();
            double q = 1.0 - p;
            q = Math.Round(q, 4);
            txtQ.Text = q.ToString();

            //Desviacion Estandar
            double sp = ((poblacion - n) / poblacion) * ((p * q) / n);
            sp = Math.Sqrt(sp);
            sp = Math.Round(sp, 4);
            txtDesviacion.Text = sp.ToString();

            //I.C. de proporcion Verdadera
            double ICMenor = p - (intervalo * sp);
            double ICMayor = p + (intervalo * sp);
            ICMayor = Math.Round(ICMayor, 4);
            ICMenor = Math.Round(ICMenor, 4);
            txtIC.Text = ICMenor + " <= P <= " + ICMayor;

            //Estimacion puntual
            double T = poblacion * p;
            T = Math.Round(T, 4);
            txtEstimacion.Text = T.ToString();

            //Intervalo total
            double IntervaloMenor = T - (intervalo * poblacion * sp);
            double IntervaloMayor = T + (intervalo * poblacion * sp);
            IntervaloMayor = Math.Round(IntervaloMayor, 4);
            IntervaloMenor = Math.Round(IntervaloMenor, 4);
            txtIntervaloTotal.Text = IntervaloMenor + " <= T <= " + IntervaloMayor;

            //Muestra preeliminar
            double d1 = (presicion / 100.00) * p;
            double n1 = (poblacion*Math.Pow(intervalo,2)*p*q)/((poblacion*Math.Pow(d1,2))+(Math.Pow(intervalo,2)*p*q));
            n1 = Math.Round(n1, 0);
            txtMuestraPreeliminar.Text = n1.ToString();

            //Muestra total
            double d2 = (presicion / 100.00) * T;
            double n2 = (Math.Pow(poblacion,2)*Math.Pow(intervalo,2)*p*q)/(Math.Pow(d2,2)+(poblacion*Math.Pow(intervalo,2)*p*q));
            n2 = Math.Round(n2, 0);
            txtMuestraTotal.Text = n2.ToString();
        }

        private void txtPoblacion_KeyPress(object sender, KeyPressEventArgs e)
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
            txtDesviacion.Clear();
            txtEstimacion.Clear();
            txtIC.Clear();
            txtIntervaloTotal.Clear();
            txtMuestra.Clear();
            txtMuestraPreeliminar.Clear();
            txtMuestraTotal.Clear();
            txtP.Clear();
            txtPoblacion.Clear();
            txtPresicion.Clear();
            txtProporcion.Clear();
            txtQ.Clear();
            txtZ.Clear();
        }
    }
}
