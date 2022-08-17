using Clinica.DAO;
using Clinica.Model;
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

        public void criar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            ambulatorio = (Ambulatorio)ambulatorioDAO.create(ambulatorio);
            this.listar();

        }

        public void salvar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();

            ambulatorio = (Ambulatorio)ambulatorioDAO.update(ambulatorio);

            ArrayList todos = ambulatorioDAO.all();
            AmbulatorioView listagem = new AmbulatorioView(todos);
            listagem.Show();

        }


        public void alterar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            AmbulatorioEditar edicaoAmb = new AmbulatorioEditar(ambulatorio);
            edicaoAmb.Show();
        }

        internal void deletar(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;

            AmbulatorioDAO ambulatorioDAO = new AmbulatorioDAO();
            ambulatorioDAO.delete(ambulatorio);

            new AmbulatorioView(ambulatorioDAO.all()).Show();


        }
    }
}
