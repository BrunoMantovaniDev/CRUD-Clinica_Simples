using Clinica.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.View
{
    public partial class AmbulatorioCriar : Form
    {
        public AmbulatorioCriar()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AmbulatorioController controller = new AmbulatorioController();
            controller.listar();
            this.Hide();
        }
    }
}
