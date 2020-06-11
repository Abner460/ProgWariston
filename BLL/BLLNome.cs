using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLNome
    {
        private DALNome dalnome;
        public String mensagem = "";
        public BLLNome(DALConexao cx)
        {
            this.dalnome = new DALNome(cx);
        }

        public DataTable verificar()
        {
            if (!dalnome.mensagem.Equals(""))
            {
                this.mensagem = dalnome.mensagem;
            }
            return dalnome.VefificarNome();
        }
    }
}
