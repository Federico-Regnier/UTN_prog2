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

            // Carga el comboBox Tipo de Carrera
            this.cmbTipoCarrera.Items.Add("Por tiempo");
            this.cmbTipoCarrera.Items.Add("Por kilometros");
            this.cmbFabricante.SelectedIndex = 0;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            // Deshabilito los grupos que no son Carrera
            this.gpbAutos.Enabled = false;
            this.gpbListaAutos.Enabled = false;
            this.gpbResultado.Enabled = false;
            this.cmbTipoCarrera.SelectedIndex = 0;

            // Datos Testing
            this.txtNombre.Text = "Carrera";
            this.txtLugar.Text = "Avellaneda";
            this.txtFecha.Text = "13/09/16";
            this.txtPiloto.Text = "NN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.miCarrera = new Carrera(this.txtNombre.Text, this.txtLugar.Text, 
                                    this.txtFecha.Text);

            // Deshabilita el Crear carrera y habilita el agregado de autos
            this.gpbCarrera.Enabled = false;
            this.gpbAutos.Enabled = true;
            this.txtResultado.Clear();
            this.lsbListadoAutos.Items.Clear();
            this.gpbListaAutos.Enabled = true;
            this.lblGanador.Text = "Ganador";
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            Auto miAuto = new Auto(this.txtPiloto.Text, (eFabricante)cmbFabricante.SelectedItem);
            this.miCarrera = this.miCarrera + miAuto;
            this.txtPiloto.Clear();
            this.listadoAutos();

            // Habilito el groupBox Resultado y el boton Correr Carrera
            this.gpbResultado.Enabled = true;
            this.btnCorrerCarrera.Enabled = true;
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
            StringBuilder info = new StringBuilder();

            info.AppendLine(this.miCarrera.nombre + " " + this.miCarrera.lugar + " " + this.miCarrera.fecha);
            this.lblGanador.Text = info.ToString();

            info.Clear();
            info.AppendLine("\t" + " Ganador");

            if (this.cmbTipoCarrera.Text == "Por tiempo")
                info.AppendLine(this.miCarrera.CorrerCarrera((Tiempo) this.nmrCantidadCarrera.Value));
            else
                info.AppendLine(this.miCarrera.CorrerCarrera((Kilometros) this.nmrCantidadCarrera.Value));
            

            this.txtResultado.Text = info.ToString();
            
            // Deshabilito el boton correrCarrera y agregar autos
            this.btnCorrerCarrera.Enabled = false;
            this.limpiarFormulario();
            this.gpbAutos.Enabled = false;
            this.gpbCarrera.Enabled = true;
            
            
        }

        // Limpia los textBox del formulario (salvo ListaAutos y Resultado)
        private void limpiarFormulario()
        {
            this.txtNombre.Clear();
            this.txtLugar.Clear();
            this.txtFecha.Clear();
        }
    }
}
