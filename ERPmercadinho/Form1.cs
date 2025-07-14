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

        private bool CadastroProduto(int codigo, string nome, decimal preco)
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
                        return false;
                    }

                    string sql = "INSERT INTO produtos (codigo, nome, preco , estoqueMinimo ,quantidade ) " +
                                 "VALUES (@codigo, @nome, @preco , @estoqueMinimo ,@quantidade)";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@estoqueMinimo", 10);
                    cmd.Parameters.AddWithValue("@quantidade", 0);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto cadastrado com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    return false;
                }
            }
        }


        public void CarregarProdutos()
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
        private string PesquisarProdutoPorCodigo(int codigo)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    string sql = "SELECT codigo, nome FROM produtos WHERE codigo = @codigo";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string linha = $"Código: {reader["codigo"]} - Nome: {reader["nome"]}";
                        return linha;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produto: " + ex.Message);
                    return null;
                }
            }
        }


        private void AlterarProdutos(int codigo, string campoSelecionado, string novoValor)
        {

            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = $"UPDATE produtos SET {campoSelecionado} = @novoValor WHERE codigo = @codigo";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@novoValor", novoValor);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Produto alterado com sucesso!");
                        CarregarProdutos();
                    }
                    else MessageBox.Show("Produto não encontrado.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar produto: " + ex.Message);
                }
            }
        }

        private bool CadastrarCliente(string nomeCliente , string cpf , string telefone , string endereco)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";
            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sqlCheck = "SELECT COUNT(*) FROM cliente WHERE cpf = @cpf ";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conexao);
                    cmdCheck.Parameters.AddWithValue("@cpf", cpf);


                    long count = (long)cmdCheck.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Já existe um cliente cadastrado com esse Cpf");
                        return false;
                    }

                    string sql = "INSERT INTO cliente (nome, cpf, endereco, telefone) " +
                    "VALUES (@nomeCliente, @cpf, @endereco, @telefone)";


                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@telefone", telefone);
                    cmd.Parameters.AddWithValue("@endereco", endereco);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar cliente: " + ex.Message);
                    return false;   
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

            bool cadastro = CadastroProduto(codigo, nome, preco);
            if(cadastro)
            {
                textBoxNome.Clear();
                textBoxCodigo.Clear();
                textBoxPreco.Clear();
                CarregarProdutos();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void buttonAlterarProduto_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(textBoxCodigoAlterar.Text, out codigo))
            {
                MessageBox.Show("Código inválido.");
                return;
            }

            var mapaCampos = new Dictionary<string, string>()
            {
                { "Preço", "preco" },
                { "Nome", "nome" },
                { "Quantidade Estoque", "quantidade" },
                { "Quantidade Minima", "estoqueMinimo" }
            };

            string campoVisivel = comboBoxCampoEditado.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(campoVisivel) || !mapaCampos.ContainsKey(campoVisivel))
            {
                MessageBox.Show("Campo inválido.");
                return;
            }

            string campoBanco = mapaCampos[campoVisivel];
            string novoValor = textBoxNovoValor.Text;

            if (string.IsNullOrEmpty(novoValor))
            {
                MessageBox.Show("Informe o novo valor.");
                return;
            }

            AlterarProdutos(codigo, campoBanco, novoValor);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxCodigoArmazenar.Text, out int codigo))
            {
                string resultado = PesquisarProdutoPorCodigo(codigo);
                if (resultado != null)
                {
                    FormQuantidadeArmazenarProduto formArmazenar = new FormQuantidadeArmazenarProduto(resultado , codigo , this);
                    formArmazenar.ShowDialog();
                    textBoxCodigoArmazenar.Clear();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                    return;
                }
                

            }
            else
            {
                MessageBox.Show("Digite um código válido.");
            }
        }

        private void buttonCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nomeCliente = textBoxNomeCliente.Text;
            string cpf = textBoxCpf.Text;
            string telefone = textBoxTelefone.Text;
            string endereco = textBoxEndereco.Text;

            if (string.IsNullOrEmpty(nomeCliente) ||
                string.IsNullOrEmpty(cpf) ||
                string.IsNullOrEmpty(telefone) ||
                string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            bool cadastroCliente = CadastrarCliente(nomeCliente, cpf, telefone, endereco);
            if (cadastroCliente)
            {
                textBoxNomeCliente.Clear();
                textBoxCpf.Clear();
                textBoxTelefone.Clear();
                textBoxEndereco.Clear();
            }
        }
    }
}
