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
        private Carrinho carrinho = new Carrinho();
        public TelaCaixa()
        {
            InitializeComponent();

        }
       
        decimal total = 0;
        
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
                    Produto produto = telaHome.PesquisarProdutoPorCodigo(codigo);

                    if (produto != null)
                    {
                        carrinho.AdicionarProduto(produto);

                        AtualizarGrid();
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

        private void AtualizarGrid()
        {
            dataGridViewProdutos.Rows.Clear();

            foreach (var item in carrinho.Itens)
            {
                dataGridViewProdutos.Rows.Add(
                    item.Produto.Codigo,
                    item.Produto.Nome,
                    item.Quantidade,
                    item.Produto.Preco,
                    item.Subtotal
                );
            }

            labelValorTotal.Text = carrinho.Total().ToString("C");
        }

        private void TelaCaixa_Load_1(object sender, EventArgs e)
        {
            dataGridViewProdutos.Columns.Add("codigo", "Código");
            dataGridViewProdutos.Columns.Add("produto", "Produto");
            dataGridViewProdutos.Columns.Add("quantidade", "Quantidade");
            dataGridViewProdutos.Columns.Add("preco", "Preço");
            dataGridViewProdutos.Columns.Add("subtotal", "Subtotal");

            dataGridViewProdutos.Columns["codigo"].Width = 120;
            dataGridViewProdutos.Columns["produto"].Width = 170;
            dataGridViewProdutos.Columns["quantidade"].Width = 160;
            dataGridViewProdutos.Columns["preco"].Width = 100;
            dataGridViewProdutos.Columns["subtotal"].Width = 130;

            dataGridViewProdutos.RowTemplate.Height = 35;

        }
    }
}
