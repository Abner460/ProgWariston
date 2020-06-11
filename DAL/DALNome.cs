using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALNome
    {
        public bool verificaCadastro = false;
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        DALConexao con;
        public MySqlDataReader dr;

        public DALNome(DALConexao cn)
        {
            this.con = cn;
        }


        public DataTable VefificarNome()
        {
            cmd.CommandText = "SELECT CPF_CNPJ, Nome FROM  Clientes ORDER BY Nome";

            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
            }
            catch (MySqlException erro)
            {
                this.mensagem = "Erro ao tentar ler o banco de dados" + erro;
            }
            return dt;
        }
    }
}
