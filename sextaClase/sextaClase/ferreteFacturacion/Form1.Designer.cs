namespace ferreteFacturacion
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
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.txtPrecio3 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(16, 24);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(93, 20);
            this.txtPrecio1.TabIndex = 0;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(16, 50);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(93, 20);
            this.txtPrecio2.TabIndex = 1;
            // 
            // txtPrecio3
            // 
            this.txtPrecio3.Location = new System.Drawing.Point(16, 76);
            this.txtPrecio3.Name = "txtPrecio3";
            this.txtPrecio3.Size = new System.Drawing.Size(93, 20);
            this.txtPrecio3.TabIndex = 2;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(16, 155);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(103, 29);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(16, 190);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(101, 27);
            this.btnPromedio.TabIndex = 4;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(16, 223);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(97, 27);
            this.btnPrecioFinal.TabIndex = 5;
            this.btnPrecioFinal.Text = "Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtPrecio3);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.txtPrecio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.TextBox txtPrecio3;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
    }
}

