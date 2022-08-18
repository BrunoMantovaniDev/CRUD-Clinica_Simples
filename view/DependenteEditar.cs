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
    public partial class DependenteEditar : Form
    {
        public int codigoD { get; set; }
        public DependenteEditar(ArrayList funcionario, object objeto)
        {
            InitializeComponent();
            foreach (Funcionario func in funcionario)
                this.funcionario_combo.Items.Add(func.codf + " - " + func.nome);

            Dependente dep = (Dependente)objeto;

            codigoD = dep.codd;
            this.funcionario_combo.Text = dep.funcionario.codf + " - " + dep.funcionario.nome;
            this.dataDependente.Text = dep.nascimento;
            this.nomeValor.Text = dep.nome;
            
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            DependenteController controller = new DependenteController();
            string funcionario = this.funcionario_combo.SelectedItem.ToString();

            Dependente dep = new Dependente();
            dep.codd = codigoD;
            dep.nome = this.nomeValor.Text;
            dep.nascimento = this.dataDependente.Value.ToString();


            Funcionario func = new Funcionario();
            func.codf = int.Parse(funcionario.Split(' ')[0]);

            dep.funcionario = func;
            controller.salvar(dep);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DependenteController Controller = new DependenteController();
            Controller.listar();

            this.Close();
        }
    }
}
