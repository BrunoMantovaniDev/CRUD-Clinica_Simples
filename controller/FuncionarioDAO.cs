using Clinica.Controller;
using Clinica.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.DAO
{
    internal class FuncionarioDAO : IDAO
    {
       public ArrayList all()
        {
            ArrayList list = new ArrayList();
            BancodeDados  bd = new BancodeDados();
            string sql = "SELECT * FROM funcionarios";
            Funcionario funcionario;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());



            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    funcionario = new Funcionario();
                    funcionario.codf = int.Parse(rdr[0].ToString());
                    funcionario.nome = rdr[1].ToString();
                    funcionario.idade = int.Parse(rdr[2].ToString());
                    funcionario.cpf = decimal.Parse(rdr[3].ToString());
                    funcionario.cidade = rdr[4].ToString();
                    funcionario.salario = decimal.Parse(rdr[5].ToString());
                    funcionario.cargo = rdr[6].ToString();

                    list.Add(funcionario);
                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return list;

        }

        public object create(object objeto)
        {
            throw new NotImplementedException();
        }

        public object delete(object chave)
        {
            throw new NotImplementedException();
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            throw new NotImplementedException();
        }


    }
}
