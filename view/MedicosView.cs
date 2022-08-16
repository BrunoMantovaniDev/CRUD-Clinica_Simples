using Clinica.controller;
using Clinica.model;
using Clinica.View;
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

namespace Clinica
{
    public partial class MedicosView : Form
    {
        public MedicosView()
        {
            InitializeComponent();
        }

        public MedicosView(ArrayList lista)
        {
            InitializeComponent();
            int x = 0;
            foreach (Medico m in lista)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = m.codm;
                this.listagem.Rows[x].Cells[1].Value = m.nome;
                this.listagem.Rows[x].Cells[2].Value = m.idade;
                this.listagem.Rows[x].Cells[3].Value = m.especialidade;
                this.listagem.Rows[x].Cells[4].Value = m.cpf;
                this.listagem.Rows[x].Cells[5].Value = m.cidade;
                this.listagem.Rows[x].Cells[6].Value = m.nroa;
                x++;
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void Medicos_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MedicosCriar medicosCriar = new MedicosCriar();

            medicosCriar.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String especialidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String ambulatorio = this.listagem.Rows[rowindex].Cells[6].Value.ToString();

            Medico medico = new Medico();
            medico.codm = int.Parse(codm);
            medico.nome = nome;
            medico.idade = int.Parse(idade);
            medico.cpf = cpf;
            medico.especialidade = especialidade;
            medico.cidade = cidade;
            medico.nroa = int.Parse(ambulatorio);

            MedicoController medcontroller= new MedicoController();
            medcontroller.alterar(medico);
            this.Close();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String codm = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String nome = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String idade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            String especialidade = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            String cpf = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            String cidade = this.listagem.Rows[rowindex].Cells[5].Value.ToString();
            String ambulatorio = this.listagem.Rows[rowindex].Cells[6].Value.ToString();

            Medico medico = new Medico();
            medico.codm = int.Parse(codm);
            medico.nome = nome;
            medico.idade = int.Parse(idade);
            medico.cpf = cpf;
            medico.especialidade = especialidade;
            medico.cidade = cidade;
            medico.nroa = int.Parse(ambulatorio);



            DialogResult confirmResult = (DialogResult)System.Windows.MessageBox.Show("Deseja excluir o registro ???", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                MedicoController controller = new MedicoController();
                controller.deletar(medico);
            }

            this.Hide();
        }
    }
}
