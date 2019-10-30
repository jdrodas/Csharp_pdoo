using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo_ps_CadenaResponsabilidad
{
    public partial class Form1 : Form
    {

        //Atributos de la clase
        ControlAprobacion miControl;

        public Form1()
        {
            InitializeComponent();

            miControl = new ControlAprobacion();
        }

        private void btnValidaJerarquia_Click(object sender, EventArgs e)
        {
            //Pasamos los valores de los campos de texto 
            //a los atributos de los ejecutivos en el control
            miControl.AsignaValoresEjecutivo("Coordinador",
                txtNombreCoordinador.Text,
                int.Parse(txtMontoCoordinador.Text));

            miControl.AsignaValoresEjecutivo("Director",
                txtNombreDirector.Text,
                int.Parse(txtMontoDirector.Text));

            miControl.AsignaValoresEjecutivo("Presidente",
                txtNombrePresidente.Text,
                int.Parse(txtMontoPresidente.Text));

            //aqui visualizamos el resultado de la validación de la jerarquia
            txtResultadoValidacion.Text = miControl.EvaluaJerarquia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMontoCoordinador.Text = "0";
            txtMontoDirector.Text = "0";
            txtMontoPresidente.Text = "0";

            txtValorPedido.Text = "0";
        }

        private void btnSolicitudAprobacion_Click(object sender, EventArgs e)
        {
            txtResultadoAprobacion.Text = miControl.AutorizaPedido(int.Parse(txtValorPedido.Text));
        }
    }
}
