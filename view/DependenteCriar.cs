using Clinica.controller;
using Clinica.Model;
using System;
using System.Collections;
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
    public partial class DependenteCriar : Form
    {
        public DependenteCriar()
        {
            InitializeComponent();
        }


        public DependenteCriar(ArrayList funcionario)
        {
            InitializeComponent();
            foreach (Funcionario func in funcionario)
                this.funcionario_combo.Items.Add(func.codf + " - " + func.nome);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataHoraConsulta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            DependenteController controller = new DependenteController();
            string funcionario = this.funcionario_combo.SelectedItem.ToString();
            
            Dependente dep = new Dependente();
            dep.nome = this.nomeValor.Text;
            dep.nascimento = this.dataHoraConsulta.Value.ToString();


            Funcionario f = new Funcionario();

            f.codf = int.Parse(funcionario.Split(' ')[0]);

            dep.funcionario= f;
            controller.criar(dep);

/*
            MessageBox.Show(" Consulta Agendada !!  Medico : " + medico +
                            "\n Paciente : " + paciente +
                            "\n Data / Hora : " + consulta.dataHora);
*/

            this.Close();
        }

        private void nomeValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
