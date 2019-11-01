namespace Poo_PS_FabricaAbstracta
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbxContinente = new System.Windows.Forms.ComboBox();
            this.txtNombreHerbivoro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCarnivoro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicioCaceria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxContinente);
            this.groupBox1.Controls.Add(this.txtNombreHerbivoro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreCarnivoro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre de Animales y Continente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selecciona el Continente:";
            // 
            // cbxContinente
            // 
            this.cbxContinente.FormattingEnabled = true;
            this.cbxContinente.Items.AddRange(new object[] {
            "Africa",
            "Asia",
            "Oceanía"});
            this.cbxContinente.Location = new System.Drawing.Point(234, 58);
            this.cbxContinente.Name = "cbxContinente";
            this.cbxContinente.Size = new System.Drawing.Size(121, 21);
            this.cbxContinente.TabIndex = 4;
            // 
            // txtNombreHerbivoro
            // 
            this.txtNombreHerbivoro.Location = new System.Drawing.Point(78, 60);
            this.txtNombreHerbivoro.Name = "txtNombreHerbivoro";
            this.txtNombreHerbivoro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreHerbivoro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Herbívoro";
            // 
            // txtNombreCarnivoro
            // 
            this.txtNombreCarnivoro.Location = new System.Drawing.Point(78, 34);
            this.txtNombreCarnivoro.Name = "txtNombreCarnivoro";
            this.txtNombreCarnivoro.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCarnivoro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carnívoro";
            // 
            // btnInicioCaceria
            // 
            this.btnInicioCaceria.Location = new System.Drawing.Point(146, 145);
            this.btnInicioCaceria.Name = "btnInicioCaceria";
            this.btnInicioCaceria.Size = new System.Drawing.Size(150, 23);
            this.btnInicioCaceria.TabIndex = 1;
            this.btnInicioCaceria.Text = "Iniciar cadena alimenticia";
            this.btnInicioCaceria.UseVisualStyleBackColor = true;
            this.btnInicioCaceria.Click += new System.EventHandler(this.btnInicioCaceria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Resultado cadena alimenticia:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(32, 210);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(377, 85);
            this.txtResultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 313);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInicioCaceria);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mundo Animal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxContinente;
        private System.Windows.Forms.TextBox txtNombreHerbivoro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCarnivoro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioCaceria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

