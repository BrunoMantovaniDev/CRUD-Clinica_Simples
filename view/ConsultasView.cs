using Clinica.controller;
using Clinica.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.View
{
    public partial class ConsultasView : Form
    {
        public ConsultasView()
        {
            InitializeComponent();
        }

        public ConsultasView(ArrayList lista)
        {
            InitializeComponent();
            int x = 0;
            foreach (Consulta c in lista)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = "Dr(a) " + c.medico.nome;
                this.listagem.Rows[x].Cells[1].Value = c.paciente.nome;
                this.listagem.Rows[x].Cells[2].Value = c.dataHora.ToString("dd/MM/yyyy HH:mm:ss");
                this.listagem.Rows[x].Cells[3].Value = c.medico.codm;
                this.listagem.Rows[x].Cells[4].Value = c.paciente.codp;
                x++;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            ConsultaController controller = new ConsultaController();
            controller.preparaCriacao();
            this.Close();
        }

        private void DeletarConsulta_Click(object sender, EventArgs e)
        {
            
        }

        private void EditarConsulta_Click(object sender, EventArgs e)
        {

            int rowindex = this.listagem.CurrentCell.RowIndex;
            String dataHora = this.listagem.Rows[rowindex].Cells[2].Value.ToString();
            string codm = this.listagem.Rows[rowindex].Cells[3].Value.ToString();
            string codp = this.listagem.Rows[rowindex].Cells[4].Value.ToString();
            DateTime dataHoraFormata = DateTime.ParseExact(dataHora, "dd/MM/yyyy HH:mm:ss",
                CultureInfo.InvariantCulture);

            Paciente p = new Paciente();
            Medico m = new Medico();
            p.codp = int.Parse(codp);
            m.codm = int.Parse(codm);

            Consulta c = new Consulta();
            c.medico = m;
            c.paciente = p;
            c.dataHora = dataHoraFormata;

            ConsultaController controller = new ConsultaController();
            controller.preparaEdicao(c);
            this.Close();

        }

        private void ConsultasView_Load(object sender, EventArgs e)
        {

        }
    }
}
