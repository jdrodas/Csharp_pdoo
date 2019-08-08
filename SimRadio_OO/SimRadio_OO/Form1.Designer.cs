namespace SimRadio_OO
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LabelFrecuencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelVolumen = new System.Windows.Forms.Label();
            this.BotonEstado = new System.Windows.Forms.Button();
            this.BotonFmas = new System.Windows.Forms.Button();
            this.BotonFmenos = new System.Windows.Forms.Button();
            this.BotonVmas = new System.Windows.Forms.Button();
            this.BotonVmenos = new System.Windows.Forms.Button();
            this.TrackVolumen = new System.Windows.Forms.TrackBar();
            this.TrackFrecuencia = new System.Windows.Forms.TrackBar();
            this.grupoMemoriaFrecuencias = new System.Windows.Forms.GroupBox();
            this.botonAccionMemoria = new System.Windows.Forms.Button();
            this.botonM1 = new System.Windows.Forms.Button();
            this.botonM2 = new System.Windows.Forms.Button();
            this.botonM3 = new System.Windows.Forms.Button();
            this.botonM4 = new System.Windows.Forms.Button();
            this.BotonM5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackFrecuencia)).BeginInit();
            this.grupoMemoriaFrecuencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulador de Radio - OO";
            // 
            // LabelFrecuencia
            // 
            this.LabelFrecuencia.BackColor = System.Drawing.Color.Black;
            this.LabelFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFrecuencia.ForeColor = System.Drawing.Color.Yellow;
            this.LabelFrecuencia.Location = new System.Drawing.Point(23, 91);
            this.LabelFrecuencia.Name = "LabelFrecuencia";
            this.LabelFrecuencia.Size = new System.Drawing.Size(342, 73);
            this.LabelFrecuencia.TabIndex = 1;
            this.LabelFrecuencia.Text = "000.0 MHz";
            this.LabelFrecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Frecuencia actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Volumen:";
            // 
            // LabelVolumen
            // 
            this.LabelVolumen.BackColor = System.Drawing.Color.Black;
            this.LabelVolumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVolumen.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelVolumen.Location = new System.Drawing.Point(429, 91);
            this.LabelVolumen.Name = "LabelVolumen";
            this.LabelVolumen.Size = new System.Drawing.Size(104, 73);
            this.LabelVolumen.TabIndex = 4;
            this.LabelVolumen.Text = "00";
            this.LabelVolumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BotonEstado
            // 
            this.BotonEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonEstado.Location = new System.Drawing.Point(442, 20);
            this.BotonEstado.Name = "BotonEstado";
            this.BotonEstado.Size = new System.Drawing.Size(136, 40);
            this.BotonEstado.TabIndex = 5;
            this.BotonEstado.Text = "Encendido / Apagado";
            this.BotonEstado.UseVisualStyleBackColor = true;
            this.BotonEstado.Click += new System.EventHandler(this.BotonEstado_Click);
            // 
            // BotonFmas
            // 
            this.BotonFmas.Location = new System.Drawing.Point(371, 91);
            this.BotonFmas.Name = "BotonFmas";
            this.BotonFmas.Size = new System.Drawing.Size(37, 23);
            this.BotonFmas.TabIndex = 6;
            this.BotonFmas.Text = "F+";
            this.BotonFmas.UseVisualStyleBackColor = true;
            this.BotonFmas.Click += new System.EventHandler(this.BotonFmas_Click);
            // 
            // BotonFmenos
            // 
            this.BotonFmenos.Location = new System.Drawing.Point(371, 141);
            this.BotonFmenos.Name = "BotonFmenos";
            this.BotonFmenos.Size = new System.Drawing.Size(37, 23);
            this.BotonFmenos.TabIndex = 7;
            this.BotonFmenos.Text = "F-";
            this.BotonFmenos.UseVisualStyleBackColor = true;
            this.BotonFmenos.Click += new System.EventHandler(this.BotonFmenos_Click);
            // 
            // BotonVmas
            // 
            this.BotonVmas.Location = new System.Drawing.Point(541, 91);
            this.BotonVmas.Name = "BotonVmas";
            this.BotonVmas.Size = new System.Drawing.Size(37, 23);
            this.BotonVmas.TabIndex = 8;
            this.BotonVmas.Text = "V+";
            this.BotonVmas.UseVisualStyleBackColor = true;
            this.BotonVmas.Click += new System.EventHandler(this.BotonVmas_Click);
            // 
            // BotonVmenos
            // 
            this.BotonVmenos.Location = new System.Drawing.Point(541, 141);
            this.BotonVmenos.Name = "BotonVmenos";
            this.BotonVmenos.Size = new System.Drawing.Size(37, 23);
            this.BotonVmenos.TabIndex = 9;
            this.BotonVmenos.Text = "V-";
            this.BotonVmenos.UseVisualStyleBackColor = true;
            this.BotonVmenos.Click += new System.EventHandler(this.BotonVmenos_Click);
            // 
            // TrackVolumen
            // 
            this.TrackVolumen.Location = new System.Drawing.Point(424, 178);
            this.TrackVolumen.Name = "TrackVolumen";
            this.TrackVolumen.Size = new System.Drawing.Size(104, 45);
            this.TrackVolumen.TabIndex = 11;
            this.TrackVolumen.Scroll += new System.EventHandler(this.TrackVolumen_Scroll);
            // 
            // TrackFrecuencia
            // 
            this.TrackFrecuencia.LargeChange = 10;
            this.TrackFrecuencia.Location = new System.Drawing.Point(24, 178);
            this.TrackFrecuencia.Maximum = 1079;
            this.TrackFrecuencia.Minimum = 889;
            this.TrackFrecuencia.Name = "TrackFrecuencia";
            this.TrackFrecuencia.Size = new System.Drawing.Size(341, 45);
            this.TrackFrecuencia.SmallChange = 10;
            this.TrackFrecuencia.TabIndex = 12;
            this.TrackFrecuencia.TickFrequency = 10;
            this.TrackFrecuencia.Value = 889;
            this.TrackFrecuencia.Scroll += new System.EventHandler(this.TrackFrecuencia_Scroll);
            // 
            // grupoMemoriaFrecuencias
            // 
            this.grupoMemoriaFrecuencias.Controls.Add(this.BotonM5);
            this.grupoMemoriaFrecuencias.Controls.Add(this.botonM4);
            this.grupoMemoriaFrecuencias.Controls.Add(this.botonM3);
            this.grupoMemoriaFrecuencias.Controls.Add(this.botonM2);
            this.grupoMemoriaFrecuencias.Controls.Add(this.botonM1);
            this.grupoMemoriaFrecuencias.Controls.Add(this.botonAccionMemoria);
            this.grupoMemoriaFrecuencias.Location = new System.Drawing.Point(125, 229);
            this.grupoMemoriaFrecuencias.Name = "grupoMemoriaFrecuencias";
            this.grupoMemoriaFrecuencias.Size = new System.Drawing.Size(341, 99);
            this.grupoMemoriaFrecuencias.TabIndex = 13;
            this.grupoMemoriaFrecuencias.TabStop = false;
            this.grupoMemoriaFrecuencias.Text = "Memorias de frecuencias:";
            // 
            // botonAccionMemoria
            // 
            this.botonAccionMemoria.Location = new System.Drawing.Point(12, 31);
            this.botonAccionMemoria.Name = "botonAccionMemoria";
            this.botonAccionMemoria.Size = new System.Drawing.Size(86, 47);
            this.botonAccionMemoria.TabIndex = 0;
            this.botonAccionMemoria.Text = "Leyendo / Almacenando";
            this.botonAccionMemoria.UseVisualStyleBackColor = true;
            this.botonAccionMemoria.Click += new System.EventHandler(this.BotonAccionMemoria_Click);
            // 
            // botonM1
            // 
            this.botonM1.Location = new System.Drawing.Point(114, 43);
            this.botonM1.Name = "botonM1";
            this.botonM1.Size = new System.Drawing.Size(37, 23);
            this.botonM1.TabIndex = 14;
            this.botonM1.Text = "M1";
            this.botonM1.UseVisualStyleBackColor = true;
            this.botonM1.Click += new System.EventHandler(this.BotonM1_Click);
            // 
            // botonM2
            // 
            this.botonM2.Location = new System.Drawing.Point(157, 43);
            this.botonM2.Name = "botonM2";
            this.botonM2.Size = new System.Drawing.Size(37, 23);
            this.botonM2.TabIndex = 15;
            this.botonM2.Text = "M2";
            this.botonM2.UseVisualStyleBackColor = true;
            this.botonM2.Click += new System.EventHandler(this.BotonM2_Click);
            // 
            // botonM3
            // 
            this.botonM3.Location = new System.Drawing.Point(200, 43);
            this.botonM3.Name = "botonM3";
            this.botonM3.Size = new System.Drawing.Size(37, 23);
            this.botonM3.TabIndex = 16;
            this.botonM3.Text = "M3";
            this.botonM3.UseVisualStyleBackColor = true;
            this.botonM3.Click += new System.EventHandler(this.BotonM3_Click);
            // 
            // botonM4
            // 
            this.botonM4.Location = new System.Drawing.Point(243, 43);
            this.botonM4.Name = "botonM4";
            this.botonM4.Size = new System.Drawing.Size(37, 23);
            this.botonM4.TabIndex = 17;
            this.botonM4.Text = "M4";
            this.botonM4.UseVisualStyleBackColor = true;
            this.botonM4.Click += new System.EventHandler(this.BotonM4_Click);
            // 
            // BotonM5
            // 
            this.BotonM5.Location = new System.Drawing.Point(286, 43);
            this.BotonM5.Name = "BotonM5";
            this.BotonM5.Size = new System.Drawing.Size(37, 23);
            this.BotonM5.TabIndex = 18;
            this.BotonM5.Text = "M5";
            this.BotonM5.UseVisualStyleBackColor = true;
            this.BotonM5.Click += new System.EventHandler(this.BotonM5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 352);
            this.Controls.Add(this.grupoMemoriaFrecuencias);
            this.Controls.Add(this.TrackFrecuencia);
            this.Controls.Add(this.TrackVolumen);
            this.Controls.Add(this.BotonVmenos);
            this.Controls.Add(this.BotonVmas);
            this.Controls.Add(this.BotonFmenos);
            this.Controls.Add(this.BotonFmas);
            this.Controls.Add(this.BotonEstado);
            this.Controls.Add(this.LabelVolumen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelFrecuencia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador de Radio - OO";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackVolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackFrecuencia)).EndInit();
            this.grupoMemoriaFrecuencias.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelFrecuencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelVolumen;
        private System.Windows.Forms.Button BotonEstado;
        private System.Windows.Forms.Button BotonFmas;
        private System.Windows.Forms.Button BotonFmenos;
        private System.Windows.Forms.Button BotonVmas;
        private System.Windows.Forms.Button BotonVmenos;
        private System.Windows.Forms.TrackBar TrackVolumen;
        private System.Windows.Forms.TrackBar TrackFrecuencia;
        private System.Windows.Forms.GroupBox grupoMemoriaFrecuencias;
        private System.Windows.Forms.Button botonAccionMemoria;
        private System.Windows.Forms.Button BotonM5;
        private System.Windows.Forms.Button botonM4;
        private System.Windows.Forms.Button botonM3;
        private System.Windows.Forms.Button botonM2;
        private System.Windows.Forms.Button botonM1;
    }
}

