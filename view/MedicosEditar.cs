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
    public partial class MedicosEditar : Form
    {
        public MedicosEditar()
        {
            InitializeComponent();
        }

        public MedicosEditar(object medico)
        {
            InitializeComponent();
            Medico m = (Medico)medico;
            this.codigoValor.Text = m.codm.ToString();
            this.nomeValor.Text = m.nome;
            this.idadeValor.Text = m.idade.ToString();
            this.cpfValor.Text = m.cpf;
            this.especialidadeValor.Text = m.especialidade;
            this.cidadeValor.Text = m.cidade;
            this.ambulatorioValor.Text = m.nroa.ToString();
        }

        private void MedicosEditar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicosView medicos = new MedicosView();
            medicos.Show();
            this.Close();
        }

        private void SalvarMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();

            medico.codm = int.Parse(this.codigoValor.Text);
            medico.nome = this.nomeValor.Text;
            medico.idade = int.Parse(this.idadeValor.Text);
            medico.cpf = this.cpfValor.Text;
            medico.especialidade = this.especialidadeValor.Text;
            medico.cidade = this.cidadeValor.Text;
            medico.nroa = int.Parse(this.ambulatorioValor.Text);

            MedicoController controller = new MedicoController();
            controller.salvar(medico);
            this.Close();
        }
    }
}
