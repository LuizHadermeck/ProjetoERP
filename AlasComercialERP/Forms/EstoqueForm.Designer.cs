namespace AlasComercialERP.Forms
{
    partial class EstoqueForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.formPanel = new System.Windows.Forms.Panel();
            this.lblEstoqueAtualValor = new System.Windows.Forms.Label();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.numQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblMovimentacao = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).BeginInit();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.lblSubtitulo);
            this.headerPanel.Controls.Add(this.lblTitulo);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(24, 14, 24, 12);
            this.headerPanel.Size = new System.Drawing.Size(944, 82);
            this.headerPanel.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(330, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Controle entradas, saidas e saldos dos produtos";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(24, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Controle de Estoque";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.splitContainer);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 82);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(18, 16, 18, 12);
            this.contentPanel.Size = new System.Drawing.Size(944, 457);
            this.contentPanel.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(18, 16);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.formPanel);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.splitContainer.Panel1MinSize = 330;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.gridPanel);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.splitContainer.Panel2MinSize = 360;
            this.splitContainer.Size = new System.Drawing.Size(908, 429);
            this.splitContainer.SplitterDistance = 348;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 0;
            // 
            // formPanel
            // 
            this.formPanel.Controls.Add(this.lblEstoqueAtualValor);
            this.formPanel.Controls.Add(this.lblEstoqueAtual);
            this.formPanel.Controls.Add(this.numQuantidade);
            this.formPanel.Controls.Add(this.lblQuantidade);
            this.formPanel.Controls.Add(this.cboProduto);
            this.formPanel.Controls.Add(this.lblProduto);
            this.formPanel.Controls.Add(this.lblMovimentacao);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Padding = new System.Windows.Forms.Padding(18);
            this.formPanel.Size = new System.Drawing.Size(336, 429);
            this.formPanel.TabIndex = 0;
            // 
            // lblEstoqueAtualValor
            // 
            this.lblEstoqueAtualValor.AutoSize = true;
            this.lblEstoqueAtualValor.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold);
            this.lblEstoqueAtualValor.Location = new System.Drawing.Point(18, 164);
            this.lblEstoqueAtualValor.Name = "lblEstoqueAtualValor";
            this.lblEstoqueAtualValor.Size = new System.Drawing.Size(45, 51);
            this.lblEstoqueAtualValor.TabIndex = 6;
            this.lblEstoqueAtualValor.Text = "0";
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstoqueAtual.Location = new System.Drawing.Point(18, 143);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(88, 17);
            this.lblEstoqueAtual.TabIndex = 5;
            this.lblEstoqueAtual.Text = "Estoque atual";
            // 
            // numQuantidade
            // 
            this.numQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numQuantidade.Location = new System.Drawing.Point(21, 104);
            this.numQuantidade.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQuantidade.Name = "numQuantidade";
            this.numQuantidade.Size = new System.Drawing.Size(294, 25);
            this.numQuantidade.TabIndex = 4;
            this.numQuantidade.ThousandsSeparator = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQuantidade.Location = new System.Drawing.Point(18, 84);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(79, 17);
            this.lblQuantidade.TabIndex = 3;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // cboProduto
            // 
            this.cboProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(21, 43);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(294, 25);
            this.cboProduto.TabIndex = 2;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(18, 23);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(56, 17);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "Produto";
            // 
            // lblMovimentacao
            // 
            this.lblMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMovimentacao.AutoSize = true;
            this.lblMovimentacao.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblMovimentacao.Location = new System.Drawing.Point(17, 388);
            this.lblMovimentacao.Name = "lblMovimentacao";
            this.lblMovimentacao.Size = new System.Drawing.Size(173, 20);
            this.lblMovimentacao.TabIndex = 0;
            this.lblMovimentacao.Text = "Movimentacao de Estoque";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dgvProdutos);
            this.gridPanel.Controls.Add(this.lblProdutos);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(12, 0);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(18);
            this.gridPanel.Size = new System.Drawing.Size(547, 429);
            this.gridPanel.TabIndex = 0;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(21, 48);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(505, 360);
            this.dgvProdutos.TabIndex = 1;
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblProdutos.Location = new System.Drawing.Point(17, 12);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(134, 20);
            this.lblProdutos.TabIndex = 0;
            this.lblProdutos.Text = "Saldos de Produtos";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnFechar);
            this.actionPanel.Controls.Add(this.btnListar);
            this.actionPanel.Controls.Add(this.btnSaida);
            this.actionPanel.Controls.Add(this.btnEntrada);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 539);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Padding = new System.Windows.Forms.Padding(18, 10, 18, 16);
            this.actionPanel.Size = new System.Drawing.Size(944, 74);
            this.actionPanel.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Location = new System.Drawing.Point(825, 14);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 44);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnListar.Location = new System.Drawing.Point(257, 14);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 44);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnSaida
            // 
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaida.Location = new System.Drawing.Point(139, 14);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(101, 44);
            this.btnSaida.TabIndex = 1;
            this.btnSaida.Text = "Saida";
            this.btnSaida.UseVisualStyleBackColor = true;
            // 
            // btnEntrada
            // 
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnEntrada.Location = new System.Drawing.Point(21, 14);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(101, 44);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            // 
            // EstoqueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(944, 613);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "EstoqueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidade)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.gridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Label lblEstoqueAtualValor;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.NumericUpDown numQuantidade;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cboProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblMovimentacao;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.Button btnEntrada;
    }
}
