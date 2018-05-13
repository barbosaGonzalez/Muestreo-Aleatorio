using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muestreo_Aleatorio
{
    class MEP
    {
        //Valores
        #region Valores

        private double _tamanoMuestra;
        public double tamanoMuestra
        {
            get { return _tamanoMuestra; }
            set { _tamanoMuestra = value; }
        }

        private double _tamanoPoblacion;
        public double tamanoPoblacion
        {
            get { return _tamanoPoblacion; }
            set { _tamanoPoblacion = value; }
        }
        private float _resultadoPestr;
        public float resultadoPestr
        {
            get { return _resultadoPestr; }
            set { value = _resultadoPestr; }
        }

        private float _Tgorrito;
        public float Tgorrito
        {
            get { return _Tgorrito; }
            set { _Tgorrito = value; }
        }

        private float _DesviacionEstandar;
        public float DesviacionEstandar
        {
            get { return _DesviacionEstandar; }
            set { _DesviacionEstandar = value; }
        }

        private float _Varianza;
        public float Varianza
        {
            get { return _Varianza; }
            set { _Varianza = value; }
        }

        private float[] _IntervaloPest = new float[2];
        public float[] IntervaloPest
        {
            get { return _IntervaloPest; }
            set { _IntervaloPest = value; }
        }

        private float[] _IntervaloTGorrito = new float[2];
        public float[] IntervaloTgorrito
        {
            get { return _IntervaloTGorrito; }
            set { _IntervaloTGorrito = value; }
        }
        #endregion

        #region CosasExtra

        private double _Z;
        public double Z
        {
            get { return _Z; }
            set { _Z = value; }
        }
        private int _totalEstratos;
        public int totalEstratos
        {
            get { return _totalEstratos; }
            set { _totalEstratos = value; }
        }

        private float _totalPoblacion = 0;
        public float totalPoblacion
        {
            get { return _totalPoblacion; }
            set { _totalPoblacion = value; }
        }

        private float _totalMuestra = 0;
        public float totalMuestra
        {
            get { return _totalMuestra; }
            set { _totalMuestra = value; }
        }

        private double _presicion = 0;
        public double presicion
        {
            get { return _presicion; }
            set { _presicion = value; }
        }

        private float[,] _datosEstrato = new float[20, 3];
        public float[,] datosEstrato
        {
            get { return _datosEstrato; }
            set { _datosEstrato = value; }
        }

        #endregion

        public MEP()
        {
            _Z = 1.96;
        }
        public void agregarDatos(float totalPoblacion, float totalPoblacionEstratoN, float totalMuestraEstratoN, float totalProporcionEstratoN, float totalMuestra, double Z, double pres)
        {
            _Z = Z;
            _totalPoblacion = totalPoblacion;
            _totalMuestra = totalMuestra;
            _presicion = (pres/100);
            _datosEstrato[_totalEstratos, 0] = totalPoblacionEstratoN;
            _datosEstrato[_totalEstratos, 1] = totalMuestraEstratoN;
            _datosEstrato[_totalEstratos, 2] = totalProporcionEstratoN;
            _totalEstratos++;
        }

        //Matriz
        // Primer Columna = TOTAL POBLACION ESTRATO 
        // Segunda Columna = TOTAL MUESTRA ESTRATO 
        // Tercer Columna = TOTAL PROPORCION ESTRATO 
        public void CalcularPestr()
        {
            for (int i = 0; i < _totalEstratos; i++)
            {
                _resultadoPestr += ((_datosEstrato[i, 2] / _datosEstrato[i, 1])) * _datosEstrato[i, 0];
            }
            _resultadoPestr = (1 / _totalPoblacion) * resultadoPestr;
        }

        public void CalcularTgorrito()
        {
            _Tgorrito = _totalPoblacion * _resultadoPestr;
        }

        public void CalcularDesviacionEstandar()
        {
            for (int i = 0; i < _totalEstratos; i++)
            {
                _DesviacionEstandar += ((_datosEstrato[i, 0] - _datosEstrato[i, 1]) / _datosEstrato[i, 0]) * ((_datosEstrato[i, 2] / _datosEstrato[i, 1]) * (1 - (_datosEstrato[i, 2] / _datosEstrato[i, 1])) / _datosEstrato[i, 1]) * (_datosEstrato[i, 0] * _datosEstrato[i, 0]);
            }
            _DesviacionEstandar = (1 / (_totalPoblacion * _totalPoblacion)) * _DesviacionEstandar;
        }

        public void CalcularVarianza()
        {
            _Varianza = float.Parse(Math.Sqrt(Convert.ToDouble(_DesviacionEstandar)).ToString());
        }

        public void calcularIntervaloPest()
        {
            _IntervaloPest[0] = _resultadoPestr - ((Convert.ToInt64(_Z) * _Varianza));
            _IntervaloPest[1] = _resultadoPestr + ((Convert.ToInt64(_Z) * _Varianza));
        }

        public void calcularIntervaloTGorrito()
        {
            _IntervaloTGorrito[0] = _Tgorrito - ((_totalPoblacion) * (Convert.ToInt64(_Z) * _Varianza));
            _IntervaloTGorrito[1] = _Tgorrito + ((_totalPoblacion) * (Convert.ToInt64(_Z) * _Varianza));
        }

        public void calcularTamañoMuestraMedia()
        {
            float WhSh = 0;
            double Zcuadrado = _Z * _Z;
            double D = (_presicion * _resultadoPestr);
            D = Math.Pow(D, 2);
            //Calcular WhSh
            for (int i = 0; i < _totalEstratos; i++)
            {
                WhSh += ((_datosEstrato[i, 0] / _totalPoblacion) * ((_datosEstrato[i, 2] / _datosEstrato[i, 1]) * (1 - (_datosEstrato[i, 2] / _datosEstrato[i, 1]))));
            }
            _tamanoMuestra = (_totalPoblacion * D) + (Zcuadrado * WhSh);
            _tamanoMuestra = ((_totalPoblacion) * (Zcuadrado) * (WhSh)) / _tamanoMuestra;
            _tamanoMuestra = Math.Round(_tamanoMuestra, 0);
        }

        public void calcularTamañoPoblacion()
        {
            float WhSh = 0;
            double Zcuadrado = _Z * _Z;
            double D = (_presicion * _Tgorrito);
            D = Math.Pow(D, 2);
            //Calcular WhSh
            for (int i = 0; i < _totalEstratos; i++)
            {
                WhSh += ((_datosEstrato[i, 0] / _totalPoblacion) * ((_datosEstrato[i, 2] / _datosEstrato[i, 1]) * (1 - (_datosEstrato[i, 2] / _datosEstrato[i, 1]))));
            }
            _tamanoPoblacion = D + (_totalPoblacion) * (Zcuadrado * WhSh);
            _tamanoPoblacion = ((_totalPoblacion * _totalPoblacion)) * (Zcuadrado) * WhSh / _tamanoPoblacion;
            _tamanoPoblacion = Math.Round(_tamanoPoblacion, 0);
        }


    }
}
