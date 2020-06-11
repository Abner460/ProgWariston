using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLTotal
    {
        private DALTotal daltotal;
        public String mensagem = "";
        public BLLTotal(DALConexao cx)
        {
            this.daltotal = new DALTotal(cx);
        }

        public DataTable verificartotal()
        {
            if (!daltotal.mensagem.Equals(""))
            {
                this.mensagem = daltotal.mensagem;
            }
            return daltotal.Vefificatotal();
        }
    }
}
