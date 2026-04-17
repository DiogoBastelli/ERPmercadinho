namespace ERPmercadinho
{
    partial class FormFiadoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFiados = new System.Windows.Forms.DataGridView();
            this.buttonNovoFiado = new System.Windows.Forms.Button();
            this.labelValorTotalFiado = new System.Windows.Forms.Label();
            this.labelNomeClienteHistoricoFiado = new System.Windows.Forms.Label();
            this.buttonPagamentoFiado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewFiadoPendente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiadoPendente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(975, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(460, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewFiados
            // 
            this.dataGridViewFiados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiados.Location = new System.Drawing.Point(19, 117);
            this.dataGridViewFiados.Name = "dataGridViewFiados";
            this.dataGridViewFiados.Size = new System.Drawing.Size(587, 281);
            this.dataGridViewFiados.TabIndex = 3;
            // 
            // buttonNovoFiado
            // 
            this.buttonNovoFiado.Location = new System.Drawing.Point(116, 502);
            this.buttonNovoFiado.Name = "buttonNovoFiado";
            this.buttonNovoFiado.Size = new System.Drawing.Size(117, 52);
            this.buttonNovoFiado.TabIndex = 4;
            this.buttonNovoFiado.Text = "Novo Fiado";
            this.buttonNovoFiado.UseVisualStyleBackColor = true;
            this.buttonNovoFiado.Click += new System.EventHandler(this.buttonNovoFiado_Click);
            // 
            // labelValorTotalFiado
            // 
            this.labelValorTotalFiado.AutoSize = true;
            this.labelValorTotalFiado.BackColor = System.Drawing.Color.White;
            this.labelValorTotalFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorTotalFiado.ForeColor = System.Drawing.Color.Red;
            this.labelValorTotalFiado.Location = new System.Drawing.Point(1137, 591);
            this.labelValorTotalFiado.Name = "labelValorTotalFiado";
            this.labelValorTotalFiado.Size = new System.Drawing.Size(0, 25);
            this.labelValorTotalFiado.TabIndex = 5;
            // 
            // labelNomeClienteHistoricoFiado
            // 
            this.labelNomeClienteHistoricoFiado.AutoSize = true;
            this.labelNomeClienteHistoricoFiado.Location = new System.Drawing.Point(567, 42);
            this.labelNomeClienteHistoricoFiado.Name = "labelNomeClienteHistoricoFiado";
            this.labelNomeClienteHistoricoFiado.Size = new System.Drawing.Size(39, 13);
            this.labelNomeClienteHistoricoFiado.TabIndex = 6;
            this.labelNomeClienteHistoricoFiado.Text = "Cliente";
            // 
            // buttonPagamentoFiado
            // 
            this.buttonPagamentoFiado.Location = new System.Drawing.Point(305, 502);
            this.buttonPagamentoFiado.Name = "buttonPagamentoFiado";
            this.buttonPagamentoFiado.Size = new System.Drawing.Size(117, 52);
            this.buttonPagamentoFiado.TabIndex = 7;
            this.buttonPagamentoFiado.Text = "Pagar Divida";
            this.buttonPagamentoFiado.UseVisualStyleBackColor = true;
            this.buttonPagamentoFiado.Click += new System.EventHandler(this.buttonPagamentoFiado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "historico de Fiado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(846, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fiado Pendente";
            // 
            // dataGridViewFiadoPendente
            // 
            this.dataGridViewFiadoPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiadoPendente.Location = new System.Drawing.Point(650, 117);
            this.dataGridViewFiadoPendente.Name = "dataGridViewFiadoPendente";
            this.dataGridViewFiadoPendente.Size = new System.Drawing.Size(587, 281);
            this.dataGridViewFiadoPendente.TabIndex = 9;
            // 
            // FormFiadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 800);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewFiadoPendente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonPagamentoFiado);
            this.Controls.Add(this.labelNomeClienteHistoricoFiado);
            this.Controls.Add(this.labelValorTotalFiado);
            this.Controls.Add(this.buttonNovoFiado);
            this.Controls.Add(this.dataGridViewFiados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFiadoCliente";
            this.Text = "FormFiadoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiadoPendente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFiados;
        private System.Windows.Forms.Button buttonNovoFiado;
        private System.Windows.Forms.Label labelValorTotalFiado;
        private System.Windows.Forms.Label labelNomeClienteHistoricoFiado;
        private System.Windows.Forms.Button buttonPagamentoFiado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewFiadoPendente;
    }
}