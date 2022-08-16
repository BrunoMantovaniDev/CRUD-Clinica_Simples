using Clinica.model;
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
    internal class ConsultaDAO : IDAO
    {
        public ArrayList all()
        {
            ArrayList lista = new ArrayList();
            string sql = "select m.*, p.*,c.data, c.hora  " +
                "from consultas c " +
                "join pacientes p on p.codp = c.codp " +
                "join medicos m on c.codm=m.codm " +
                "order by data desc ;";

            BancodeDados bd = new BancodeDados();
            Consulta consulta;
            Paciente paciente = new Paciente();
            Medico medico = new Medico();
            MySqlCommand cmd = new MySqlCommand(sql, bd.conectar());
            string data, hora;
            int nroa = 0;
            try
            {
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    consulta = new Consulta();
                    medico = new Medico();
                    paciente = new Paciente();

                    medico.codm = int.Parse(rdr[0].ToString());
                    medico.nome = rdr[1].ToString();
                    medico.idade = int.Parse(rdr[2].ToString());
                    medico.especialidade = rdr[3].ToString();
                    medico.cpf = rdr[4].ToString();
                    medico.cidade = rdr[5].ToString();
                    int.TryParse(rdr[6].ToString(), out nroa);
                    medico.nroa = nroa;

                    paciente.codp = int.Parse(rdr[7].ToString());
                    paciente.nome = rdr[8].ToString();
                    paciente.idade = int.Parse(rdr[9].ToString());
                    paciente.cpf = rdr[10].ToString();
                    paciente.cidade = rdr[11].ToString();
                    paciente.doenca = rdr[12].ToString();
                    data = rdr[13].ToString();
                    hora = rdr[14].ToString();
                    DateTime dataHora = new DateTime();



                    data = data.Split(' ')[0];
                    dataHora = DateTime.ParseExact(data + " " + hora,
                        "dd/MM/yyyy HH:mm:ss",
                        CultureInfo.InvariantCulture);

                    consulta.dataHora = dataHora;
                    consulta.medico = medico;
                    consulta.paciente = paciente;
                    lista.Add(consulta);

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
            Consulta consulta = (Consulta)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = "insert into consultas " +
                    "values(@codm,@codp,@data,@hora)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.medico.codm);
                cmd.Parameters.AddWithValue("@codp", consulta.paciente.codp);
                cmd.Parameters.AddWithValue("@data", consulta.dataHora.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hora", consulta.dataHora.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
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
            Consulta consulta = (Consulta)objeto;
            BancodeDados bd = new BancodeDados();
            MySqlConnection conn = bd.conectar();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                cmd.Connection = conn;
                cmd.CommandText = @"
                                update consultas
                                set data=@data, hora=@hora
                                where @codm = codm and @codp = codp
                ";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@codm", consulta.medico.codm);
                cmd.Parameters.AddWithValue("@codp", consulta.paciente.codp);
                cmd.Parameters.AddWithValue("@data", consulta.dataHora.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@hora", consulta.dataHora.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();


                MessageBox.Show("Feito Atualização da consulta");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            return consulta;
        }



    }
}
