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
    public partial class PacientesCriar : Form
    {
        public PacientesCriar()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacientesView paciente = new PacientesView();
            paciente.Show();
            this.Close();
        }

        private void PacientesCriar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            paciente.nome = this.nomeValor.Text;
            paciente.idade = int.Parse(this.idadeValor.Text);
            paciente.cidade = this.cidadeValor.Text;
            paciente.cpf = this.cpfValor.Text;
            paciente.doenca = this.doencaValor.Text;

            PacienteController controller = new PacienteController();
            controller.criar(paciente);
               
            this.Close();
        }
    }
}
