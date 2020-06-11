using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALConexao
    {
        private string strConexao;
        private MySqlConnection conexao;

        public DALConexao(string dadosDaconexao)
        {
            conexao = new MySqlConnection();
            strConexao = dadosDaconexao;
            conexao.ConnectionString = strConexao;
        }

        public MySqlConnection ObjConexao
        {
            get { return conexao; }
            set { conexao = value; }
        }

        public MySqlConnection Conectar()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }

        public void Desconectar()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
