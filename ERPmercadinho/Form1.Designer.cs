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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.CadastrarProduto = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Estoque = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Estoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1836, 983);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1828, 936);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Cadastrar";
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
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(145, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Preço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(255, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produto";
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(259, 332);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(197, 26);
            this.textBoxPreco.TabIndex = 6;
            // 
            // CadastrarProduto
            // 
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
            this.textBoxNome.Location = new System.Drawing.Point(259, 183);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(197, 26);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(259, 253);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(197, 26);
            this.textBoxCodigo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(145, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1828, 936);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Estoque";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 43);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1828, 936);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Produtos";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Estoque);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Estoque.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl Estoque;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button CadastrarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

