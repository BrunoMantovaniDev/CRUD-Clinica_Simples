using Clinica.controller;
using Clinica.Model;
using System;
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
    public partial class AmbulatorioEditar : Form
    {
        public AmbulatorioEditar()
        {
            InitializeComponent();
        }


        public AmbulatorioEditar(object ambulatorio)
        {
            InitializeComponent();

            Ambulatorio amb= (Ambulatorio)ambulatorio;
            this.nroaValor.Text = amb.nroa.ToString();
            this.andarValor.Text = amb.andar.ToString();
            this.capacidadeValor.Text = amb.capacidade.ToString() ;
            

        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Ambulatorio ambulatorio = new Ambulatorio();

            ambulatorio.nroa = int.Parse(this.nroaValor.Text);
            ambulatorio.andar = int.Parse(this.andarValor.Text);
            ambulatorio.capacidade = int.Parse(this.capacidadeValor.Text);
          

            AmbulatorioController Ambcontroller = new AmbulatorioController();
            Ambcontroller.salvar(ambulatorio);
            this.Close();
        }
    }
}
