using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            float precio1;
            float precio2;
            float precio3;
            
            precio1 = float.Parse(this.txtPrecio1.Text);
            precio2 = float.Parse(this.txtPrecio2.Text);
            precio3 = float.Parse(this.txtPrecio3.Text);
            MessageBox.Show((precio1 + precio2 + precio3).ToString("0.00"));
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            float precio1;
            float precio2;
            float precio3;
            float promedio;

            precio1 = float.Parse(this.txtPrecio1.Text);
            precio2 = float.Parse(this.txtPrecio2.Text);
            precio3 = float.Parse(this.txtPrecio3.Text);
            promedio = (precio1 + precio2 + precio3) / 3;
            MessageBox.Show(promedio.ToString("0.00"));
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            float precio1;
            float precio2;
            float precio3;
            float precioFinal;

            precio1 = float.Parse(this.txtPrecio1.Text);
            precio2 = float.Parse(this.txtPrecio2.Text);
            precio3 = float.Parse(this.txtPrecio3.Text);
            precioFinal = (precio1 + precio2 + precio3) * (float)1.21;

            MessageBox.Show(precioFinal.ToString("0.00"));
        }
    }
}
