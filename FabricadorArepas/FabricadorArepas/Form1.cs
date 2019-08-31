using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricadorArepas
{
    public partial class Form1 : Form
    {
        private CreadorArepas elCreador;
        public Form1()
        {
            InitializeComponent();
            elCreador = new CreadorArepas();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            elCreador.InicializaArepas();

            //aqui visualizamos resultados
            txtTotalAsadas.Text = elCreador.TotalAsadas.ToString();
            txtTotalCongeladas.Text = elCreador.TotalCongeladas.ToString();
            txtTotalProcesadas.Text = elCreador.TotalProcesadas.ToString();

            txtInformacion.Text = elCreador.ObtieneTotalInfo();
        }
    }
}
