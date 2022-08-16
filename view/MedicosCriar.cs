using Clinica.controller;
using Clinica.model;
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
    public partial class MedicosCriar : Form
    {
        public MedicosCriar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MedicoController controller = new MedicoController();
            controller.listar();
            this.Close();
        }

        private void titulo_label_Click(object sender, EventArgs e)
        {

        }

        private void doencaValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void doenca_label_Click(object sender, EventArgs e)
        {

        }

        private void cpfValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_label_Click(object sender, EventArgs e)
        {

        }

        private void cidadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void cidade_label_Click(object sender, EventArgs e)
        {

        }

        private void idadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void idade_label_Click(object sender, EventArgs e)
        {

        }

        private void nomeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void nome_label_Click(object sender, EventArgs e)
        {

        }

        private void codigoValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigo_label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            

        }

        private void SalvarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.nome = this.nomeValor.Text;
            medico.idade = int.Parse(this.idadeValor.Text);
            medico.cpf = this.especialidadeValor.Text;
            medico.especialidade = this.especialidadeValor.Text;
            medico.cidade = this.cpfValor.Text;
            medico.nroa = int.Parse(this.ambulatorioValor.Text);

            MedicoController controller = new MedicoController();
            controller.criar(medico);

            this.Close();

        }
    }
}
