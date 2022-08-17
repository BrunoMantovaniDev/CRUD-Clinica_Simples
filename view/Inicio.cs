using Clinica.controller;
using Clinica.Controller;
using Clinica.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.SetVisibleCore(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pacienteBtn_Click(object sender, EventArgs e)
        {
            
            PacienteController pacienteController= new PacienteController();
            pacienteController.listar();
            
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void consultaBtn_Click(object sender, EventArgs e)
        {
            ConsultaController consultasController = new ConsultaController();
            consultasController.listar();

            this.Hide();
        }

        private void funcionarioBtn_Click(object sender, EventArgs e)
        {
            FuncionarioController funccontrol = new FuncionarioController();
            funccontrol.listar();
            
            this.Hide();
        }

        private void medicoBtn_Click(object sender, EventArgs e)
        {
            MedicoController medicos = new MedicoController();
            medicos.listar();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AmbulatorioController controller = new AmbulatorioController();
            controller.listar();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DependenteController dependentesController = new DependenteController();
            dependentesController.listar();

            this.Hide();
        }
    }
}
