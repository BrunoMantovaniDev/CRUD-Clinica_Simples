using Clinica.controller;
using Clinica.DAO;
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
using System.Windows;
using MessageBox = System.Windows.MessageBox;

namespace Clinica.View
{
    public partial class DependenteView : Form
    {
        public DependenteView()
        {
            InitializeComponent();
        }

        public DependenteView(ArrayList lista)
        {
            InitializeComponent();
            int x = 0;
            foreach (Dependente D in lista)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = D.codd;
                this.listagem.Rows[x].Cells[1].Value = D.nome;
                this.listagem.Rows[x].Cells[2].Value = D.nascimento;
                this.listagem.Rows[x].Cells[3].Value = D.funcionario.nome;
                this.listagem.Rows[x].Cells[4].Value = D.funcionario.codf;

                
                x++;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void NovoConsulta_Click(object sender, EventArgs e)
        {
            DependenteController controller = new DependenteController();
            controller.preparaCriacao();
            this.Close();
        }

        private void DeletarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            string codd = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            string nascimento = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codf3 = this.listagem.Rows[rowindex].Cells[4].Value.ToString();


            Funcionario func = new Funcionario();
            func.codf = int.Parse(codf3);

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            Dependente dep = new Dependente();
            dep.codd = int.Parse(codd);
            dep.nome = nome;
            dep.nascimento = nascimento;
            dep.funcionario = (Funcionario)funcionarioDAO.read(func);

            


            DialogResult confirmResult = (DialogResult)MessageBox.Show("Deseja excluir dependente ???", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                DependenteController controller = new DependenteController();
                controller.deletar(dep);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Exclusao de dependente não realizada !!!");
                DependenteController controller = new DependenteController();
                controller.listar();
                this.Hide();
            }



        }

        private void EditarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;
            
            string codd = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            string nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            string nascimento = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codf3 = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            
            
            Funcionario func = new Funcionario();   
            func.codf = int.Parse(codf3);

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            Dependente dep = new Dependente();
            dep.codd = int.Parse(codd) ;
            dep.nome = nome;
            dep.nascimento = nascimento;
            dep.funcionario = (Funcionario)funcionarioDAO.read(func);

            DependenteController controller = new DependenteController();
            controller.preparaEdicao(dep);
            this.Hide();
        }
    }
}
