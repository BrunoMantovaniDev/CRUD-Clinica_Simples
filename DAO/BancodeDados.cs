using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Clinica
{
    internal class BancodeDados
    {
        static string conexao = "server=localhost;port=3306;" +
                "database=senai;uid=root;";
        public MySqlConnection conectar()
        {
            MySqlConnection connection = new MySqlConnection(conexao);
            connection.Open();
            return connection;

        }

    }
}
