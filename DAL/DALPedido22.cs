using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALPedido22
    {
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        DALConexao con;
        public MySqlDataReader dr;

        public DALPedido22(DALConexao cn)
        {
            this.con = cn;
        }


        public DataTable VefificaPedido()
        {
            cmd.CommandText = "SELECT p.Descricao AS 'Produto', p.VrUn, i.Qtd, FORMAT((p.VrUn * i.Qtd),2) AS 'Total' FROM Produtos p INNER JOIN Pedido_Itens i ON p.Codigo = i.CodProduto WHERE i.CodPedido = 22";

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
