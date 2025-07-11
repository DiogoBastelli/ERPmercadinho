using MySql.Data.MySqlClient;
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
    public partial class FormQuantidadeArmazenarProduto: Form
    {
        private Form1 formPrincipal;
        private string produtoInfo;
        private int codigo;
        public FormQuantidadeArmazenarProduto(string produtoInfo , int codigo, Form1 formPrincipal)
        {
            InitializeComponent();
            this.produtoInfo = produtoInfo;
            this.codigo = codigo;
            this.formPrincipal = formPrincipal;
        }
        private void GuardarProduto(int quantidade)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = "UPDATE produtos SET quantidade = quantidade + @quantidade WHERE codigo = @codigo";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        string sqlSelect = "SELECT quantidade FROM produtos WHERE codigo = @codigo";
                        MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conexao);
                        cmdSelect.Parameters.AddWithValue("@codigo", codigo);
                        object quantidadeAtual = cmdSelect.ExecuteScalar();

                        MessageBox.Show($"Quantidade atualizada");
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado para atualização.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao armazenar produto: " + ex.Message);
                }
            }
        }




        private void FormQuantidadeArmazenarProduto_Load(object sender, EventArgs e)
        {
            labelResultadoPesquisa1.Text = produtoInfo;
        }

        private void buttonArmazenar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxQuantidade.Text, out int quantidade) && quantidade > 0)
            {
                GuardarProduto(quantidade);
                formPrincipal.CarregarProdutos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Digite uma quantidade válida.");
            }
        }

        private void labelResultadoPesquisa1_Click(object sender, EventArgs e)
        {

        }
    }
}
