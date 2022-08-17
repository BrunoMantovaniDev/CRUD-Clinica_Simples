using Clinica.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica.DAO
{
    internal class DependenteDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            string sql = @"SELECT D.*, F.nome 
                            FROM dependetes AS D
                            JOIN funcionarios AS F ON F.codf = D.codf
                            ORDER BY codf asc
                            ;";

            BancodeDados bd = new BancodeDados();
            Dependente dependente;
            Funcionario funcionario = new Funcionario();
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            ;
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dependente = new Dependente();
                    funcionario = new Funcionario();


                    dependente.codd = int.Parse(rdr[0].ToString());
                    dependente.nome = rdr[1].ToString();
                    dependente.nascimento = Convert.ToDateTime(rdr[2]).ToString("dd/MM/yyyy");
                    funcionario.nome = rdr[4].ToString();
                    funcionario.codf = int.Parse( rdr[3].ToString());
                    dependente.funcionario = funcionario;
                    
                    lista.Add(dependente);

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
            
            
                Dependente dependente = (Dependente)objeto;
                BancodeDados bd = new BancodeDados();
                MySqlConnection conn = bd.conectar();
                MySqlCommand cmd = new MySqlCommand();

                try
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"insert into dependetes  (nome, nascimento, codf)
                        values(@nome,@nascimento,@codf)";
                    cmd.Prepare();
                    
                    cmd.Parameters.AddWithValue("@nome", dependente.nome);
                    cmd.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(dependente.nascimento));
                    cmd.Parameters.AddWithValue("@codf", dependente.funcionario.codf);
                    
                    cmd.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    throw ex;
                }
                return dependente;
            
        }

        public object delete(object chave)
        {
            Dependente dependente = (Dependente)chave;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                    delete from dependetes  
                    where codd=@codd
                    ";
                cmd.Prepare();

                
                cmd.Parameters.AddWithValue("@codd", dependente.codd);
                cmd.ExecuteNonQuery();


            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dependente;
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            Dependente dependente = (Dependente)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                                update dependetes
                                set nome=@nome, nascimento=@nascimento, codf=codf
                                where @codd = codd 
                ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codd", dependente.codd);
                cmd.Parameters.AddWithValue("@nome", dependente.nome);
                cmd.Parameters.AddWithValue("@nascimento", Convert.ToDateTime(dependente.nascimento));
                cmd.Parameters.AddWithValue("@codf", dependente.funcionario.codf);


                cmd.ExecuteNonQuery();


                MessageBox.Show("Feito Atualização de dependente");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return dependente;
        }
    }
}
