using Clinica.controller;
using Clinica.model;
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
    public partial class ConsultasCriar : Form
    {
        public ConsultasCriar()
        {
            InitializeComponent();
        }

        public ConsultasCriar(ArrayList medicos, ArrayList pacientes)
        {
            InitializeComponent();
            foreach (Medico m in medicos)
                this.medicos_combo.Items.Add(m.codm + " - " + m.nome);
            foreach (Paciente p in pacientes)
                this.pacientes_combo.Items.Add(p.codp + " - " + p.nome);
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            ConsultaController controller = new ConsultaController();
            string medico = this.medicos_combo.SelectedItem.ToString();
            string paciente = this.pacientes_combo.SelectedItem.ToString();
            DateTime dataHora = this.dataHoraConsulta.Value;
            Medico m = new Medico();
            Paciente p = new Paciente();
            m.codm = int.Parse(medico.Split(' ')[0]);
            p.codp = int.Parse(paciente.Split(' ')[0]);
            Consulta consulta = new Consulta();
            consulta.medico = m;
            consulta.paciente = p;
            consulta.dataHora = dataHora;
            controller.criar(consulta);

            MessageBox.Show(" Consulta Agendada !!  Medico : " + medico +
                            "\n Paciente : " + paciente +
                            "\n Data / Hora : " + consulta.dataHora);

           this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.listar();
            this.Close();
        }

        private void dataHoraConsulta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
