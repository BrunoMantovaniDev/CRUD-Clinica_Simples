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
    internal class DependenteController
    {
        public void listar()
        {
            DependenteDAO depdao = new DependenteDAO();
            ArrayList lista = depdao.all();
            DependenteView tela = new DependenteView(lista);
            tela.Show();

        }

        public void preparaEdicao(object objeto)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            ArrayList funcionario;
            funcionario = funcionarioDAO.all();
            
            //Dependente dep = (Dependente)objeto;
            
            
            DependenteEditar tela = new DependenteEditar(funcionario, objeto);
            tela.Show();

        }

        public void preparaCriacao()
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            
            ArrayList funcionario;
            funcionario = funcionarioDAO.all();

            DependenteCriar tela = new DependenteCriar(funcionario);
            tela.Show();
        }

        public void criar(object objeto)
        {
            Dependente dep = (Dependente)objeto;
            DependenteDAO dependenteDAO = new DependenteDAO();
            dependenteDAO.create(dep);

            ArrayList lista = dependenteDAO.all();

            DependenteView tela = new DependenteView(lista);
            tela.Show();
        }

        public void salvar(object objeto)
        {
            Dependente dep = (Dependente)objeto;

            DependenteDAO dependenteDAO = new DependenteDAO();

            dep = (Dependente)dependenteDAO.update(dep);

            ArrayList todos = dependenteDAO.all();
            DependenteView listagem = new DependenteView(todos);
            listagem.Show();
        }

        public void deletar(object objeto)
        {
            Dependente dep = (Dependente)objeto;

            DependenteDAO dependenteDAO = new DependenteDAO();
            dependenteDAO.delete(dep);

            new DependenteView(dependenteDAO.all()).Show();
        }
    }
}
