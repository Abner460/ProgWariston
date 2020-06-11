using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using DAL;
using MODELO;
using BLL;

namespace ProgAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao con = new DALConexao(dc.StringDeConexao);

             BLLNome controle = new BLLNome(con);

            if (controle.mensagem.Equals(""))
            {
                dataGridUm.DataSource = controle.verificar();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void button5Itens_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao con = new DALConexao(dc.StringDeConexao);

            BLLPedido22 controle = new BLLPedido22(con);

            if (controle.mensagem.Equals(""))
            {
                dataGridUm.DataSource = controle.verificar();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void button2Pedidos_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao con = new DALConexao(dc.StringDeConexao);

            BLLPedido controle = new BLLPedido(con);

            if (controle.mensagem.Equals(""))
            {
                dataGridUm.DataSource = controle.verificar();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void button3Media_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao con = new DALConexao(dc.StringDeConexao);

            BLLMedia controle = new BLLMedia(con);

            if (controle.mensagem.Equals(""))
            {
                dataGridUm.DataSource = controle.verificar();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void button4Total_Click(object sender, EventArgs e)
        {
            DadosDaConexao dc = new DadosDaConexao();
            DALConexao con = new DALConexao(dc.StringDeConexao);

            BLLTotal controle = new BLLTotal(con);

            if (controle.mensagem.Equals(""))
            {
                dataGridUm.DataSource = controle.verificartotal();
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
 }
