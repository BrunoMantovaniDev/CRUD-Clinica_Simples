using Clinica.Controller;
using Clinica.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.DAO
{
    internal class FuncionarioDAO : IDAO
    {
       public ArrayList all()
        {
            ArrayList list = new ArrayList();
            BancodeDados  bd = new BancodeDados();
            string sql = "SELECT * FROM funcionarios ORDER BY codf DESC";
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
                    funcionario.cpf = rdr[3].ToString();
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
            Funcionario funcionario = (Funcionario)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO funcionarios" +
                    "(nome,idade,cpf,cidade,salario,cargo) " +
                    "VALUES(@nome,@idade,@cpf,@cidade,@salario,@cargo)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", funcionario.nome);
                cmd.Parameters.AddWithValue("@idade", funcionario.idade);
                cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
                cmd.Parameters.AddWithValue("@salario", funcionario.salario);
                cmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();

                int id = int.Parse(cmd.LastInsertedId.ToString());
                funcionario.codf = id;

                MessageBox.Show("Funcionario: " + funcionario.nome + " inserido com Sucesso" );
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }

        public object delete(object chave)
        {
            Funcionario funcionario = (Funcionario) chave;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from funcionarios " +
                    "where codf=@codf";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codf", funcionario.codf);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Feito exclusao do funcionario: " + funcionario.nome + " com Sucesso");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }
    

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            Funcionario funcionario = (Funcionario)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                /*cmd.CommandText = "update funcionarios " +
                    "set nome=@nome," +
                    "idade=@idade," +
                    "cpf=@cpf," +
                    "cidade=@cidade," +
                    "salario=@salario, " +
                    "cargo=@cargo " +
                    "where codf=@codf";*/

                cmd.CommandText = @"
                    update funcionarios 
                    set nome=@nome, idade=@idade, cpf=@cpf, cidade=@cidade, salario=@salario, cargo=@cargo
                    where codf = @codf
                ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", funcionario.nome);
                cmd.Parameters.AddWithValue("@idade", funcionario.idade);
                cmd.Parameters.AddWithValue("@cpf", funcionario.cpf);
                cmd.Parameters.AddWithValue("@cidade", funcionario.cidade);
                cmd.Parameters.AddWithValue("@salario", funcionario.salario);
                cmd.Parameters.AddWithValue("@cargo", funcionario.cargo);
                cmd.Parameters.AddWithValue("@codf", funcionario.codf);
                cmd.ExecuteNonQuery();

               // MessageBox.Show("Atualização do funcionario: " + funcionario.nome + " feito com sucesso");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return funcionario;
        }


    }
}
