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
    }
}
