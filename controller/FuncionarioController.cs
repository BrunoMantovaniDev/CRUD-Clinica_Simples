using Clinica.DAO;
using Clinica.Model;
using Clinica.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.Controller
{
    public class FuncionarioController
    {
        public void listar()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ArrayList lista = funcionarioDAO.all();
            FuncionariosView funcionario = new FuncionariosView(lista);
            funcionario.Show();
        }

       
        public void criar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionario = (Funcionario)funcionarioDAO.create(funcionario);
            this.listar();
            
        }

        public void alterar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            FuncionarioEditar edicaofunc = new FuncionarioEditar(funcionario);
            edicaofunc.Show();
        }

        public void salvar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            funcionario = (Funcionario)funcionarioDAO.update(funcionario);

            ArrayList todos = funcionarioDAO.all();
            FuncionariosView listagem = new FuncionariosView(todos);
            listagem.Show();

            

        }


        internal void deletar(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;

            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            funcionarioDAO.delete(funcionario);

            new FuncionariosView(funcionarioDAO.all()).Show();
            

        }
    }
}
