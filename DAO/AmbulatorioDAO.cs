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
    internal class AmbulatorioDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList list = new ArrayList();
            BancodeDados bd = new BancodeDados();
            string sql = "SELECT * FROM ambulatorios ";
            Ambulatorio ambulatorio;
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());



            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ambulatorio = new Ambulatorio();
                    ambulatorio.nroa = int.Parse(rdr[0].ToString());
                    ambulatorio.andar = int.Parse(rdr[1].ToString());
                    ambulatorio.capacidade = int.Parse(rdr[2].ToString());
                    

                    list.Add(ambulatorio);
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
            
            BancodeDados bd = new BancodeDados();
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText =  @"INSERT INTO ambulatorios
                    (andar, capacidade) 
                    VALUES(@andar,@capacidade)
                    ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@andar", ambulatorio.andar);
                cmd.Parameters.AddWithValue("@capacidade", ambulatorio.capacidade);
                Console.WriteLine(cmd.Parameters[0].Value.ToString());
                cmd.ExecuteNonQuery();


                int id = int.Parse(cmd.LastInsertedId.ToString());
                ambulatorio.nroa = id;


                MessageBox.Show("Novo Ambulatorio inserido com Sucesso");
            }
            catch
            {
                throw;
            }
            return ambulatorio;
        }

        public object delete(object chave)
        {


            Ambulatorio ambulatorio = (Ambulatorio) chave;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "delete from ambulatorios " +
                    "where nroa=@nroa";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.nroa);
                cmd.ExecuteNonQuery();

                
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        
        }

        public object read(object chave)
        {
            throw new NotImplementedException();
        }

        public object update(object objeto)
        {
            Ambulatorio ambulatorio = (Ambulatorio)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;

                cmd.CommandText = @"
                    update ambulatorios 
                    set andar=@andar, capacidade=@capacidade
                    where nroa = @nroa
                ";

                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nroa", ambulatorio.nroa);
                cmd.Parameters.AddWithValue("@andar", ambulatorio.andar);
                cmd.Parameters.AddWithValue("@capacidade", ambulatorio.capacidade);
                
                cmd.ExecuteNonQuery();

                 MessageBox.Show("Atualização do funcionario feito com sucesso !!!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return ambulatorio;
        }
    }
}
