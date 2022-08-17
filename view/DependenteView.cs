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
    }
}
