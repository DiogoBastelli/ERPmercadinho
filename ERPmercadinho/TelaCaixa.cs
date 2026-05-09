using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPmercadinho
{
    public partial class TelaCaixa : Form
    {
        Form1 telaHome = new Form1();
        public TelaCaixa()
        {
            InitializeComponent();

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            telaHome.Show();
        }

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBox1.Text, out int codigo))
                {
                    Form1 telaHome = new Form1();
                    Produto produto = telaHome.PesquisarProdutoPorCodigo(codigo);

                    if (produto != null)
                    {
                        dataGridViewProdutos.Rows.Add(
                            produto.Codigo,
                            produto.Nome,
                            produto.Preco
                        );
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado");
                    }

                    textBox1.Clear();
                }
                else
                {
                    MessageBox.Show("Digite um código válido");
                }
            }
        }

        private void TelaCaixa_Load_1(object sender, EventArgs e)
        {
            dataGridViewProdutos.Columns.Clear();
            dataGridViewProdutos.Columns.Add("codigo", "Código");
            dataGridViewProdutos.Columns.Add("produto", "Produto");
            dataGridViewProdutos.Columns.Add("", "Produto");
        }
    }
}
