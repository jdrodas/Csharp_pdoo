namespace ex02_EmprendimientosDigitales
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
            this.textoResultadoSimulacion = new System.Windows.Forms.TextBox();
            this.botonInicioSimulacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoResultadoSimulacion
            // 
            this.textoResultadoSimulacion.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoResultadoSimulacion.Location = new System.Drawing.Point(45, 211);
            this.textoResultadoSimulacion.Multiline = true;
            this.textoResultadoSimulacion.Name = "textoResultadoSimulacion";
            this.textoResultadoSimulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoResultadoSimulacion.Size = new System.Drawing.Size(698, 185);
            this.textoResultadoSimulacion.TabIndex = 0;
            // 
            // botonInicioSimulacion
            // 
            this.botonInicioSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonInicioSimulacion.Location = new System.Drawing.Point(329, 101);
            this.botonInicioSimulacion.Name = "botonInicioSimulacion";
            this.botonInicioSimulacion.Size = new System.Drawing.Size(166, 61);
            this.botonInicioSimulacion.TabIndex = 1;
            this.botonInicioSimulacion.Text = "Inicia Simulación";
            this.botonInicioSimulacion.UseVisualStyleBackColor = true;
            this.botonInicioSimulacion.Click += new System.EventHandler(this.BotonInicioSimulacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Simulación Apoyo para Emprendimientos Creativos Digitales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado de la simulación:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonInicioSimulacion);
            this.Controls.Add(this.textoResultadoSimulacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Apoyo para Emprendimientos Creativos Digitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoResultadoSimulacion;
        private System.Windows.Forms.Button botonInicioSimulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

