namespace ejercicio2UI
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
            this.btnCarrera = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.txtPiloto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.nmrCantidadCarrera = new System.Windows.Forms.NumericUpDown();
            this.lblGanador = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.cmbTipoCarrera = new System.Windows.Forms.ComboBox();
            this.gpbListaAutos = new System.Windows.Forms.GroupBox();
            this.lsbListadoAutos = new System.Windows.Forms.ListBox();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidadCarrera)).BeginInit();
            this.gpbListaAutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarrera
            // 
            this.btnCarrera.Location = new System.Drawing.Point(502, 26);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(86, 36);
            this.btnCarrera.TabIndex = 0;
            this.btnCarrera.Text = "Crear Carrera";
            this.btnCarrera.UseVisualStyleBackColor = true;
            this.btnCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.btnCarrera);
            this.gpbCarrera.Location = new System.Drawing.Point(12, 12);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(595, 82);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(325, 19);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(328, 35);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(137, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(166, 19);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 4;
            this.lblLugar.Text = "Lugar";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(169, 35);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(137, 20);
            this.txtLugar.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(9, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Controls.Add(this.lblPiloto);
            this.gpbAutos.Controls.Add(this.txtPiloto);
            this.gpbAutos.Controls.Add(this.label1);
            this.gpbAutos.Location = new System.Drawing.Point(12, 100);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(300, 158);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(6, 37);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(148, 21);
            this.cmbFabricante.TabIndex = 5;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(6, 103);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(130, 32);
            this.btnAgregarAuto.TabIndex = 4;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Location = new System.Drawing.Point(6, 61);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(33, 13);
            this.lblPiloto.TabIndex = 3;
            this.lblPiloto.Text = "Piloto";
            // 
            // txtPiloto
            // 
            this.txtPiloto.Location = new System.Drawing.Point(6, 77);
            this.txtPiloto.Name = "txtPiloto";
            this.txtPiloto.Size = new System.Drawing.Size(149, 20);
            this.txtPiloto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fabricante";
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.nmrCantidadCarrera);
            this.gpbResultado.Controls.Add(this.lblGanador);
            this.gpbResultado.Controls.Add(this.txtResultado);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Controls.Add(this.cmbTipoCarrera);
            this.gpbResultado.Location = new System.Drawing.Point(12, 264);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(300, 195);
            this.gpbResultado.TabIndex = 3;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // nmrCantidadCarrera
            // 
            this.nmrCantidadCarrera.Location = new System.Drawing.Point(6, 18);
            this.nmrCantidadCarrera.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmrCantidadCarrera.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrCantidadCarrera.Name = "nmrCantidadCarrera";
            this.nmrCantidadCarrera.Size = new System.Drawing.Size(48, 20);
            this.nmrCantidadCarrera.TabIndex = 5;
            this.nmrCantidadCarrera.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Location = new System.Drawing.Point(6, 70);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(48, 13);
            this.lblGanador.TabIndex = 4;
            this.lblGanador.Text = "Ganador";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 86);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(155, 100);
            this.txtResultado.TabIndex = 2;
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(169, 18);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(125, 47);
            this.btnCorrerCarrera.TabIndex = 1;
            this.btnCorrerCarrera.Text = "Correr Carrera";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // cmbTipoCarrera
            // 
            this.cmbTipoCarrera.FormattingEnabled = true;
            this.cmbTipoCarrera.Location = new System.Drawing.Point(6, 44);
            this.cmbTipoCarrera.Name = "cmbTipoCarrera";
            this.cmbTipoCarrera.Size = new System.Drawing.Size(155, 21);
            this.cmbTipoCarrera.TabIndex = 0;
            // 
            // gpbListaAutos
            // 
            this.gpbListaAutos.Controls.Add(this.lsbListadoAutos);
            this.gpbListaAutos.Location = new System.Drawing.Point(318, 100);
            this.gpbListaAutos.Name = "gpbListaAutos";
            this.gpbListaAutos.Size = new System.Drawing.Size(289, 359);
            this.gpbListaAutos.TabIndex = 4;
            this.gpbListaAutos.TabStop = false;
            this.gpbListaAutos.Text = "Lista de Autos";
            // 
            // lsbListadoAutos
            // 
            this.lsbListadoAutos.FormattingEnabled = true;
            this.lsbListadoAutos.Location = new System.Drawing.Point(6, 21);
            this.lsbListadoAutos.Name = "lsbListadoAutos";
            this.lsbListadoAutos.Size = new System.Drawing.Size(275, 316);
            this.lsbListadoAutos.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 471);
            this.Controls.Add(this.gpbListaAutos);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrCantidadCarrera)).EndInit();
            this.gpbListaAutos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbListaAutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.TextBox txtPiloto;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lsbListadoAutos;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.ComboBox cmbTipoCarrera;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.NumericUpDown nmrCantidadCarrera;
    }
}

