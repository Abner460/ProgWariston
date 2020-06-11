using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLMedia
    {
        private DALMedia dalmedia;
        public String mensagem = "";
        public BLLMedia(DALConexao cx)
        {
            this.dalmedia = new DALMedia(cx);
        }

        public DataTable verificar()
        {
            if (!dalmedia.mensagem.Equals(""))
            {
                this.mensagem = dalmedia.mensagem;
            }
            return dalmedia.VefificarMedia();
        }
    }
}
