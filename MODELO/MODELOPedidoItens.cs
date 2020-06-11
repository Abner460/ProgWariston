using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class MODELOPedidoItens
    {
        private int Codigo;
        private int CodPedido;
        private int CodProduto;
        private double Qtd;

        public int Codigo1 { get => Codigo; set => Codigo = value; }
        public int CodPedido1 { get => CodPedido; set => CodPedido = value; }
        public int CodProduto1 { get => CodProduto; set => CodProduto = value; }
        public double Qtd1 { get => Qtd; set => Qtd = value; }
    }
}
