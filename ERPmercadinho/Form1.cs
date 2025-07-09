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

        string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";
        private void CadastroProduto(int codigo, string nome, decimal preco)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

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

        public Form1()
        {
            InitializeComponent();
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
    }
}
