using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatarrizacionCamiones
{
    public partial class Form1 : Form
    {
        private ControlSimulacion miControl;
        public Form1()
        {
            InitializeComponent();
            miControl = new ControlSimulacion();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            miControl.InicializaSimulacion();

            TxtResultado.Text = miControl.TotalesCamiones();
        }
    }
}
