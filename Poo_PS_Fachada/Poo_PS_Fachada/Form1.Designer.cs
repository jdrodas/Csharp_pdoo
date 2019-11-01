namespace Poo_PS_Fachada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtValorPrestamo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuntajeDatacredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorCesantias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEvaluaCredito = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultadoValidacion = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValorCesantias);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPuntajeDatacredito);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorPrestamo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(125, 39);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(172, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // txtValorPrestamo
            // 
            this.txtValorPrestamo.Location = new System.Drawing.Point(125, 76);
            this.txtValorPrestamo.Name = "txtValorPrestamo";
            this.txtValorPrestamo.Size = new System.Drawing.Size(172, 20);
            this.txtValorPrestamo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor Préstamo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPuntajeDatacredito
            // 
            this.txtPuntajeDatacredito.Location = new System.Drawing.Point(125, 114);
            this.txtPuntajeDatacredito.Name = "txtPuntajeDatacredito";
            this.txtPuntajeDatacredito.Size = new System.Drawing.Size(172, 20);
            this.txtPuntajeDatacredito.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Puntaje Datacrédito";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValorCesantias
            // 
            this.txtValorCesantias.Location = new System.Drawing.Point(125, 149);
            this.txtValorCesantias.Name = "txtValorCesantias";
            this.txtValorCesantias.Size = new System.Drawing.Size(172, 20);
            this.txtValorCesantias.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Cesantías";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEvaluaCredito
            // 
            this.btnEvaluaCredito.Location = new System.Drawing.Point(123, 216);
            this.btnEvaluaCredito.Name = "btnEvaluaCredito";
            this.btnEvaluaCredito.Size = new System.Drawing.Size(115, 23);
            this.btnEvaluaCredito.TabIndex = 1;
            this.btnEvaluaCredito.Text = "Evalua Crédito";
            this.btnEvaluaCredito.UseVisualStyleBackColor = true;
            this.btnEvaluaCredito.Click += new System.EventHandler(this.btnEvaluaCredito_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Resultado Validación:";
            // 
            // txtResultadoValidacion
            // 
            this.txtResultadoValidacion.Location = new System.Drawing.Point(30, 270);
            this.txtResultadoValidacion.Multiline = true;
            this.txtResultadoValidacion.Name = "txtResultadoValidacion";
            this.txtResultadoValidacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultadoValidacion.Size = new System.Drawing.Size(303, 100);
            this.txtResultadoValidacion.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 395);
            this.Controls.Add(this.txtResultadoValidacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEvaluaCredito);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamos Hipotecarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorCesantias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuntajeDatacredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorPrestamo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEvaluaCredito;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultadoValidacion;
    }
}

