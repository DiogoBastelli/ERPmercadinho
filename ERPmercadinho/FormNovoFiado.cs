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

namespace ERPmercadinho
{
    public partial class FormNovoFiado : Form
    {

        private int idCliente;

        public class ItemFiado
        {
            public int IdProduto { get; set; }
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }
        }

        private List<ItemFiado> itens = new List<ItemFiado>();
        public FormNovoFiado(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
        }

        
        private ItemFiado BuscarProduto(int codigo)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = "SELECT id, nome, preco FROM produtos WHERE codigo = @codigo";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new ItemFiado
                            {
                                IdProduto = Convert.ToInt32(reader["id"]),
                                Nome = reader["nome"].ToString(),
                                Preco = Convert.ToDecimal(reader["preco"]),
                                Quantidade = 1
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar produto: " + ex.Message);
                }
            }

            return null;
        }

        private void textBoxCodigoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(textBoxCodigoProduto.Text, out int codigo))
                {
                    var produto = BuscarProduto(codigo);

                    if (produto != null)
                    {
                        var existente = itens.FirstOrDefault(p => p.IdProduto == produto.IdProduto);

                        if (existente != null)
                        {
                            existente.Quantidade++;
                        }
                        else
                        {
                            itens.Add(produto);
                        }

                        dataGridViewItens.DataSource = null;
                        dataGridViewItens.DataSource = itens;

                        textBoxCodigoProduto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado");
                    }
                }

                e.SuppressKeyPress = true; 
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            int idFiado = CriarFiado(idCliente);

            if (idFiado <= 0)
            {
                MessageBox.Show("Erro ao criar fiado");
                return;
            }

            foreach (var item in itens)
            {
                InserirItemFiado(idFiado, item.IdProduto, item.Quantidade, item.Preco);
            }

            MessageBox.Show("Fiado salvo com sucesso!");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private int CriarFiado(int idCliente)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = "INSERT INTO fiado (id_cliente) VALUES (@idCliente); SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    int idFiado = Convert.ToInt32(cmd.ExecuteScalar());

                    return idFiado;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao criar fiado: " + ex.Message);
                    return -1;
                }
            }
        }

        private void InserirItemFiado(int idFiado, int idProduto, int quantidade, decimal preco)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = @"INSERT INTO fiado_itens 
                          (id_fiado, id_produto, quantidade, preco) 
                          VALUES (@idFiado, @idProduto, @quantidade, @preco)";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@idFiado", idFiado);
                    cmd.Parameters.AddWithValue("@idProduto", idProduto);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@preco", preco);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao inserir item: " + ex.Message);
                }
            }
        }

    }


}
