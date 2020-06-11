using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALTotal
    {
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        DALConexao con;
        public MySqlDataReader dr;

        public DALTotal(DALConexao cn)
        {
            this.con = cn;
        }


        public DataTable Vefificatotal()
        {
            cmd.CommandText = "SELECT i.CodPedido AS 'Pedido', FORMAT(SUM(i.Qtd * p.VrUn),2) AS 'Valor Total' FROM Produtos p INNER JOIN Pedido_Itens i ON p.Codigo = i.CodProduto GROUP BY i.CodPedido";

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
