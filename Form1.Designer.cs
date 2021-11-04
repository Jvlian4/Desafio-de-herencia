
namespace DesafioHerencia
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNroVentanas = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVentana = new System.Windows.Forms.RadioButton();
            this.btnPiso = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSuperficie = new System.Windows.Forms.TextBox();
            this.txtAntiguedad = new System.Windows.Forms.TextBox();
            this.txtPrecioBase = new System.Windows.Forms.TextBox();
            this.btnObtenerPrecio = new System.Windows.Forms.Button();
            this.lblMontoFinal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNroVentanas);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnVentana);
            this.groupBox1.Controls.Add(this.btnPiso);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inmueble";
            // 
            // txtNroVentanas
            // 
            this.txtNroVentanas.Location = new System.Drawing.Point(257, 108);
            this.txtNroVentanas.Name = "txtNroVentanas";
            this.txtNroVentanas.Size = new System.Drawing.Size(100, 20);
            this.txtNroVentanas.TabIndex = 5;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(17, 108);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(100, 20);
            this.txtPiso.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de ventanas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de piso";
            // 
            // btnVentana
            // 
            this.btnVentana.AutoSize = true;
            this.btnVentana.Location = new System.Drawing.Point(257, 42);
            this.btnVentana.Name = "btnVentana";
            this.btnVentana.Size = new System.Drawing.Size(73, 17);
            this.btnVentana.TabIndex = 1;
            this.btnVentana.TabStop = true;
            this.btnVentana.Text = "Ventanas ";
            this.btnVentana.UseVisualStyleBackColor = true;
            this.btnVentana.CheckedChanged += new System.EventHandler(this.btnVentana_CheckedChanged);
            // 
            // btnPiso
            // 
            this.btnPiso.AutoSize = true;
            this.btnPiso.Location = new System.Drawing.Point(17, 42);
            this.btnPiso.Name = "btnPiso";
            this.btnPiso.Size = new System.Drawing.Size(48, 17);
            this.btnPiso.TabIndex = 0;
            this.btnPiso.TabStop = true;
            this.btnPiso.Text = "Piso ";
            this.btnPiso.UseVisualStyleBackColor = true;
            this.btnPiso.CheckedChanged += new System.EventHandler(this.btnPiso_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(29, 217);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 20);
            this.txtDireccion.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Superficie (m2)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Años de antigüedad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio base";
            // 
            // txtSuperficie
            // 
            this.txtSuperficie.Location = new System.Drawing.Point(29, 347);
            this.txtSuperficie.Name = "txtSuperficie";
            this.txtSuperficie.Size = new System.Drawing.Size(100, 20);
            this.txtSuperficie.TabIndex = 9;
            // 
            // txtAntiguedad
            // 
            this.txtAntiguedad.Location = new System.Drawing.Point(157, 347);
            this.txtAntiguedad.Name = "txtAntiguedad";
            this.txtAntiguedad.Size = new System.Drawing.Size(100, 20);
            this.txtAntiguedad.TabIndex = 10;
            // 
            // txtPrecioBase
            // 
            this.txtPrecioBase.Location = new System.Drawing.Point(317, 347);
            this.txtPrecioBase.Name = "txtPrecioBase";
            this.txtPrecioBase.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioBase.TabIndex = 11;
            // 
            // btnObtenerPrecio
            // 
            this.btnObtenerPrecio.Location = new System.Drawing.Point(94, 390);
            this.btnObtenerPrecio.Name = "btnObtenerPrecio";
            this.btnObtenerPrecio.Size = new System.Drawing.Size(230, 52);
            this.btnObtenerPrecio.TabIndex = 12;
            this.btnObtenerPrecio.Text = "Calcular precio";
            this.btnObtenerPrecio.UseVisualStyleBackColor = true;
            this.btnObtenerPrecio.Click += new System.EventHandler(this.btnObtenerPrecio_Click);
            // 
            // lblMontoFinal
            // 
            this.lblMontoFinal.AutoSize = true;
            this.lblMontoFinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMontoFinal.Location = new System.Drawing.Point(154, 469);
            this.lblMontoFinal.Name = "lblMontoFinal";
            this.lblMontoFinal.Size = new System.Drawing.Size(0, 13);
            this.lblMontoFinal.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 515);
            this.Controls.Add(this.lblMontoFinal);
            this.Controls.Add(this.btnObtenerPrecio);
            this.Controls.Add(this.txtPrecioBase);
            this.Controls.Add(this.txtAntiguedad);
            this.Controls.Add(this.txtSuperficie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNroVentanas;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton btnVentana;
        private System.Windows.Forms.RadioButton btnPiso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSuperficie;
        private System.Windows.Forms.TextBox txtAntiguedad;
        private System.Windows.Forms.TextBox txtPrecioBase;
        private System.Windows.Forms.Button btnObtenerPrecio;
        private System.Windows.Forms.Label lblMontoFinal;
    }
}

