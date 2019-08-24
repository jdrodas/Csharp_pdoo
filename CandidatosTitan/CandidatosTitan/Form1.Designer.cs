namespace CandidatosTitan
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
            this.botonInicio = new System.Windows.Forms.Button();
            this.textoInformacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simulación Candidatos a Titán";
            // 
            // botonInicio
            // 
            this.botonInicio.Location = new System.Drawing.Point(460, 88);
            this.botonInicio.Name = "botonInicio";
            this.botonInicio.Size = new System.Drawing.Size(93, 51);
            this.botonInicio.TabIndex = 1;
            this.botonInicio.Text = "Iniciar Simulación";
            this.botonInicio.UseVisualStyleBackColor = true;
            this.botonInicio.Click += new System.EventHandler(this.BotonInicio_Click);
            // 
            // textoInformacion
            // 
            this.textoInformacion.Location = new System.Drawing.Point(12, 164);
            this.textoInformacion.Multiline = true;
            this.textoInformacion.Name = "textoInformacion";
            this.textoInformacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoInformacion.Size = new System.Drawing.Size(541, 165);
            this.textoInformacion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Candidatos viables encontrados:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textoInformacion);
            this.Controls.Add(this.botonInicio);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulación Candidatos a Titán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonInicio;
        private System.Windows.Forms.TextBox textoInformacion;
        private System.Windows.Forms.Label label2;
    }
}

