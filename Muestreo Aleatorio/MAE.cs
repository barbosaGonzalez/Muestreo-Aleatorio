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
    public partial class MAE : Form
    {
        public MAE()
        {
            InitializeComponent();
        }

        double n;
        double N;
        double[,] estratos = new double[10, 20];
        double[] Ns = new double[10];
        double[] ns = new double[10];
        int b = 1;
        int c = 1;
        int i = 1;
        int v = 0;
        int ele = 0;
        int nuevo = 0;
        int total = 0;
        double Z = 0;
        double pres = 0;
        Estratificado est;

        private void txtelemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && v < (Convert.ToDouble(txtn1min.Text)) && (nuevo + 1) <= total)
            {
                estratos[nuevo, v] = Convert.ToDouble(txtelemento.Text);
                v++;
                lsbElementos.Items.Add(txtelemento.Text);
                txtelemento.Text = "";
            }
            else if (v >= (Convert.ToDouble(txtn1min.Text)))
            {
                txtelemento.Clear();
                MessageBox.Show("Ya no puedes meter mas valores");
                btnotroestrato.Select();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            n = Convert.ToDouble(txtnmin.Text);
            N = Convert.ToDouble(txtN.Text);
            total = Convert.ToInt32(txtTotal.Text);
            Z = Convert.ToDouble(txtZ.Text);
            pres = (Convert.ToDouble(txtpres.Text)/100.00);
            txttestN.Select();
        }

        private void btnguardarnn_Click(object sender, EventArgs e)
        {
            if (b <= total)
            {
                Ns[b - 1] = double.Parse(txttestN.Text);
                b++;
            }
            txtn1min.Select();
            if (c <= total)
            {
                ns[c - 1] = Convert.ToDouble(txtn1min.Text);
                c++;
            }
            txtelemento.Select();
        }

        private void btnotroestrato_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= total)
            {
                if (nuevo < total)
                {
                    nuevo++;
                    v = 0;
                    txttestN.Clear();
                    lblNs.Text = "Valor de N" + b.ToString() + ":";
                    txtn1min.Clear();
                    lblnmin.Text = "Valor de n" + c.ToString() +":";
                    txtelemento.Clear();
                    btnguardarnn.Text = "G&uardar N y n " + c.ToString();
                    lsbElementos.Items.Clear();
                    txttestN.Select();
                }
                
            }
            else if (i > total)
            {
                lsbElementos.Items.Clear();
                MessageBox.Show("Ya no puedes meter mas estratos");
                btnListar.Select();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
            txtListanmin.Text = "";
            txtEstratos.Text = "";
            //Mostrar n's y N's
            for (int i = 0; i < total; i++)
            {
                txtLista.Text += "N" + (i + 1) + ": " + Ns[i] + Environment.NewLine;
                txtListanmin.Text += "n" + (i + 1) + ": " + ns[i] + Environment.NewLine;
            }
            //Mostrar estratos
            int temp = 90;
            for (int i = 0; i < total; i++)
            {
                ele = 0;
                while (estratos[i, ele] != 0 && (ele < 20))
                {
                    if (i != temp)
                    {
                        txtEstratos.Text += "Estrato " + (i + 1) + ":" + Environment.NewLine + estratos[i, ele] + Environment.NewLine;
                        temp = i;
                    }
                    else
                        txtEstratos.Text += estratos[i, ele] + Environment.NewLine;
                    ele++;
                }
                txtEstratos.Text += "-------------" + Environment.NewLine+Environment.NewLine;
            }
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            est = new Estratificado(estratos, N, n, Ns, ns, total, Z, pres);
            txtyestr.Text = est.yestr().ToString();
            txttgorrito.Text = est.tgorritoestr().ToString();
            txtSyestr.Text = est.Syestr().ToString();
            txtIntervalo.Text = est.intervaloYestr();
            txtIntervalogorro.Text = est.intervaloTgorro();
            txtny.Text = est.ny().ToString();
            txtnt.Text = est.nT().ToString();
            txtasignacionM.Text = est.asignacionM()[0].ToString();
            txtasignacionT.Text = est.asignacionM()[1].ToString();
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
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
            txtasignacionM.Clear();
            txtasignacionT.Clear();
            txtelemento.Clear();
            txtEstratos.Clear();
            txtEstratos.Text = "Estratos";
            txtIntervalo.Clear();
            txtIntervalogorro.Clear();
            txtLista.Clear();
            txtLista.Text = "N´s";
            txtListanmin.Clear();
            txtListanmin.Text = "n's";
            txtN.Clear();
            txtn1min.Clear();
            txtnmin.Clear();
            txtnt.Clear();
            txtny.Clear();
            txtpres.Clear();
            txtSyestr.Clear();
            txttestN.Clear();
            txttgorrito.Clear();
            txtTotal.Clear();
            txtyestr.Clear();
            txtZ.Clear();
            lsbElementos.Items.Clear();
        }
    }
}
