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
