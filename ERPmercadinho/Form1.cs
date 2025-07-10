using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ERPmercadinho
{
    public partial class Form1 : Form
    {

        private void CadastroProduto(int codigo, string nome, decimal preco)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM produtos WHERE codigo = @codigo OR nome = @nome";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conexao);
                    cmdCheck.Parameters.AddWithValue("@codigo", codigo);
                    cmdCheck.Parameters.AddWithValue("@nome", nome);

                    long count = (long)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um produto com este código ou nome.");
                        return;
                    }

                    string sql = "INSERT INTO produtos (codigo, nome, preco) " +
                                 "VALUES (@codigo, @nome, @preco)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    //cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@estoqueMinimo", 10);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto cadastrado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void CarregarProdutos()
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    string sql = "SELECT codigo, nome, preco, quantidade, estoqueMinimo FROM produtos";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    dataGridViewProdutos.DataSource = tabela;

                                  }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            this.Load += Form1CarregarProdutosEstoque;
        }
        private void Form1CarregarProdutosEstoque(object sender, EventArgs e)
        {
            CarregarProdutos(); 
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProduto_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            int codigo = int.Parse(textBoxCodigo.Text);
            decimal preco = decimal.Parse(textBoxPreco.Text);

            CadastroProduto(codigo, nome, preco);
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
