using Clinica.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Clinica.DAO
{
    internal class MedicoDAO : IDAO
    {

        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            string sql = "select * from medicos";
            BancodeDados bd = new BancodeDados();
            Medico medico;
            int nroa;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    medico = new Medico();
                    medico.codm = int.Parse(rdr[0].ToString());
                    medico.nome = rdr[1].ToString();
                    medico.idade = int.Parse(rdr[2].ToString());
                    medico.especialidade = rdr[3].ToString();
                    medico.cpf = rdr[4].ToString();
                    medico.cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    medico.nroa = nroa;
                    lista.Add(medico);

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
            Medico medico = (Medico)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                    INSERT INTO medicos (nome,idade,especialidade,cpf,cidade,nroa) 
                    VALUES(@nome,@idade,@especialidade,@cpf,@cidade,@nroa) 
                 ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nome", medico.nome);
                cmd.Parameters.AddWithValue("@idade", medico.idade);
                cmd.Parameters.AddWithValue("@especialidade", medico.especialidade);
                cmd.Parameters.AddWithValue("@cpf", medico.cpf);
                cmd.Parameters.AddWithValue("@cidade", medico.cidade);
                cmd.Parameters.AddWithValue("@nroa", medico.nroa);
                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();

                int id = int.Parse(cmd.LastInsertedId.ToString());
                medico.codm = id;

                MessageBox.Show(" Paciente: " + medico.nome + " Inserido com Sucesso");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }

        public object delete(object chave)
        {
            Medico medico = (Medico)chave;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from medicos " +
                    "where codm=@codm";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", medico.codm);
                cmd.ExecuteNonQuery();

                MessageBox.Show(" Feito exclusao do medico: " + medico.nome + " com Sucesso");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }

        public object read(object chave)
        {
            string sql = "select * from medicos where codm = @codm";
            BancodeDados bd = new BancodeDados();
            Medico medico = (Medico)chave;

            Medico doBanco = new Medico();
            int nroa;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            cmd.Prepare();
            cmd.Parameters.AddWithValue("@codm", medico.codm);
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    doBanco.codm = int.Parse(rdr[0].ToString());
                    doBanco.nome = rdr[1].ToString();
                    doBanco.idade = int.Parse(rdr[2].ToString());
                    doBanco.especialidade = rdr[3].ToString();
                    doBanco.cpf = rdr[4].ToString();
                    doBanco.cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    doBanco.nroa = nroa;

                }
                rdr.Close();
            }
            catch
            {
                throw;
            }



            return doBanco;
        }

        public object update(object objeto)
        {
            Medico medico = (Medico)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                    update medicos 
                    set nome=@nome, idade=@idade ,especialidade=@especialidade ,cpf=@cpf ,cidade=@cidade , nroa=@nroa  
                    where codm=@codm
                 ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", medico.codm);
                cmd.Parameters.AddWithValue("@nome", medico.nome);
                cmd.Parameters.AddWithValue("@idade", medico.idade);
                cmd.Parameters.AddWithValue("@especialidade", medico.especialidade);
                cmd.Parameters.AddWithValue("@cpf", medico.cpf);
                cmd.Parameters.AddWithValue("@cidade", medico.cidade);
                cmd.Parameters.AddWithValue("@nroa", medico.nroa);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Atualização do Medico: " + medico.nome + " feito com sucesso");

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return medico;
        }




    }
}
