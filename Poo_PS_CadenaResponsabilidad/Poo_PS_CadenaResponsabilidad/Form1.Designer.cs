namespace Poo_PS_CadenaResponsabilidad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResultadoValidacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnValidaJerarquia = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMontoCoordinador = new System.Windows.Forms.TextBox();
            this.txtNombreCoordinador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoDirector = new System.Windows.Forms.TextBox();
            this.txtNombreDirector = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMontoPresidente = new System.Windows.Forms.TextBox();
            this.txtNombrePresidente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtResultadoAprobacion = new System.Windows.Forms.TextBox();
            this.btnSolicitudAprobacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena de Responsabilidad - Aprobación de Pedidos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultadoValidacion);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnValidaJerarquia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMontoCoordinador);
            this.groupBox1.Controls.Add(this.txtNombreCoordinador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMontoDirector);
            this.groupBox1.Controls.Add(this.txtNombreDirector);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMontoPresidente);
            this.groupBox1.Controls.Add(this.txtNombrePresidente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(35, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejecutivos:";
            // 
            // txtResultadoValidacion
            // 
            this.txtResultadoValidacion.Location = new System.Drawing.Point(392, 105);
            this.txtResultadoValidacion.Multiline = true;
            this.txtResultadoValidacion.Name = "txtResultadoValidacion";
            this.txtResultadoValidacion.Size = new System.Drawing.Size(148, 53);
            this.txtResultadoValidacion.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(389, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Resultado validación:";
            // 
            // btnValidaJerarquia
            // 
            this.btnValidaJerarquia.Location = new System.Drawing.Point(392, 26);
            this.btnValidaJerarquia.Name = "btnValidaJerarquia";
            this.btnValidaJerarquia.Size = new System.Drawing.Size(148, 46);
            this.btnValidaJerarquia.TabIndex = 7;
            this.btnValidaJerarquia.Text = "Valida Jerarquia de Montos";
            this.btnValidaJerarquia.UseVisualStyleBackColor = true;
            this.btnValidaJerarquia.Click += new System.EventHandler(this.btnValidaJerarquia_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto Máximo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre:";
            // 
            // txtMontoCoordinador
            // 
            this.txtMontoCoordinador.Location = new System.Drawing.Point(103, 99);
            this.txtMontoCoordinador.Name = "txtMontoCoordinador";
            this.txtMontoCoordinador.Size = new System.Drawing.Size(73, 20);
            this.txtMontoCoordinador.TabIndex = 2;
            this.txtMontoCoordinador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombreCoordinador
            // 
            this.txtNombreCoordinador.Location = new System.Drawing.Point(103, 69);
            this.txtNombreCoordinador.Name = "txtNombreCoordinador";
            this.txtNombreCoordinador.Size = new System.Drawing.Size(73, 20);
            this.txtNombreCoordinador.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Coordinador:";
            // 
            // txtMontoDirector
            // 
            this.txtMontoDirector.Location = new System.Drawing.Point(196, 99);
            this.txtMontoDirector.Name = "txtMontoDirector";
            this.txtMontoDirector.Size = new System.Drawing.Size(73, 20);
            this.txtMontoDirector.TabIndex = 4;
            this.txtMontoDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombreDirector
            // 
            this.txtNombreDirector.Location = new System.Drawing.Point(196, 69);
            this.txtNombreDirector.Name = "txtNombreDirector";
            this.txtNombreDirector.Size = new System.Drawing.Size(73, 20);
            this.txtNombreDirector.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Director:";
            // 
            // txtMontoPresidente
            // 
            this.txtMontoPresidente.Location = new System.Drawing.Point(280, 99);
            this.txtMontoPresidente.Name = "txtMontoPresidente";
            this.txtMontoPresidente.Size = new System.Drawing.Size(73, 20);
            this.txtMontoPresidente.TabIndex = 6;
            this.txtMontoPresidente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNombrePresidente
            // 
            this.txtNombrePresidente.Location = new System.Drawing.Point(280, 69);
            this.txtNombrePresidente.Name = "txtNombrePresidente";
            this.txtNombrePresidente.Size = new System.Drawing.Size(73, 20);
            this.txtNombrePresidente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Presidente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResultadoAprobacion);
            this.groupBox2.Controls.Add(this.btnSolicitudAprobacion);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtValorPedido);
            this.groupBox2.Location = new System.Drawing.Point(35, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 144);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del pedido:";
            // 
            // txtResultadoAprobacion
            // 
            this.txtResultadoAprobacion.Location = new System.Drawing.Point(41, 81);
            this.txtResultadoAprobacion.Multiline = true;
            this.txtResultadoAprobacion.Name = "txtResultadoAprobacion";
            this.txtResultadoAprobacion.Size = new System.Drawing.Size(312, 43);
            this.txtResultadoAprobacion.TabIndex = 15;
            // 
            // btnSolicitudAprobacion
            // 
            this.btnSolicitudAprobacion.Location = new System.Drawing.Point(189, 20);
            this.btnSolicitudAprobacion.Name = "btnSolicitudAprobacion";
            this.btnSolicitudAprobacion.Size = new System.Drawing.Size(164, 28);
            this.btnSolicitudAprobacion.TabIndex = 9;
            this.btnSolicitudAprobacion.Text = "Solicitar Aprobación";
            this.btnSolicitudAprobacion.UseVisualStyleBackColor = true;
            this.btnSolicitudAprobacion.Click += new System.EventHandler(this.btnSolicitudAprobacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Resultado de la solicitud:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Valor:";
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.Location = new System.Drawing.Point(87, 25);
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.Size = new System.Drawing.Size(73, 20);
            this.txtValorPedido.TabIndex = 8;
            this.txtValorPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS - Cadena de Responsabilidad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMontoCoordinador;
        private System.Windows.Forms.TextBox txtNombreCoordinador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoDirector;
        private System.Windows.Forms.TextBox txtNombreDirector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMontoPresidente;
        private System.Windows.Forms.TextBox txtNombrePresidente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultadoValidacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnValidaJerarquia;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorPedido;
        private System.Windows.Forms.TextBox txtResultadoAprobacion;
        private System.Windows.Forms.Button btnSolicitudAprobacion;
        private System.Windows.Forms.Label label9;
    }
}

