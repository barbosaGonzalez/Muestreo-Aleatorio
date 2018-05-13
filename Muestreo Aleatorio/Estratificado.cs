using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muestreo_Aleatorio
{
    class Estratificado
    {
        #region Valores
        private double[,] _estratos;
        public double[,] estratos { set { _estratos = value; } get { return _estratos; } }
        private double _N;
        public double N { set { _N = value; } get { return _N; } }
        private double _n;
        public double n { set { _n = value; } get { return _n; } }
        private double[] _Ns;
        public double[] Ns { set { _Ns = value; } get { return _Ns; } }
        private double[] _ns;
        public double[] ns { set { _ns = value; } get { return _ns; } }
        private int _total;
        public int total { set { _total = value; } get { return _total; } }
        private double _Z;
        public double Z
        {
            set { _Z = value; }
            get
            {
                return _Z;
            }
        }
        private double _pres;
        public double pres { set { _pres = value; } get { return _pres; } }
        #endregion
        public Estratificado(double[,] estratos, double N, double n, double[] Ns, double[] ns, int total, double Z, double pres)
        {
            this.estratos = estratos;
            this.N = N;
            this.n = n;
            this.Ns = Ns;
            this.ns = ns;
            this.total = total;
            this.Z = Z;
            this.pres = pres;
        }
        int ele = 0;
        double[] ys = new double[10];
        double whSh = 0;
        double[] Sn = new double[10];
        double yestrN = 0;
        double syestrN = 0;
        double tgorritop = 0;
        double nyN = 0;
        double nTn = 0;
        public double yestr()
        {
            double resultado = 0;
            //Sumar los elementos del estrato y guardarlos en un vector
            for (int i = 0; i < total; i++)
            {
                ele = 0;
                while (estratos[i, ele] != 0 && (ele < 20))
                {
                    ys[i] = estratos[i, ele] + ys[i];
                    ele++;
                }
            }
            //Sacar los promedios por estrato y guardarlos en el mismo vector
            for (int i = 0; i < total; i++)
            {
                ys[i] = ys[i] / ns[i];
                //Realizar la parte de arriba (N1*y1+...)
                resultado = resultado + (ys[i] * Ns[i]);
            }
            resultado = resultado / N;
            yestrN = resultado;
            resultado = Math.Round(resultado, 4);
            return resultado;
        }
        public double tgorritoestr()
        {
            double res = N * yestrN;
            tgorritop = res;
            res = Math.Round(res, 4);
            return res;
        }
        public double Syestr()
        {
            double res = 0;

            //Sacar la sumatoria de los elementos por estrato al cuadrado
            for (int i = 0; i < total; i++)
            {
                ele = 0;
                while (estratos[i, ele] != 0 && (ele < 20))
                {
                    Sn[i] = Math.Pow(estratos[i, ele], 2) + Sn[i];
                    ele++;
                }
            }
            for (int i = 0; i < total; i++)
            {
                double ys2 = Math.Pow(ys[i], 2);
                double numerador = 0;
                double desRest = ns[i] * ys2;
                //Sacar la varianza de cada estrato
                numerador = Sn[i] - desRest;
                Sn[i] = numerador / (ns[i] - 1);
                //Sacar la varianza total
                res = ((Math.Pow((Ns[i] / N), 2)) * ((Ns[i] - ns[i]) / Ns[i]) * (Sn[i] / ns[i])) + res;
            }
            res = Math.Sqrt(res);
            syestrN = res;
            res = Math.Round(res, 4);
            return res;
        }
        public string intervaloYestr()
        {
            string inter = "";
            double a = 0, b = 0;
            a = yestrN - (Z * syestrN);
            a = Math.Round(a, 4);
            b = yestrN + (Z * syestrN);
            b = Math.Round(b, 4);
            inter = a.ToString() + " <Mestr< " + b.ToString();
            return inter;
        }
        public string intervaloTgorro()
        {
            string inter = "";
            double a = 0, b = 0;
            a =tgorritop - (N * (Z * syestrN));
            a = Math.Round(a, 4);
            b = tgorritop + (N * (Z * syestrN));
            b = Math.Round(b, 4);
            inter = a.ToString() + " <T< " + b.ToString();
            return inter;
        }
        public double ny()
        {
            double res = 0;
            double d = yestrN * pres;
            for (int i = 0; i < total; i++)
            {
                whSh = ((Ns[i] / N) * Sn[i]) + whSh;
            }

            res = (N * (Math.Pow(Z, 2)) * whSh) / (N * (Math.Pow(d, 2)) + whSh);
            res = Math.Round(res, 0);
            return res;
        }
        public double nT()
        {
            double res = 0;
            double d = tgorritop * pres;
            res = ((Math.Pow(N, 2)) * (Math.Pow(Z, 2)) * whSh) / (((Math.Pow(d, 2))) + (N * (Math.Pow(Z, 2)) * whSh));
            res = Math.Round(res, 0);
            return res;
        }
        public double[] asignacionM()
        {
            nyN = ny();
            nTn = nT();
            double[] n = new double[2];
            for (int i = 0; i < total; i++)
            {
                n[0] = (Ns[i] / N) * nyN;
                n[1] = (Ns[i] / N) * nTn;
            }
            n[0] = Math.Round(n[0], 4);
            n[1] = Math.Round(n[1], 4);
            return n;
        }
    }
}
