using Clinica.Controller;
using Clinica.Model;
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
    public partial class FuncionarioCriar : Form
    {
        public FuncionarioCriar()
        {
            InitializeComponent();
        }

        private void FuncionarioCriar_Load(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            
            funcionario.nome = this.nomeValor.Text;
            funcionario.idade = int.Parse(this.idadeValor.Text);
            funcionario.cpf = this.cpfValor.Text;
            funcionario.cidade = this.cidadeValor.Text;
            funcionario.salario = decimal.Parse(this.salarioValor.Text);
            funcionario.cargo = this.cargoValor.Text;

            FuncionarioController controller = new FuncionarioController();
            controller.criar(funcionario);

            this.Close();
        }

        private void cpfValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void idadeValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionarioController funcionario = new FuncionarioController();

            funcionario.listar();
        }
    }
}
