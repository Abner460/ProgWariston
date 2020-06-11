namespace ProgAtividade
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
            this.button1Clientes = new System.Windows.Forms.Button();
            this.button2Pedidos = new System.Windows.Forms.Button();
            this.button3Media = new System.Windows.Forms.Button();
            this.button4Total = new System.Windows.Forms.Button();
            this.button5Itens = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridUm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUm)).BeginInit();
            this.SuspendLayout();
            // 
            // button1Clientes
            // 
            this.button1Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Clientes.Location = new System.Drawing.Point(12, 32);
            this.button1Clientes.Name = "button1Clientes";
            this.button1Clientes.Size = new System.Drawing.Size(91, 51);
            this.button1Clientes.TabIndex = 0;
            this.button1Clientes.Text = "Clientes por nome";
            this.button1Clientes.UseVisualStyleBackColor = true;
            this.button1Clientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Pedidos
            // 
            this.button2Pedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Pedidos.Location = new System.Drawing.Point(128, 32);
            this.button2Pedidos.Name = "button2Pedidos";
            this.button2Pedidos.Size = new System.Drawing.Size(94, 51);
            this.button2Pedidos.TabIndex = 1;
            this.button2Pedidos.Text = "Pedidos e Clientes";
            this.button2Pedidos.UseVisualStyleBackColor = true;
            this.button2Pedidos.Click += new System.EventHandler(this.button2Pedidos_Click);
            // 
            // button3Media
            // 
            this.button3Media.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3Media.Location = new System.Drawing.Point(247, 32);
            this.button3Media.Name = "button3Media";
            this.button3Media.Size = new System.Drawing.Size(106, 51);
            this.button3Media.TabIndex = 2;
            this.button3Media.Text = "Valor Médio Produtos";
            this.button3Media.UseVisualStyleBackColor = true;
            this.button3Media.Click += new System.EventHandler(this.button3Media_Click);
            // 
            // button4Total
            // 
            this.button4Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4Total.Location = new System.Drawing.Point(379, 32);
            this.button4Total.Name = "button4Total";
            this.button4Total.Size = new System.Drawing.Size(106, 51);
            this.button4Total.TabIndex = 3;
            this.button4Total.Text = "Valor Total p/ Pedido";
            this.button4Total.UseVisualStyleBackColor = true;
            this.button4Total.Click += new System.EventHandler(this.button4Total_Click);
            // 
            // button5Itens
            // 
            this.button5Itens.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5Itens.Location = new System.Drawing.Point(508, 32);
            this.button5Itens.Name = "button5Itens";
            this.button5Itens.Size = new System.Drawing.Size(93, 51);
            this.button5Itens.TabIndex = 4;
            this.button5Itens.Text = "Itens Pedido 22";
            this.button5Itens.UseVisualStyleBackColor = true;
            this.button5Itens.Click += new System.EventHandler(this.button5Itens_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecione uma opção";
            // 
            // dataGridUm
            // 
            this.dataGridUm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridUm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUm.Location = new System.Drawing.Point(13, 101);
            this.dataGridUm.Name = "dataGridUm";
            this.dataGridUm.Size = new System.Drawing.Size(588, 124);
            this.dataGridUm.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 244);
            this.Controls.Add(this.dataGridUm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5Itens);
            this.Controls.Add(this.button4Total);
            this.Controls.Add(this.button3Media);
            this.Controls.Add(this.button2Pedidos);
            this.Controls.Add(this.button1Clientes);
            this.Name = "Form1";
            this.Text = "Listagem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Clientes;
        private System.Windows.Forms.Button button2Pedidos;
        private System.Windows.Forms.Button button3Media;
        private System.Windows.Forms.Button button4Total;
        private System.Windows.Forms.Button button5Itens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridUm;
    }
}

