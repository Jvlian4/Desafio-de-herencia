using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Piso : Inmueble
    {
        //Atributos
        private int nroPiso;

        //Métodos
        public Piso(String direccion, int nroMetroCuadrado, int antiguedad, int nroPiso)
            : base(direccion, nroMetroCuadrado, antiguedad)
        {
            this.NroPiso = nroPiso;
        }

        public int NroPiso { get => nroPiso; set => nroPiso = value; }


        public double incremento()
        {
            double porcentajeIncremento = 0;
            if (this.nroPiso >= 3)
            {
                porcentajeIncremento = 0.3;
            }

            return porcentajeIncremento;
        }
    }
}
