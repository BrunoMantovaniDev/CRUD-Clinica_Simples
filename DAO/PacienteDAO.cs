using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Clinica
{
    internal class PacienteDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            Paciente paciente;
            BancodeDados bd = new BancodeDados();
            string sql = "SELECT * FROM pacientes order by codp desc";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    paciente = new Paciente();
                    paciente.codp   =   int.Parse(rdr[0].ToString());
                    paciente.nome   =   rdr[1].ToString();
                    paciente.idade  =   int.Parse(rdr[2].ToString());
                    paciente.cpf    =   rdr[3].ToString();
                    paciente.cidade =   rdr[4].ToString();
                    paciente.doenca =   rdr[5].ToString();
                    lista.Add(paciente);

                }
                rdr.Close();
            }
            catch
            {
                throw;
            }
            return lista;
        }

        public object create(object objeto)
        {
            Paciente paciente = (Paciente) objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO pacientes" +
                    "(nome,idade,cidade,cpf,doenca) " +
                    "VALUES(@nome,@idade,@cidade,@cpf,@doenca)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.doenca);
                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();

                int id = int.Parse(cmd.LastInsertedId.ToString());
                paciente.codp = id;

                MessageBox.Show(" Paciente: " + paciente.nome + " Inserido com Sucesso");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object delete(object chave)
        {
            Paciente paciente = (Paciente)chave;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from pacientes " +
                    "where codp=@codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codp", paciente.codp);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Feito exclusao do paciente: " + paciente.nome + " com Sucesso" );
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }

        public object read(object chave)
        {
            Paciente paciente = (Paciente)chave;
            Paciente doBanco = new Paciente();

            BancodeDados bd = new BancodeDados();
            string sql = "SELECT * FROM pacientes where codp = @codp";
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@codp", paciente.codp);

            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    doBanco.codp = int.Parse(rdr[0].ToString());
                    doBanco.nome = rdr[1].ToString();
                    doBanco.idade = int.Parse(rdr[2].ToString());
                    doBanco.cpf = rdr[3].ToString();
                    doBanco.cidade = rdr[4].ToString();
                    doBanco.doenca = rdr[5].ToString();
                }
            }
            catch
            {
                throw;
            }

            return doBanco;
        }

        public object update(object objeto)
        {
            Paciente paciente = (Paciente)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "update pacientes " +
                    "set nome=@nome," +
                    "idade=@idade," +
                    "cidade=@cidade," +
                    "cpf=@cpf," +
                    "doenca=@doenca " +
                    "where codp=@codp";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", paciente.nome);
                cmd.Parameters.AddWithValue("@idade", paciente.idade);
                cmd.Parameters.AddWithValue("@cidade", paciente.cidade);
                cmd.Parameters.AddWithValue("@cpf", paciente.cpf);
                cmd.Parameters.AddWithValue("@doenca", paciente.doenca);
                cmd.Parameters.AddWithValue("@codp", paciente.codp);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Atualização do Paciente: " + paciente.nome + " feito com sucesso");

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return paciente;
        }
    }
}
