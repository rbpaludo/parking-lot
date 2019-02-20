namespace Estacionamento
{
    partial class Principal
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
            this.botaoEntrada = new System.Windows.Forms.Button();
            this.dataGridRegistros = new System.Windows.Forms.DataGridView();
            this.groupBoxEntrada = new System.Windows.Forms.GroupBox();
            this.textBoxPlacaEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlacaSaida = new System.Windows.Forms.TextBox();
            this.buttonSaida = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHoraInicial = new System.Windows.Forms.Label();
            this.labelHoraAdicional = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPesquisaPlaca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).BeginInit();
            this.groupBoxEntrada.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoEntrada
            // 
            this.botaoEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoEntrada.Location = new System.Drawing.Point(10, 95);
            this.botaoEntrada.Name = "botaoEntrada";
            this.botaoEntrada.Size = new System.Drawing.Size(113, 23);
            this.botaoEntrada.TabIndex = 0;
            this.botaoEntrada.Text = "Registrar Entrada";
            this.botaoEntrada.UseVisualStyleBackColor = true;
            this.botaoEntrada.Click += new System.EventHandler(this.botaoEntrada_Click);
            // 
            // dataGridRegistros
            // 
            this.dataGridRegistros.AllowUserToAddRows = false;
            this.dataGridRegistros.AllowUserToDeleteRows = false;
            this.dataGridRegistros.AllowUserToResizeRows = false;
            this.dataGridRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRegistros.Location = new System.Drawing.Point(12, 199);
            this.dataGridRegistros.MultiSelect = false;
            this.dataGridRegistros.Name = "dataGridRegistros";
            this.dataGridRegistros.ReadOnly = true;
            this.dataGridRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRegistros.Size = new System.Drawing.Size(593, 305);
            this.dataGridRegistros.TabIndex = 2;
            this.dataGridRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRegistros_CellClick);
            // 
            // groupBoxEntrada
            // 
            this.groupBoxEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEntrada.Controls.Add(this.label1);
            this.groupBoxEntrada.Controls.Add(this.textBoxPlacaEntrada);
            this.groupBoxEntrada.Controls.Add(this.botaoEntrada);
            this.groupBoxEntrada.Location = new System.Drawing.Point(623, 199);
            this.groupBoxEntrada.Name = "groupBoxEntrada";
            this.groupBoxEntrada.Size = new System.Drawing.Size(130, 132);
            this.groupBoxEntrada.TabIndex = 3;
            this.groupBoxEntrada.TabStop = false;
            this.groupBoxEntrada.Text = "Entrada";
            // 
            // textBoxPlacaEntrada
            // 
            this.textBoxPlacaEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlacaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlacaEntrada.Location = new System.Drawing.Point(10, 44);
            this.textBoxPlacaEntrada.Name = "textBoxPlacaEntrada";
            this.textBoxPlacaEntrada.Size = new System.Drawing.Size(113, 29);
            this.textBoxPlacaEntrada.TabIndex = 1;
            this.textBoxPlacaEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placa do Veículo";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxPlacaSaida);
            this.groupBox1.Controls.Add(this.buttonSaida);
            this.groupBox1.Location = new System.Drawing.Point(623, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 132);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa do Veículo";
            // 
            // textBoxPlacaSaida
            // 
            this.textBoxPlacaSaida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlacaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlacaSaida.Location = new System.Drawing.Point(10, 44);
            this.textBoxPlacaSaida.Name = "textBoxPlacaSaida";
            this.textBoxPlacaSaida.Size = new System.Drawing.Size(113, 29);
            this.textBoxPlacaSaida.TabIndex = 1;
            this.textBoxPlacaSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonSaida
            // 
            this.buttonSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaida.Location = new System.Drawing.Point(10, 95);
            this.buttonSaida.Name = "buttonSaida";
            this.buttonSaida.Size = new System.Drawing.Size(113, 23);
            this.buttonSaida.TabIndex = 0;
            this.buttonSaida.Text = "Registrar Saída";
            this.buttonSaida.UseVisualStyleBackColor = true;
            this.buttonSaida.Click += new System.EventHandler(this.botaoSaida_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelHoraAdicional);
            this.groupBox2.Controls.Add(this.labelHoraInicial);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(558, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 140);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preços";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Primeira Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hora Adicional";
            // 
            // labelHoraInicial
            // 
            this.labelHoraInicial.AutoSize = true;
            this.labelHoraInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraInicial.Location = new System.Drawing.Point(32, 51);
            this.labelHoraInicial.Name = "labelHoraInicial";
            this.labelHoraInicial.Size = new System.Drawing.Size(83, 20);
            this.labelHoraInicial.TabIndex = 2;
            this.labelHoraInicial.Text = "R$ 200,00";
            // 
            // labelHoraAdicional
            // 
            this.labelHoraAdicional.AutoSize = true;
            this.labelHoraAdicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraAdicional.Location = new System.Drawing.Point(32, 106);
            this.labelHoraAdicional.Name = "labelHoraAdicional";
            this.labelHoraAdicional.Size = new System.Drawing.Size(83, 20);
            this.labelHoraAdicional.TabIndex = 3;
            this.labelHoraAdicional.Text = "R$ 200,00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(450, 51);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estacionamento Legal";
            // 
            // textBoxPesquisaPlaca
            // 
            this.textBoxPesquisaPlaca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPesquisaPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPesquisaPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPlaca.Location = new System.Drawing.Point(12, 154);
            this.textBoxPesquisaPlaca.Name = "textBoxPesquisaPlaca";
            this.textBoxPesquisaPlaca.Size = new System.Drawing.Size(113, 29);
            this.textBoxPesquisaPlaca.TabIndex = 7;
            this.textBoxPesquisaPlaca.TextChanged += new System.EventHandler(this.textBoxPesquisaPlaca_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Placa do Veículo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(588, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nova Tabela de Preços";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPesquisaPlaca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxEntrada);
            this.Controls.Add(this.dataGridRegistros);
            this.Name = "Principal";
            this.Text = "Estacionamento";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRegistros)).EndInit();
            this.groupBoxEntrada.ResumeLayout(false);
            this.groupBoxEntrada.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoEntrada;
        private System.Windows.Forms.DataGridView dataGridRegistros;
        private System.Windows.Forms.GroupBox groupBoxEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlacaEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlacaSaida;
        private System.Windows.Forms.Button buttonSaida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelHoraAdicional;
        private System.Windows.Forms.Label labelHoraInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPesquisaPlaca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

