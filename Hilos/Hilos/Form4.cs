using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos
{
    public partial class Form4 : Form
    {
        private List<Thread> _listaHilos;
        private int _contadorPelotitas;
        
        public Form4()
        {
            InitializeComponent();
            this._listaHilos = new List<Thread>();
            this._contadorPelotitas = 0;
            this.lblPelotitas.Text = this._contadorPelotitas.ToString();
            this.btnCrear.Click += new EventHandler(this.CrearPelotita);
            this.btnPausar.Click += new EventHandler(this.PausarPelotitas);
            this.btnReanudar.Click += new EventHandler(this.ReanudarPelotitas);
            this.btnDestruir.Click += new EventHandler(this.DestruirUltimaPelotita);
        }

        private void PausarPelotitas(object sender, EventArgs e)
        {
            try
            {
                foreach (Thread item in this._listaHilos)
                {
                    item.Suspend();
                }
            }
            catch (Exception) {}

        }

        private void CrearPelotita(object sender, EventArgs e)
        {
            Pelotita_con_thread.Pelotita p = new Pelotita_con_thread.Pelotita(this.pictureBox1);
            
            Thread hilo = new Thread(p.DoWork);
            this._listaHilos.Add(hilo);
            this._contadorPelotitas++;
            this.lblPelotitas.Text = this._contadorPelotitas.ToString();
            hilo.Start();
        }

        private void ReanudarPelotitas(object sender, EventArgs e)
        {
            try
            {
                foreach (Thread item in this._listaHilos)
                {
                    item.Resume();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void DestruirUltimaPelotita(object sender, EventArgs e)
        {
            try
            {
                this._listaHilos[this._listaHilos.Count - 1].Abort();
                this._listaHilos.RemoveAt(this._listaHilos.Count - 1);
                this._contadorPelotitas--;

                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
                this.lblPelotitas.Text = this._contadorPelotitas.ToString();
            }
            catch (Exception)
            { }
        }
    }
}
