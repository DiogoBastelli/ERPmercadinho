namespace ERPmercadinho
{
    partial class FormQuantidadeArmazenarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonArmazenar = new System.Windows.Forms.Button();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelResultadoPesquisa = new System.Windows.Forms.Label();
            this.labelResultadoPesquisa1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonArmazenar
            // 
            this.buttonArmazenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArmazenar.Location = new System.Drawing.Point(323, 258);
            this.buttonArmazenar.Name = "buttonArmazenar";
            this.buttonArmazenar.Size = new System.Drawing.Size(142, 41);
            this.buttonArmazenar.TabIndex = 23;
            this.buttonArmazenar.Text = "Guardar";
            this.buttonArmazenar.UseVisualStyleBackColor = true;
            this.buttonArmazenar.Click += new System.EventHandler(this.buttonArmazenar_Click);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(354, 198);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(197, 20);
            this.textBoxQuantidade.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(221, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Quantidade";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Produto Encontrado: ";
            // 
            // labelResultadoPesquisa
            // 
            this.labelResultadoPesquisa.AutoSize = true;
            this.labelResultadoPesquisa.Location = new System.Drawing.Point(390, 143);
            this.labelResultadoPesquisa.Name = "labelResultadoPesquisa";
            this.labelResultadoPesquisa.Size = new System.Drawing.Size(0, 13);
            this.labelResultadoPesquisa.TabIndex = 24;
            // 
            // labelResultadoPesquisa1
            // 
            this.labelResultadoPesquisa1.AutoSize = true;
            this.labelResultadoPesquisa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoPesquisa1.Location = new System.Drawing.Point(389, 143);
            this.labelResultadoPesquisa1.Name = "labelResultadoPesquisa1";
            this.labelResultadoPesquisa1.Size = new System.Drawing.Size(180, 20);
            this.labelResultadoPesquisa1.TabIndex = 25;
            this.labelResultadoPesquisa1.Text = "Produto Encontrado: ";
            this.labelResultadoPesquisa1.Click += new System.EventHandler(this.labelResultadoPesquisa1_Click);
            // 
            // FormQuantidadeArmazenarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResultadoPesquisa1);
            this.Controls.Add(this.labelResultadoPesquisa);
            this.Controls.Add(this.buttonArmazenar);
            this.Controls.Add(this.textBoxQuantidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Name = "FormQuantidadeArmazenarProduto";
            this.Text = "FormQuantidadeArmazenarProduto";
            this.Load += new System.EventHandler(this.FormQuantidadeArmazenarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArmazenar;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelResultadoPesquisa;
        private System.Windows.Forms.Label labelResultadoPesquisa1;
    }
}