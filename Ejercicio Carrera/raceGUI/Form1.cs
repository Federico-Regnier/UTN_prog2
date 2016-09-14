using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using race;


namespace ejercicio2UI
{
    public partial class Form1 : Form
    {
        private Carrera miCarrera;

        public Form1()
        {
            InitializeComponent();

            // Carga del ComboBox con el enumerado eFabricante
            foreach (eFabricante item in Enum.GetValues(typeof(eFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 0;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbTipoCarrera.Items.Add("Por tiempo");
            this.cmbTipoCarrera.Items.Add("Por kilometros");
            this.cmbFabricante.SelectedIndex = 0;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            // Deshabilito los demas grupos
            this.gpbAutos.Enabled = false;
            this.gpbListaAutos.Enabled = false;
            this.gpbResultado.Enabled = false;
            this.cmbTipoCarrera.SelectedIndex = 0;

            // Datos Testing
            this.txtNombre.SelectedText = "Carrera";
            this.txtLugar.SelectedText = "Avellaneda";
            this.txtFecha.SelectedText = "13/09/16";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.miCarrera = new Carrera(this.txtNombre.Text, this.txtLugar.Text, 
                                    this.txtFecha.Text);

            this.gpbCarrera.Enabled = false;
            this.gpbAutos.Enabled = true;
            this.gpbListaAutos.Enabled = true;
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto miAuto = new Auto(this.txtPiloto.Text, (eFabricante)cmbFabricante.SelectedItem);
            this.miCarrera = this.miCarrera + miAuto;
            this.txtPiloto.Clear();
            this.listadoAutos();
            this.gpbResultado.Enabled = true;
        }

        private void listadoAutos() 
        {
            this.lsbListadoAutos.Items.Clear();
            foreach (Auto item in this.miCarrera.listaDeAutos)
            {
                this.lsbListadoAutos.Items.Add(item.DatosEnString);
            }
        }

        private void btnCorrerCarrera_Click(object sender, EventArgs e)
        {
            this.txtResultado.Clear();
            if (this.cmbTipoCarrera.Text == "Por tiempo")
            {
                this.txtResultado.Text = this.miCarrera.CorrerCarrera((Tiempo)5);
            }

            if (this.cmbTipoCarrera.Text == "Por kilometros")
            {
                this.txtResultado.Text = this.miCarrera.CorrerCarrera((Kilometros)5);
            }

        }
    }
}
