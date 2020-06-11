using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MySql.Data.MySqlClient;

namespace BLL
{
    public class BLLPedido
    {
        private DALPedido dalpedido;
        public String mensagem = "";
        public BLLPedido(DALConexao cx)
        {
            this.dalpedido = new DALPedido(cx);
        }

        public DataTable verificar()
        {
            if (!dalpedido.mensagem.Equals(""))
            {
                this.mensagem = dalpedido.mensagem;
            }
            return dalpedido.VefificaPedido();
        }

    }
}
