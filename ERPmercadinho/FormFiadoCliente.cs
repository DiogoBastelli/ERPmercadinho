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
    public partial class FormFiadoCliente : Form
    {
        private int idCliente;

        public FormFiadoCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            this.Load += FormFiadoCliente_Load;

        }

        private void FormFiadoCliente_Load(object sender, EventArgs e)
        {
            CarregarItensFiadoCliente(idCliente);
            CarregarItensFiadoNaoPagos(idCliente);
            AtualizarDivida();
        }
        private void AtualizarDivida()
        {
            decimal divida = CalcularDivida(idCliente);
            labelValorTotalFiado.Text = divida.ToString("C");
        }
        private void CarregarItensFiadoCliente(int idCliente)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();

                    string sql = @"
                    SELECT 
                        f.data,
                        p.nome AS produto,
                        fi.quantidade,
                        (fi.quantidade * fi.preco) AS valor,
                         f.pago
                    FROM fiado f
                    JOIN fiado_itens fi ON f.id = fi.id_fiado
                    JOIN produtos p ON p.id = fi.id_produto
                    WHERE f.id_cliente = @idCliente
                    ORDER BY f.data DESC";

                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    dataGridViewFiados.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar itens do cliente: " + ex.Message);
                }
            }
        }

        private void CarregarItensFiadoNaoPagos(int idCliente)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    string sql = @"
                    SELECT 
                        f.data,
                        p.nome AS produto,
                        fi.quantidade,
                        (fi.quantidade * fi.preco) AS valor,
                         f.pago
                    FROM fiado f
                    JOIN fiado_itens fi ON f.id = fi.id_fiado
                    JOIN produtos p ON p.id = fi.id_produto
                    WHERE f.id_cliente = @idCliente
                    AND f.pago = 0
                    ORDER BY f.data DESC";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    dataGridViewFiadoPendente.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar itens Fiado em aberto: " + ex.Message);
                }
            }
        }

        private void buttonNovoFiado_Click(object sender, EventArgs e)
        {
            FormNovoFiado tela = new FormNovoFiado(idCliente);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                CarregarItensFiadoCliente(idCliente);
                AtualizarDivida();
                CarregarItensFiadoNaoPagos(idCliente);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private decimal CalcularDivida(int idCliente)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";

            using (var conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string sql = @"
            SELECT SUM(fi.quantidade * fi.preco)
            FROM fiado f
            JOIN fiado_itens fi ON f.id = fi.id_fiado
            WHERE f.id_cliente = @idCliente
            AND f.pago = 0";

                using (var cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado == DBNull.Value)
                        return 0;

                    return Convert.ToDecimal(resultado);
                }
            }
        }

        private void buttonPagamentoFiado_Click(object sender, EventArgs e)
        {
            PagarFiado(idCliente);
            CarregarItensFiadoNaoPagos(idCliente);
        }

        private void PagarFiado(int idCliente)
        {
            string conexaoString = "server=localhost;user=root;password=root;database=ERPmercadinho;";
            using (var conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                try
                {
                    string sql = "UPDATE fiado SET pago = 1 WHERE id_cliente = @idCliente ";
                    using (var cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@idCliente", idCliente);
                        cmd.ExecuteNonQuery();
                    }
                    CarregarItensFiadoCliente(idCliente);
                    AtualizarDivida();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Pagar Divida do fiado: " + ex.Message);
                }

            }
        }
    }
}
