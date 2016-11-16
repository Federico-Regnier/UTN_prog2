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
    public partial class Form3 : Form
    {
        private Thread _miHilo;
        public Form3()
        {
            InitializeComponent();
            this.btnPausar.Click += new EventHandler(this.Pausar);
            this.btnDestruir.Click += new EventHandler(this.DestruirPelotita);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_con_thread.Pelotita p = new Pelotita_con_thread.Pelotita(this.pictureBox1);
            this._miHilo = new Thread(p.DoWork);
            this._miHilo.Start();

            this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
            
        }

        public void Pausar(object sender, EventArgs e)
        {
            if(this._miHilo.IsAlive)
                this._miHilo.Suspend();
        }

        public void DestruirPelotita(object sender, EventArgs e)
        {
            this._miHilo.Abort();
            Graphics g = this.pictureBox1.CreateGraphics();
            g.Clear(this.pictureBox1.BackColor);
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            if(this._miHilo.ThreadState == ThreadState.Suspended) 
                this._miHilo.Resume();
            
        }
    }
}
