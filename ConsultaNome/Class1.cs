using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaNome
{
    public class ConsultaNome
    {
        MySqlConnectionStringBuilder string_con = new MySqlConnectionStringBuilder();
        string_con.Server = "sql10.freesqldatabase.com";
            string_con.Database = "6UPAWT1quh";
            string_con.UserID = "6UPAWT1quh";
            string_con.Password = "gYNZWUjBja";

            MySqlConnection conexao = new MySqlConnection();
        conexao.ConnectionString = string_con.ConnectionString;

            conexao.Open();

            MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = conexao;

            cmd.CommandText = "SELECT Nome, CPF_CNPJ FROM Clientes ORDER BY Nome";

            MySqlDataReader rd = cmd.ExecuteReader();

        DataTable dt = new DataTable();
        dt.Load(rd);

            FormNome formNome = new FormNome();

        formNome.

        conexao.Close();
    }
}
