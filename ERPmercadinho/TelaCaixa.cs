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

                    for(int i = 0; i < dataGridViewProdutos.Rows.Count; i++)
                    {
                        if (dataGridViewProdutos.Rows[i].Cells[0].Value != null &&
                            dataGridViewProdutos.Rows[i].Cells[0].Value.ToString() == codigo.ToString())
                        {
                            int quantidadeAtual = Convert.ToInt32(dataGridViewProdutos.Rows[i].Cells[2].Value);
                            quantidadeAtual++;
                            dataGridViewProdutos.Rows[i].Cells[2].Value = quantidadeAtual;
                            decimal preco = Convert.ToDecimal(dataGridViewProdutos.Rows[i].Cells[3].Value);
                            dataGridViewProdutos.Rows[i].Cells[4].Value = preco * quantidadeAtual;
                            total += preco;
                            labelValorTotal.Text = $"R$ {total:F2}";
                            return;
                        }
                    }

                    if (produto != null)
                    {
                        produto.Quantidade = 1;
                        dataGridViewProdutos.Rows.Add(
                            produto.Codigo,
                            produto.Nome,
                            produto.Quantidade,
                            produto.Preco,
                            produto.Preco * produto.Quantidade
                        );


                        total += produto.Preco * produto.Quantidade;
                        labelValorTotal.Text = $"R$ {total:F2}";
                        
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
            dataGridViewProdutos.Columns.Add("codigo", "Código");
            dataGridViewProdutos.Columns.Add("produto", "Produto");
            dataGridViewProdutos.Columns.Add("quantidade", "Quantidade");
            dataGridViewProdutos.Columns.Add("preco", "Preço");
            dataGridViewProdutos.Columns.Add("subtotal", "Subtotal");

        }
    }
}
