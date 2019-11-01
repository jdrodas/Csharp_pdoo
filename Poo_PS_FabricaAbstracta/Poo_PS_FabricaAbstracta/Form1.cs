using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poo_PS_FabricaAbstracta
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Seleccionamos el primer item de la lista
            cbxContinente.SelectedIndex = 0;
        }

        private void btnInicioCaceria_Click(object sender, EventArgs e)
        {
            MundoAnimal miMundo = new MundoAnimal(cbxContinente.SelectedItem.ToString(),
                                                  txtNombreCarnivoro.Text,
                                                  txtNombreHerbivoro.Text);

            txtResultado.Text = miMundo.ResultadoCadenaAlimenticia();
        }

        private void cbxContinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seleccionamos el primer item de la lista
            cbxContinente.SelectedIndex = 0;

        }
    }
}
