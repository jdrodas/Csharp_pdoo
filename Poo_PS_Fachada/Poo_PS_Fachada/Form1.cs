using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_PS_Fachada
{
    public partial class Form1 : Form
    {
        //atributos de la clase
        private EntidadCrediticia laEntidad;
        
        public Form1()
        {
            InitializeComponent();
            
            laEntidad = new EntidadCrediticia();
        }

        private void btnEvaluaCredito_Click(object sender, EventArgs e)
        {
            try
            {
                //Se asigna la información del cliente
                laEntidad.AsignaInfoCliente(
                  txtNombreCliente.Text,
                  float.Parse(txtValorPrestamo.Text),
                  float.Parse(txtValorCesantias.Text),
                  int.Parse(txtPuntajeDatacredito.Text));

                //validamos que la información permita la evaluación del crédito
                if (laEntidad.ValidaInfoCliente() == false)
                {
                    MessageBox.Show(
                        "Los valores de Préstamo, Cesantías y Puntaje Datacrédito deben ser números positivos.",
                        "Valores numéricos incorrectos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    // -- Aqui se invoca el estudio del crédito
                    laEntidad.EstudiaCredito();

                    //se visualiza el resultado de la validación
                    txtResultadoValidacion.Text = laEntidad.ObtieneResultadoValidacion();
                }
            }
            catch (FormatException elError)
            {
                MessageBox.Show(
                    "Los valores de Préstamo, Cesantías y Puntaje Datacrédito deben ser numéricos.",
                    "Datos inválidos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
