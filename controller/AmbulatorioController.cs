using Clinica.DAO;
using Clinica.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.controller
{
    internal class AmbulatorioController
    {
        public void listar()
        {
            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            ArrayList lista = ambulatorioDAO.all();
            AmbulatorioView ambulatorio = new AmbulatorioView(lista);
            ambulatorio.Show();
        }
    }
}
