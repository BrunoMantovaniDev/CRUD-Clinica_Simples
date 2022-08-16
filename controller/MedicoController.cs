using Clinica.DAO;
using Clinica.model;
using Clinica.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.controller
{
    internal class MedicoController
    {

        public void alterar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicosEditar edicaoMed = new MedicosEditar(medico);
            edicaoMed.Show();
        }

        public void criar(object objeto)
        {
            Medico medico = (Medico)objeto;
            MedicoDAO medicoDAO = new MedicoDAO();
            medico = (Medico)medicoDAO.create(medico);
            this.listar();
        }

        public void deletar(object objeto)
        {
            Medico medico = (Medico)objeto;

            MedicoDAO medicoDAO = new MedicoDAO();
            medicoDAO.delete(medico);

            new MedicosView(medicoDAO.all()).Show();
        }

        public void listar()
        {
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList lista = medicoDAO.all();
            MedicosView tela = new MedicosView(lista);
            tela.Show();
        }

        public void salvar(object objeto)
        {
            Medico medico = (Medico)objeto;

            MedicoDAO medicoDAO = new MedicoDAO();

            medico = (Medico)medicoDAO.update(medico);

            ArrayList todos = medicoDAO.all();
            MedicosView listagem = new MedicosView(todos);
            listagem.Show();
        }
    }
}
