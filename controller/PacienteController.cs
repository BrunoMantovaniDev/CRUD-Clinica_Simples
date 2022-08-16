using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class PacienteController
    {
        public void listar()
        {
            PacienteDAO pacientesDAO = new PacienteDAO();
            ArrayList lista = pacientesDAO.all();
            PacientesView pacientes = new PacientesView(lista);
            pacientes.Show();
        }
        public void criar(object objeto)
        {
            Paciente paciente = (Paciente) objeto;
            PacienteDAO pacienteDAO = new PacienteDAO();
            paciente = (Paciente) pacienteDAO.create(paciente);
            this.listar();  
            
        }
        public void alterar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            PacientesEditar edicao = new PacientesEditar(paciente);
            edicao.Show();
        }
        public void salvar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();

            paciente = (Paciente)pacienteDAO.update(paciente);

            ArrayList todos = pacienteDAO.all();
            PacientesView listagem = new PacientesView(todos);
            listagem.Show();

        }

        internal void deletar(object objeto)
        {
            Paciente paciente = (Paciente)objeto;

            PacienteDAO pacienteDAO = new PacienteDAO();
            pacienteDAO.delete(paciente);

            new PacientesView(pacienteDAO.all()).Show();
            /* EQUIVALENTE A 
             * ArrayList todos = pacienteDAO.all();
             * Pacientes listagem = new Pacientes(todos);
             * listagem.Show();
             */


        }
    }
}
