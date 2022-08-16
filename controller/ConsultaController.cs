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
    internal class ConsultaController
    {
        public void alterar(object objeto)
        {
            throw new NotImplementedException();
        }

        public void preparaEdicao(object objeto)
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.all();
            pacientes = pacienteDAO.all();
            Consulta c = (Consulta)objeto;
            c.medico = (Medico)medicoDAO.read(c.medico);
            c.paciente = (Paciente)pacienteDAO.read(c.paciente);
            ConsultasEditar tela = new ConsultasEditar(medicos, pacientes, objeto);
            tela.Show();

        }
        public void preparaCriacao()
        {
            PacienteDAO pacienteDAO = new PacienteDAO();
            MedicoDAO medicoDAO = new MedicoDAO();
            ArrayList pacientes, medicos;
            medicos = medicoDAO.all();
            pacientes = pacienteDAO.all();
            ConsultasCriar tela = new ConsultasCriar(medicos, pacientes);
            tela.Show();
        }

        public void criar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;
            ConsultaDAO consultaDAO = new ConsultaDAO();
            consultaDAO.create(consulta);

            ArrayList lista = consultaDAO.all();

            ConsultasView tela = new ConsultasView(lista);
            tela.Show();
        }

        public void deletar(object objeto)
        {
            throw new NotImplementedException();
        }

        public void listar()
        {
            ConsultaDAO dao = new ConsultaDAO();
            ArrayList lista = dao.all();
            ConsultasView tela = new ConsultasView(lista);
            tela.Show();

        }

        public void salvar(object objeto)
        {
            Consulta consulta = (Consulta)objeto;

            ConsultaDAO consultaDAO = new ConsultaDAO();

            consulta = (Consulta)consultaDAO.update(consulta);

            ArrayList todos = consultaDAO.all();
            ConsultasView listagem = new ConsultasView(todos);
            listagem.Show();
        }

    }
}
