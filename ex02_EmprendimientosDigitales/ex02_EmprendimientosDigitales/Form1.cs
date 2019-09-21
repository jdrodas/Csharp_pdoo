using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02_EmprendimientosDigitales
{
    public partial class Form1 : Form
    {

        private GestionPrograma miGestion;

        public Form1()
        {
            InitializeComponent();

            //inicializamos el atributo que acabamos de realizar
            miGestion = new GestionPrograma();
        }

        private void BotonInicioSimulacion_Click(object sender, EventArgs e)
        {
            miGestion.InicializaSimulacion();
            textoResultadoSimulacion.Text = miGestion.InformacionPrograma();
        }
    }
}