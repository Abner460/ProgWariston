using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALMedia
    {
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        DALConexao con;
        public MySqlDataReader dr;

        public DALMedia(DALConexao cn)
        {
            this.con = cn;
        }


        public DataTable VefificarMedia()
        {
            cmd.CommandText = "SELECT FORMAT(AVG(VrUn),2) AS 'Valor Médio' FROM Produtos";

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
