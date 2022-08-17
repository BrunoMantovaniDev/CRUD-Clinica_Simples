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
    public partial class ConsultasEditar : Form
    {
       
        public ConsultasEditar(ArrayList medicos, ArrayList pacientes, object objeto)
        {
            InitializeComponent();
            foreach (Medico m in medicos)
                this.medicos_combo.Items.Add(m.codm + " - " + m.nome);
            foreach (Paciente p in pacientes)
                this.pacientes_combo.Items.Add(p.codp + " - " + p.nome);
            
            Consulta c = (Consulta)objeto;
            
            this.medicos_combo.Text = c.medico.codm + " - " + c.medico.nome;
            this.pacientes_combo.Text = c.paciente.codp + " - " + c.paciente.nome;
            this.dataHoraConsulta.Text = c.dataHora.ToString("dd-MM-yyyy hh:mm:ss");

        }


        private void codigo_label_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaController consultaController = new ConsultaController();
            consultaController.listar();

            this.Close();
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
            controller.salvar(consulta);

            this.Close();
            
        }

        private void dataHoraConsulta_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
