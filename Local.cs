using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Local : Inmueble
    {
        //Atributos
        private int nroVentanas;

        //Métodos 
        public Local(String direccion, int nroMetroCuadrado, int antiguedad, int nroVentanas)
           : base(direccion, nroMetroCuadrado, antiguedad)
        {
            this.NroVentanas = nroVentanas;
        }

        public int NroVentanas { get => nroVentanas; set => nroVentanas = value; }

        public double calculoDescuento()
        {
            double porcentajeDescuento = 0;

            if (this.nroVentanas <= 1)
            {
                porcentajeDescuento = 0.2;
            }

            return porcentajeDescuento;
        }

        public double calculoIncrementro()
        {
            double porcentajeIncremento = 0;

            if (this.nroVentanas > 4)
            {
                porcentajeIncremento = 0.2;
            }
            
            if (this.nroMetroCuadrado > 50)
            {
                porcentajeIncremento += 0.1;
            }

            return porcentajeIncremento;
        }

        

        
    }
}
