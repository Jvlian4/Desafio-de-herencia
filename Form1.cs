using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioHerencia
{
    public partial class Form1 : Form
    {
        Boolean banderaPiso = false;
        Boolean banderaLocal = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnPiso_CheckedChanged(object sender, EventArgs e)
        {
            //Banderas
            banderaPiso = true;
            banderaLocal = false;

            txtPiso.Enabled = true;
            txtNroVentanas.Enabled = false;     
        }

        private void btnVentana_CheckedChanged(object sender, EventArgs e)
        {
            //Banderas
            banderaLocal = true;
            banderaPiso = false;

            txtPiso.Enabled = false;
            txtNroVentanas.Enabled = true;
        }

        private void btnObtenerPrecio_Click(object sender, EventArgs e)
        {
            double precioBase = (Convert.ToDouble(txtPrecioBase.Text));
            double porcentajeIncremento = 0;
            double porcentajeDescuento = 0;
            double precioFinal = 0;
            
            if(banderaPiso == true)
            {
                Piso piso1 = new Piso(txtDireccion.Text, (Convert.ToInt32(txtSuperficie.Text)), (Convert.ToInt32(txtAntiguedad.Text)), (Convert.ToInt32(txtPiso.Text)));

                porcentajeDescuento = piso1.descuentoAntiguedad();
                porcentajeIncremento = piso1.incremento();

                precioFinal = precioBase - (precioBase * porcentajeDescuento); //Aplico el descuento por "inmueble" al precio final. Falta aún agregar el incremento si es que existe
                precioFinal = precioFinal + (precioBase * porcentajeIncremento);//Obtengo el precio final aplicando el aumento por "piso"

                lblMontoFinal.Text = "El precio final es " + precioFinal;
            }
            else
                if (banderaLocal == true)
            {
                Local local1 = new Local (txtDireccion.Text, (Convert.ToInt32(txtSuperficie.Text)), (Convert.ToInt32(txtAntiguedad.Text)), (Convert.ToInt32(txtNroVentanas.Text)));

                porcentajeDescuento = local1.calculoDescuento();
                porcentajeIncremento = local1.calculoIncrementro();
                porcentajeDescuento += local1.descuentoAntiguedad();

                precioFinal = precioBase - (precioBase * porcentajeDescuento);//Ver línea 59
                precioFinal = precioFinal + (precioBase * porcentajeIncremento);//Ver línea 60

                lblMontoFinal.Text = "El precio final es $" + precioFinal;

            }
            
        }
    }
}
