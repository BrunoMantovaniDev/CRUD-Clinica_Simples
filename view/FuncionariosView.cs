using Clinica.Controller;
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
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Clinica.View
{
    public partial class FuncionariosView : Form
    {
        public FuncionariosView()
        {
            InitializeComponent();
        }
        public FuncionariosView(ArrayList funcionarios)
        {
            InitializeComponent();

            
            int x = 0;

            foreach (Funcionario f in funcionarios)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = f.codf;
                this.listagem.Rows[x].Cells[1].Value = f.nome;
                this.listagem.Rows[x].Cells[2].Value = f.idade;
                this.listagem.Rows[x].Cells[3].Value = f.cpf;
                this.listagem.Rows[x].Cells[4].Value = f.cidade;
                this.listagem.Rows[x].Cells[5].Value = f.salario;
                this.listagem.Rows[x].Cells[6].Value = f.cargo;
                x++;
            

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NovoConsulta_Click(object sender, EventArgs e)
        {
            FuncionarioCriar novofuncionarios = new FuncionarioCriar();
            novofuncionarios.Show();
            this.Close();
        }

        private void EditarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codf = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String salario = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String cargo = this.listagem.Rows[rowindex].Cells[6].Value.ToString();

            Funcionario funcionario = new Funcionario();

            funcionario.codf = int.Parse(codf);
            funcionario.nome = nome;
            funcionario.idade = int.Parse(idade);
            funcionario.cpf = cpf;
            funcionario.cidade = cidade;
            funcionario.salario = decimal.Parse(salario);
            funcionario.cargo = cargo;

            FuncionarioController controller = new FuncionarioController();
            controller.alterar(funcionario);
            this.Close();

        }

        private void DeletarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codf = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String salario = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String cargo = this.listagem.Rows[rowindex].Cells[6].Value.ToString();

            Funcionario funcionario = new Funcionario();

            funcionario.codf = int.Parse(codf);
            funcionario.nome = nome;
            funcionario.idade = int.Parse(idade);
            funcionario.cpf = cpf;
            funcionario.cidade = cidade;
            funcionario.salario = decimal.Parse(salario);
            funcionario.cargo = cargo;

            DialogResult confirmResult = (DialogResult)MessageBox.Show("Deseja excluir o registro ???", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                FuncionarioController controller = new FuncionarioController();
                controller.deletar(funcionario);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Exclusao não realizada !!!");
                FuncionarioController controller = new FuncionarioController();
                controller.listar();
                this.Hide();
            }

            
            
        }
    }
}
