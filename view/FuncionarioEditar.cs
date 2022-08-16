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
    public partial class FuncionarioEditar : Form
    {
        public FuncionarioEditar(object funcionario)
        {
            InitializeComponent();
            
            Funcionario func = (Funcionario) funcionario;
            this.codigoValor.Text = func.codf.ToString();
            this.nomeValor.Text = func.nome;
            this.cpfValor.Text = func.cpf;
            this.idadeValor.Text = func.idade.ToString();
            this.cidadeValor.Text = func.cidade;
            this.salarioValor.Text = func.salario.ToString();
            this.cargoValor.Text = func.cargo;
        
        }

        private void doenca_label_Click(object sender, EventArgs e)
        {

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.codf = int.Parse(this.codigoValor.Text);
            funcionario.nome = this.nomeValor.Text;
            funcionario.idade = int.Parse(this.idadeValor.Text);
            funcionario.cpf = this.cpfValor.Text;
            funcionario.cidade = this.cidadeValor.Text;
            funcionario.salario = decimal.Parse(this.salarioValor.Text);
            funcionario.cargo = this.cargoValor.Text;

            FuncionarioController Fcontroller = new FuncionarioController();
            Fcontroller.salvar(funcionario);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FuncionarioController funcionario = new FuncionarioController();

            funcionario.listar();



        }

        private void cidadeValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
