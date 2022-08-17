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
using System.Windows;
using MessageBox = System.Windows.MessageBox;

namespace Clinica.View
{
    public partial class AmbulatorioView : Form
    {
        public AmbulatorioView()
        {
            InitializeComponent();
        }

        public AmbulatorioView(ArrayList ambulatorio)
        {
            InitializeComponent();


            int x = 0;

            foreach (Ambulatorio amb in ambulatorio)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = amb.nroa;
                this.listagem.Rows[x].Cells[1].Value = amb.andar;
                this.listagem.Rows[x].Cells[2].Value = amb.capacidade;
                
                x++;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void NovoConsulta_Click(object sender, EventArgs e)
        {
            AmbulatorioCriar amb = new AmbulatorioCriar();
            amb.Show();
            this.Close();
            
        }

        private void EditarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String nroa = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String andar = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String capacidade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            

            Ambulatorio ambulatorio = new Ambulatorio();

            ambulatorio.nroa = int.Parse(nroa);
            ambulatorio.andar = int.Parse(andar);
            ambulatorio.capacidade = int.Parse(capacidade);
        

            AmbulatorioController controller = new AmbulatorioController();
            controller.alterar(ambulatorio);
            this.Close();

        }

        private void DeletarConsulta_Click(object sender, EventArgs e)
        {
            int rowindex = this.listagem.CurrentCell.RowIndex;

            String nroa = this.listagem.Rows[rowindex].Cells[0].Value.ToString();
            String andar = this.listagem.Rows[rowindex].Cells[1].Value.ToString();
            String capacidade = this.listagem.Rows[rowindex].Cells[2].Value.ToString();


            Ambulatorio ambulatorio = new Ambulatorio();

            ambulatorio.nroa = int.Parse(nroa);
            ambulatorio.andar = int.Parse(andar);
            ambulatorio.capacidade = int.Parse(capacidade);


            DialogResult confirmResult = (DialogResult)MessageBox.Show("Deseja excluir o registro de Ambulatorio ???", "Confirm Delete!!", MessageBoxButton.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                AmbulatorioController controller = new AmbulatorioController();
                controller.deletar(ambulatorio);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Exclusao não realizada !!!");
                AmbulatorioController controller = new AmbulatorioController();
                controller.listar();
                this.Hide();
            }

   

        }
    }
}
