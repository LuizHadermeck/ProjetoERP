namespace AlasComercialERP.Forms
{
    partial class ProdutosForm
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
            this.cboFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.numEstoque = new System.Windows.Forms.NumericUpDown();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.numPrecoVenda = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoVenda = new System.Windows.Forms.Label();
            this.numPrecoCusto = new System.Windows.Forms.NumericUpDown();
            this.lblPrecoCusto = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDadosProduto = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.lblListaProdutos = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.formPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoCusto)).BeginInit();
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
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(27, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(334, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Cadastre, consulte e mantenha os produtos do estoque";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(24, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(250, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cadastro de Produtos";
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
            this.formPanel.Controls.Add(this.cboFornecedor);
            this.formPanel.Controls.Add(this.lblFornecedor);
            this.formPanel.Controls.Add(this.numEstoque);
            this.formPanel.Controls.Add(this.lblEstoque);
            this.formPanel.Controls.Add(this.numPrecoVenda);
            this.formPanel.Controls.Add(this.lblPrecoVenda);
            this.formPanel.Controls.Add(this.numPrecoCusto);
            this.formPanel.Controls.Add(this.lblPrecoCusto);
            this.formPanel.Controls.Add(this.txtDescricao);
            this.formPanel.Controls.Add(this.lblDescricao);
            this.formPanel.Controls.Add(this.txtNome);
            this.formPanel.Controls.Add(this.lblNome);
            this.formPanel.Controls.Add(this.lblDadosProduto);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Padding = new System.Windows.Forms.Padding(18);
            this.formPanel.Size = new System.Drawing.Size(336, 429);
            this.formPanel.TabIndex = 0;
            // 
            // cboFornecedor
            // 
            this.cboFornecedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFornecedor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFornecedor.FormattingEnabled = true;
            this.cboFornecedor.Location = new System.Drawing.Point(21, 377);
            this.cboFornecedor.Name = "cboFornecedor";
            this.cboFornecedor.Size = new System.Drawing.Size(294, 25);
            this.cboFornecedor.TabIndex = 12;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFornecedor.Location = new System.Drawing.Point(18, 357);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(77, 17);
            this.lblFornecedor.TabIndex = 11;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // numEstoque
            // 
            this.numEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numEstoque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numEstoque.Location = new System.Drawing.Point(21, 315);
            this.numEstoque.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numEstoque.Name = "numEstoque";
            this.numEstoque.Size = new System.Drawing.Size(294, 25);
            this.numEstoque.TabIndex = 10;
            this.numEstoque.ThousandsSeparator = true;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEstoque.Location = new System.Drawing.Point(18, 295);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(57, 17);
            this.lblEstoque.TabIndex = 9;
            this.lblEstoque.Text = "Estoque";
            // 
            // numPrecoVenda
            // 
            this.numPrecoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrecoVenda.DecimalPlaces = 2;
            this.numPrecoVenda.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPrecoVenda.Location = new System.Drawing.Point(21, 255);
            this.numPrecoVenda.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrecoVenda.Name = "numPrecoVenda";
            this.numPrecoVenda.Size = new System.Drawing.Size(294, 25);
            this.numPrecoVenda.TabIndex = 8;
            this.numPrecoVenda.ThousandsSeparator = true;
            // 
            // lblPrecoVenda
            // 
            this.lblPrecoVenda.AutoSize = true;
            this.lblPrecoVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrecoVenda.Location = new System.Drawing.Point(18, 235);
            this.lblPrecoVenda.Name = "lblPrecoVenda";
            this.lblPrecoVenda.Size = new System.Drawing.Size(102, 17);
            this.lblPrecoVenda.TabIndex = 7;
            this.lblPrecoVenda.Text = "Preco de Venda";
            // 
            // numPrecoCusto
            // 
            this.numPrecoCusto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPrecoCusto.DecimalPlaces = 2;
            this.numPrecoCusto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numPrecoCusto.Location = new System.Drawing.Point(21, 195);
            this.numPrecoCusto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPrecoCusto.Name = "numPrecoCusto";
            this.numPrecoCusto.Size = new System.Drawing.Size(294, 25);
            this.numPrecoCusto.TabIndex = 6;
            this.numPrecoCusto.ThousandsSeparator = true;
            // 
            // lblPrecoCusto
            // 
            this.lblPrecoCusto.AutoSize = true;
            this.lblPrecoCusto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrecoCusto.Location = new System.Drawing.Point(18, 175);
            this.lblPrecoCusto.Name = "lblPrecoCusto";
            this.lblPrecoCusto.Size = new System.Drawing.Size(100, 17);
            this.lblPrecoCusto.TabIndex = 5;
            this.lblPrecoCusto.Text = "Preco de Custo";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(21, 113);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(294, 47);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(18, 93);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(65, 17);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descricao";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNome.Location = new System.Drawing.Point(21, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(294, 25);
            this.txtNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(18, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblDadosProduto
            // 
            this.lblDadosProduto.AutoSize = true;
            this.lblDadosProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDadosProduto.Location = new System.Drawing.Point(17, 12);
            this.lblDadosProduto.Name = "lblDadosProduto";
            this.lblDadosProduto.Size = new System.Drawing.Size(134, 20);
            this.lblDadosProduto.TabIndex = 0;
            this.lblDadosProduto.Text = "Dados do Produto";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dgvProdutos);
            this.gridPanel.Controls.Add(this.lblListaProdutos);
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
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // lblListaProdutos
            // 
            this.lblListaProdutos.AutoSize = true;
            this.lblListaProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblListaProdutos.Location = new System.Drawing.Point(17, 12);
            this.lblListaProdutos.Name = "lblListaProdutos";
            this.lblListaProdutos.Size = new System.Drawing.Size(158, 20);
            this.lblListaProdutos.TabIndex = 0;
            this.lblListaProdutos.Text = "Produtos Cadastrados";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnFechar);
            this.actionPanel.Controls.Add(this.btnListar);
            this.actionPanel.Controls.Add(this.btnExcluir);
            this.actionPanel.Controls.Add(this.btnAlterar);
            this.actionPanel.Controls.Add(this.btnSalvar);
            this.actionPanel.Controls.Add(this.btnNovo);
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
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnListar.Location = new System.Drawing.Point(493, 14);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(101, 44);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcluir.Location = new System.Drawing.Point(375, 14);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 44);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAlterar.Location = new System.Drawing.Point(257, 14);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 44);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.Location = new System.Drawing.Point(139, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(101, 44);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnNovo.Location = new System.Drawing.Point(21, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(101, 44);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // ProdutosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(944, 613);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "ProdutosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoCusto)).EndInit();
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
        private System.Windows.Forms.ComboBox cboFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.NumericUpDown numEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.NumericUpDown numPrecoVenda;
        private System.Windows.Forms.Label lblPrecoVenda;
        private System.Windows.Forms.NumericUpDown numPrecoCusto;
        private System.Windows.Forms.Label lblPrecoCusto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDadosProduto;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label lblListaProdutos;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
    }
}
