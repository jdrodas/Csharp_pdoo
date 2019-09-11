using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex02_TorneoE_Sports
{
    public partial class Form1 : Form
    {

        private RegistroParticipantes miRegistro;

        public Form1()
        {
            InitializeComponent();

            //inicializamos el atributo que acabamos de realizar
            miRegistro = new RegistroParticipantes();
            miRegistro.InicializaSimulacion();
        }

        private void BotonInicioSimulacion_Click(object sender, EventArgs e)
        {
            miRegistro.InicializaSimulacion();

            textoResultadoSimulacion.Text = miRegistro.InformacionParticipacion();
        }
    }
}
