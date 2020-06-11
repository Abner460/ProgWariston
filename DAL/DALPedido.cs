using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALPedido
    {
        public String mensagem = "";
        MySqlCommand cmd = new MySqlCommand();
        DALConexao con;
        public MySqlDataReader dr;

        public DALPedido(DALConexao cn)
        {
            this.con = cn;
        }


        public DataTable VefificaPedido()
        {
            cmd.CommandText = "SELECT c.Nome AS 'Cliente', p.Codigo AS 'Pedido' FROM Pedidos p INNER JOIN Clientes c ON c.Codigo = p.CodCliente";

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
