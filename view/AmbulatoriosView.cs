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
    public partial class AmbulatoriosView : Form
    {
        public AmbulatoriosView()
        {
            InitializeComponent();
        }

        public AmbulatoriosView(ArrayList ambulatorio)
        {
            InitializeComponent();


            int x = 0;

            foreach (Ambulatorio f in ambulatorio)
            {
                this.listagem.Rows.Add();
                this.listagem.Rows[x].Cells[0].Value = f.nroa;
                this.listagem.Rows[x].Cells[1].Value = f.andar;
                this.listagem.Rows[x].Cells[2].Value = f.capacidade;
                
                x++;


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
