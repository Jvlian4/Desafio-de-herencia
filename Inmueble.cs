using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerencia
{
    class Inmueble
    {
        //Atributos
        protected String direccion;
        protected int nroMetroCuadrado;
        protected int antiguedad;

       

        //Métodos
        public Inmueble(string direccion, int nroMetroCuadrado, int antiguedad)
        {
            this.Direccion = direccion;
            this.NroMetroCuadrado = nroMetroCuadrado;
            this.Antiguedad = antiguedad;
        }

        public string Direccion { get => direccion; set => direccion = value; }
        public int NroMetroCuadrado { get => nroMetroCuadrado; set => nroMetroCuadrado = value; }
        public int Antiguedad { get => antiguedad; set => antiguedad = value; }

        public double descuentoAntiguedad()
        {
           double descuento = 0;
            if (this.antiguedad < 15)
            {
                descuento = 0.1;
            }
            else
            {  
                if (this.antiguedad >= 15)
                {
                    descuento = 0.2;
                } 
            }

            return descuento;
        }
    }
}
