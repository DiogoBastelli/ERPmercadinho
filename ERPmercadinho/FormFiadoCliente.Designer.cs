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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFiados = new System.Windows.Forms.DataGridView();
            this.buttonNovoFiado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 626);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(557, 626);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
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
            this.dataGridViewFiados.Location = new System.Drawing.Point(108, 117);
            this.dataGridViewFiados.Name = "dataGridViewFiados";
            this.dataGridViewFiados.Size = new System.Drawing.Size(784, 281);
            this.dataGridViewFiados.TabIndex = 3;
            // 
            // buttonNovoFiado
            // 
            this.buttonNovoFiado.Location = new System.Drawing.Point(932, 359);
            this.buttonNovoFiado.Name = "buttonNovoFiado";
            this.buttonNovoFiado.Size = new System.Drawing.Size(117, 52);
            this.buttonNovoFiado.TabIndex = 4;
            this.buttonNovoFiado.Text = "Novo Fiado";
            this.buttonNovoFiado.UseVisualStyleBackColor = true;
            this.buttonNovoFiado.Click += new System.EventHandler(this.buttonNovoFiado_Click);
            // 
            // FormFiadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 800);
            this.Controls.Add(this.buttonNovoFiado);
            this.Controls.Add(this.dataGridViewFiados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormFiadoCliente";
            this.Text = "FormFiadoCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFiados;
        private System.Windows.Forms.Button buttonNovoFiado;
    }
}