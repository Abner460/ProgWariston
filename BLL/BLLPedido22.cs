using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLPedido22
    {
        private DALPedido22 dalpedido;
        public String mensagem = "";
        public BLLPedido22(DALConexao cx)
        {
            this.dalpedido = new DALPedido22(cx);
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
