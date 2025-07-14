namespace ERPmercadinho
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFormularioCadastroProduto = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.CadastrarProduto = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageEstoque = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCampoEditado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNovoValor = new System.Windows.Forms.TextBox();
            this.buttonAlterarProduto = new System.Windows.Forms.Button();
            this.textBoxCodigoAlterar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Armazenar = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxCodigoArmazenar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.TabControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.buttonCadastrarCliente = new System.Windows.Forms.Button();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxCpf = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabControlCadastroCliente = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFormularioCadastroProduto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Armazenar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Estoque.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControlCadastroCliente.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControlCadastroCliente);
            this.tabPage2.Location = new System.Drawing.Point(4, 52);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1863, 1002);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 52);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1863, 1002);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Produto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFormularioCadastroProduto);
            this.tabControl1.Controls.Add(this.tabPageEstoque);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.Armazenar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1836, 983);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageFormularioCadastroProduto
            // 
            this.tabPageFormularioCadastroProduto.BackColor = System.Drawing.Color.LightGray;
            this.tabPageFormularioCadastroProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageFormularioCadastroProduto.Controls.Add(this.panel1);
            this.tabPageFormularioCadastroProduto.Location = new System.Drawing.Point(4, 43);
            this.tabPageFormularioCadastroProduto.Name = "tabPageFormularioCadastroProduto";
            this.tabPageFormularioCadastroProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormularioCadastroProduto.Size = new System.Drawing.Size(1828, 936);
            this.tabPageFormularioCadastroProduto.TabIndex = 0;
            this.tabPageFormularioCadastroProduto.Text = "Cadastrar";
            this.tabPageFormularioCadastroProduto.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxPreco);
            this.panel1.Controls.Add(this.CadastrarProduto);
            this.panel1.Controls.Add(this.textBoxNome);
            this.panel1.Controls.Add(this.textBoxCodigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(464, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 583);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(145, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPreco.Location = new System.Drawing.Point(259, 332);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(197, 35);
            this.textBoxPreco.TabIndex = 6;
            // 
            // CadastrarProduto
            // 
            this.CadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarProduto.Location = new System.Drawing.Point(283, 467);
            this.CadastrarProduto.Name = "CadastrarProduto";
            this.CadastrarProduto.Size = new System.Drawing.Size(150, 64);
            this.CadastrarProduto.TabIndex = 1;
            this.CadastrarProduto.Text = "Cadastrar";
            this.CadastrarProduto.UseVisualStyleBackColor = true;
            this.CadastrarProduto.Click += new System.EventHandler(this.CadastrarProduto_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(259, 183);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(197, 35);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(259, 253);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(197, 35);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(145, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // tabPageEstoque
            // 
            this.tabPageEstoque.BackColor = System.Drawing.Color.LightGray;
            this.tabPageEstoque.Controls.Add(this.label9);
            this.tabPageEstoque.Controls.Add(this.dataGridViewProdutos);
            this.tabPageEstoque.Location = new System.Drawing.Point(4, 43);
            this.tabPageEstoque.Name = "tabPageEstoque";
            this.tabPageEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEstoque.Size = new System.Drawing.Size(1828, 936);
            this.tabPageEstoque.TabIndex = 1;
            this.tabPageEstoque.Text = "Estoque";
            this.tabPageEstoque.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "codigo";
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToResizeRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(0, 111);
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.ReadOnly = true;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(1828, 858);
            this.dataGridViewProdutos.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightGray;
            this.tabPage5.Controls.Add(this.panel2);
            this.tabPage5.Location = new System.Drawing.Point(4, 43);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1828, 936);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Alterar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.comboBoxCampoEditado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxNovoValor);
            this.panel2.Controls.Add(this.buttonAlterarProduto);
            this.panel2.Controls.Add(this.textBoxCodigoAlterar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel2.Location = new System.Drawing.Point(431, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 499);
            this.panel2.TabIndex = 9;
            // 
            // comboBoxCampoEditado
            // 
            this.comboBoxCampoEditado.FormattingEnabled = true;
            this.comboBoxCampoEditado.Items.AddRange(new object[] {
            "Nome",
            "Preço",
            "Quantidade Estoque",
            "Quantidade Minima"});
            this.comboBoxCampoEditado.Location = new System.Drawing.Point(303, 192);
            this.comboBoxCampoEditado.Name = "comboBoxCampoEditado";
            this.comboBoxCampoEditado.Size = new System.Drawing.Size(197, 28);
            this.comboBoxCampoEditado.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(127, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Codigo do Produto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(189, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Novo Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(279, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 0;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBoxNovoValor
            // 
            this.textBoxNovoValor.Location = new System.Drawing.Point(303, 251);
            this.textBoxNovoValor.Name = "textBoxNovoValor";
            this.textBoxNovoValor.Size = new System.Drawing.Size(197, 26);
            this.textBoxNovoValor.TabIndex = 6;
            // 
            // buttonAlterarProduto
            // 
            this.buttonAlterarProduto.Location = new System.Drawing.Point(268, 356);
            this.buttonAlterarProduto.Name = "buttonAlterarProduto";
            this.buttonAlterarProduto.Size = new System.Drawing.Size(150, 64);
            this.buttonAlterarProduto.TabIndex = 1;
            this.buttonAlterarProduto.Text = "Alterar";
            this.buttonAlterarProduto.UseVisualStyleBackColor = true;
            this.buttonAlterarProduto.Click += new System.EventHandler(this.buttonAlterarProduto_Click);
            // 
            // textBoxCodigoAlterar
            // 
            this.textBoxCodigoAlterar.Location = new System.Drawing.Point(303, 129);
            this.textBoxCodigoAlterar.Name = "textBoxCodigoAlterar";
            this.textBoxCodigoAlterar.Size = new System.Drawing.Size(197, 26);
            this.textBoxCodigoAlterar.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(110, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Campo a ser editado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Armazenar
            // 
            this.Armazenar.BackColor = System.Drawing.Color.LightGray;
            this.Armazenar.Controls.Add(this.panel3);
            this.Armazenar.Location = new System.Drawing.Point(4, 43);
            this.Armazenar.Name = "Armazenar";
            this.Armazenar.Padding = new System.Windows.Forms.Padding(3);
            this.Armazenar.Size = new System.Drawing.Size(1828, 936);
            this.Armazenar.TabIndex = 3;
            this.Armazenar.Text = "Armazenar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.textBoxCodigoArmazenar);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.buttonProximo);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(389, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 284);
            this.panel3.TabIndex = 17;
            // 
            // textBoxCodigoArmazenar
            // 
            this.textBoxCodigoArmazenar.Location = new System.Drawing.Point(286, 85);
            this.textBoxCodigoArmazenar.Name = "textBoxCodigoArmazenar";
            this.textBoxCodigoArmazenar.Size = new System.Drawing.Size(197, 26);
            this.textBoxCodigoArmazenar.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(110, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Codigo do Produto";
            // 
            // buttonProximo
            // 
            this.buttonProximo.Location = new System.Drawing.Point(250, 185);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(142, 41);
            this.buttonProximo.TabIndex = 10;
            this.buttonProximo.Text = "Proximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(172, -12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 9;
            // 
            // Estoque
            // 
            this.Estoque.Controls.Add(this.tabPage1);
            this.Estoque.Controls.Add(this.tabPage2);
            this.Estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estoque.Location = new System.Drawing.Point(2, 2);
            this.Estoque.Name = "Estoque";
            this.Estoque.Padding = new System.Drawing.Point(13, 10);
            this.Estoque.SelectedIndex = 0;
            this.Estoque.Size = new System.Drawing.Size(1871, 1058);
            this.Estoque.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.textBoxTelefone);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.textBoxEndereco);
            this.panel4.Controls.Add(this.buttonCadastrarCliente);
            this.panel4.Controls.Add(this.textBoxNomeCliente);
            this.panel4.Controls.Add(this.textBoxCpf);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel4.Location = new System.Drawing.Point(405, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 583);
            this.panel4.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(175, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 29);
            this.label11.TabIndex = 5;
            this.label11.Text = "Cpf";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(102, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "Endereco";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(220, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(240, 29);
            this.label14.TabIndex = 0;
            this.label14.Text = "Cadastro de cliente";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.Location = new System.Drawing.Point(259, 329);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(197, 35);
            this.textBoxEndereco.TabIndex = 6;
            // 
            // buttonCadastrarCliente
            // 
            this.buttonCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarCliente.Location = new System.Drawing.Point(259, 473);
            this.buttonCadastrarCliente.Name = "buttonCadastrarCliente";
            this.buttonCadastrarCliente.Size = new System.Drawing.Size(150, 64);
            this.buttonCadastrarCliente.TabIndex = 1;
            this.buttonCadastrarCliente.Text = "Cadastrar";
            this.buttonCadastrarCliente.UseVisualStyleBackColor = true;
            this.buttonCadastrarCliente.Click += new System.EventHandler(this.buttonCadastrarCliente_Click);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNomeCliente.Location = new System.Drawing.Point(259, 194);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(197, 35);
            this.textBoxNomeCliente.TabIndex = 2;
            // 
            // textBoxCpf
            // 
            this.textBoxCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCpf.Location = new System.Drawing.Point(259, 262);
            this.textBoxCpf.Name = "textBoxCpf";
            this.textBoxCpf.Size = new System.Drawing.Size(197, 35);
            this.textBoxCpf.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(145, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 29);
            this.label15.TabIndex = 3;
            this.label15.Text = "Nome";
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefone.Location = new System.Drawing.Point(259, 397);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(197, 35);
            this.textBoxTelefone.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(110, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 29);
            this.label16.TabIndex = 9;
            this.label16.Text = "Telefone";
            // 
            // tabControlCadastroCliente
            // 
            this.tabControlCadastroCliente.Controls.Add(this.tabPage3);
            this.tabControlCadastroCliente.Controls.Add(this.tabPage4);
            this.tabControlCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCadastroCliente.Location = new System.Drawing.Point(3, 3);
            this.tabControlCadastroCliente.Name = "tabControlCadastroCliente";
            this.tabControlCadastroCliente.Padding = new System.Drawing.Point(10, 10);
            this.tabControlCadastroCliente.SelectedIndex = 0;
            this.tabControlCadastroCliente.Size = new System.Drawing.Size(1821, 953);
            this.tabControlCadastroCliente.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1813, 906);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cadastrar";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1813, 906);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Estoque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFormularioCadastroProduto.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPageEstoque.ResumeLayout(false);
            this.tabPageEstoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Armazenar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Estoque.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControlCadastroCliente.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Estoque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFormularioCadastroProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button CadastrarProduto;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageEstoque;
        private System.Windows.Forms.DataGridView dataGridViewProdutos;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCampoEditado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNovoValor;
        private System.Windows.Forms.Button buttonAlterarProduto;
        private System.Windows.Forms.TextBox textBoxCodigoAlterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Armazenar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.TextBox textBoxCodigoArmazenar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Button buttonCadastrarCliente;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxCpf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControlCadastroCliente;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

