namespace AlasComercialERP.Forms
{
    partial class SobreForm
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCopyrightValor = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblEmpresaValor = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblVersaoValor = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblProdutoValor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.modulesPanel = new System.Windows.Forms.Panel();
            this.lblModuloSistema = new System.Windows.Forms.Label();
            this.lblModuloEstoque = new System.Windows.Forms.Label();
            this.lblModuloRelatorios = new System.Windows.Forms.Label();
            this.lblModuloCadastros = new System.Windows.Forms.Label();
            this.lblModulos = new System.Windows.Forms.Label();
            this.actionPanel = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.modulesPanel.SuspendLayout();
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
            this.lblSubtitulo.Size = new System.Drawing.Size(288, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Informacoes gerais e modulos do sistema";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(24, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.infoPanel);
            this.contentPanel.Controls.Add(this.modulesPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 82);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(18, 16, 18, 12);
            this.contentPanel.Size = new System.Drawing.Size(944, 457);
            this.contentPanel.TabIndex = 1;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.White;
            this.infoPanel.Controls.Add(this.txtDescricao);
            this.infoPanel.Controls.Add(this.lblDescricao);
            this.infoPanel.Controls.Add(this.lblCopyrightValor);
            this.infoPanel.Controls.Add(this.lblCopyright);
            this.infoPanel.Controls.Add(this.lblEmpresaValor);
            this.infoPanel.Controls.Add(this.lblEmpresa);
            this.infoPanel.Controls.Add(this.lblVersaoValor);
            this.infoPanel.Controls.Add(this.lblVersao);
            this.infoPanel.Controls.Add(this.lblProdutoValor);
            this.infoPanel.Controls.Add(this.lblProduto);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoPanel.Location = new System.Drawing.Point(18, 16);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Padding = new System.Windows.Forms.Padding(22);
            this.infoPanel.Size = new System.Drawing.Size(600, 429);
            this.infoPanel.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescricao.Location = new System.Drawing.Point(25, 220);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(550, 184);
            this.txtDescricao.TabIndex = 9;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.Location = new System.Drawing.Point(22, 194);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(72, 19);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descricao";
            // 
            // lblCopyrightValor
            // 
            this.lblCopyrightValor.AutoSize = true;
            this.lblCopyrightValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblCopyrightValor.Location = new System.Drawing.Point(145, 144);
            this.lblCopyrightValor.Name = "lblCopyrightValor";
            this.lblCopyrightValor.Size = new System.Drawing.Size(73, 20);
            this.lblCopyrightValor.TabIndex = 7;
            this.lblCopyrightValor.Text = "Copyright";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCopyright.Location = new System.Drawing.Point(22, 146);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(72, 19);
            this.lblCopyright.TabIndex = 6;
            this.lblCopyright.Text = "Copyright";
            // 
            // lblEmpresaValor
            // 
            this.lblEmpresaValor.AutoSize = true;
            this.lblEmpresaValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblEmpresaValor.Location = new System.Drawing.Point(145, 104);
            this.lblEmpresaValor.Name = "lblEmpresaValor";
            this.lblEmpresaValor.Size = new System.Drawing.Size(65, 20);
            this.lblEmpresaValor.TabIndex = 5;
            this.lblEmpresaValor.Text = "Empresa";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.Location = new System.Drawing.Point(22, 106);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(62, 19);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblVersaoValor
            // 
            this.lblVersaoValor.AutoSize = true;
            this.lblVersaoValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblVersaoValor.Location = new System.Drawing.Point(145, 64);
            this.lblVersaoValor.Name = "lblVersaoValor";
            this.lblVersaoValor.Size = new System.Drawing.Size(52, 20);
            this.lblVersaoValor.TabIndex = 3;
            this.lblVersaoValor.Text = "Versao";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblVersao.Location = new System.Drawing.Point(22, 66);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(52, 19);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.Text = "Versao";
            // 
            // lblProdutoValor
            // 
            this.lblProdutoValor.AutoSize = true;
            this.lblProdutoValor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblProdutoValor.Location = new System.Drawing.Point(145, 24);
            this.lblProdutoValor.Name = "lblProdutoValor";
            this.lblProdutoValor.Size = new System.Drawing.Size(62, 20);
            this.lblProdutoValor.TabIndex = 1;
            this.lblProdutoValor.Text = "Produto";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblProduto.Location = new System.Drawing.Point(22, 26);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(61, 19);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // modulesPanel
            // 
            this.modulesPanel.BackColor = System.Drawing.Color.White;
            this.modulesPanel.Controls.Add(this.lblModuloSistema);
            this.modulesPanel.Controls.Add(this.lblModuloEstoque);
            this.modulesPanel.Controls.Add(this.lblModuloRelatorios);
            this.modulesPanel.Controls.Add(this.lblModuloCadastros);
            this.modulesPanel.Controls.Add(this.lblModulos);
            this.modulesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.modulesPanel.Location = new System.Drawing.Point(636, 16);
            this.modulesPanel.Name = "modulesPanel";
            this.modulesPanel.Padding = new System.Windows.Forms.Padding(22);
            this.modulesPanel.Size = new System.Drawing.Size(290, 429);
            this.modulesPanel.TabIndex = 1;
            // 
            // lblModuloSistema
            // 
            this.lblModuloSistema.AutoSize = true;
            this.lblModuloSistema.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModuloSistema.Location = new System.Drawing.Point(25, 152);
            this.lblModuloSistema.Name = "lblModuloSistema";
            this.lblModuloSistema.Size = new System.Drawing.Size(167, 19);
            this.lblModuloSistema.TabIndex = 4;
            this.lblModuloSistema.Text = "Sistema e informacoes";
            // 
            // lblModuloEstoque
            // 
            this.lblModuloEstoque.AutoSize = true;
            this.lblModuloEstoque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModuloEstoque.Location = new System.Drawing.Point(25, 116);
            this.lblModuloEstoque.Name = "lblModuloEstoque";
            this.lblModuloEstoque.Size = new System.Drawing.Size(177, 19);
            this.lblModuloEstoque.TabIndex = 3;
            this.lblModuloEstoque.Text = "Controle de estoque";
            // 
            // lblModuloRelatorios
            // 
            this.lblModuloRelatorios.AutoSize = true;
            this.lblModuloRelatorios.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModuloRelatorios.Location = new System.Drawing.Point(25, 80);
            this.lblModuloRelatorios.Name = "lblModuloRelatorios";
            this.lblModuloRelatorios.Size = new System.Drawing.Size(172, 19);
            this.lblModuloRelatorios.TabIndex = 2;
            this.lblModuloRelatorios.Text = "Relatorios gerenciais";
            // 
            // lblModuloCadastros
            // 
            this.lblModuloCadastros.AutoSize = true;
            this.lblModuloCadastros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblModuloCadastros.Location = new System.Drawing.Point(25, 44);
            this.lblModuloCadastros.Name = "lblModuloCadastros";
            this.lblModuloCadastros.Size = new System.Drawing.Size(204, 19);
            this.lblModuloCadastros.TabIndex = 1;
            this.lblModuloCadastros.Text = "Cadastros comerciais";
            // 
            // lblModulos
            // 
            this.lblModulos.AutoSize = true;
            this.lblModulos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblModulos.Location = new System.Drawing.Point(21, 14);
            this.lblModulos.Name = "lblModulos";
            this.lblModulos.Size = new System.Drawing.Size(142, 20);
            this.lblModulos.TabIndex = 0;
            this.lblModulos.Text = "Modulos principais";
            // 
            // actionPanel
            // 
            this.actionPanel.Controls.Add(this.btnFechar);
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
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // SobreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(944, 613);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "SobreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.modulesPanel.ResumeLayout(false);
            this.modulesPanel.PerformLayout();
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCopyrightValor;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblEmpresaValor;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblVersaoValor;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblProdutoValor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Panel modulesPanel;
        private System.Windows.Forms.Label lblModuloSistema;
        private System.Windows.Forms.Label lblModuloEstoque;
        private System.Windows.Forms.Label lblModuloRelatorios;
        private System.Windows.Forms.Label lblModuloCadastros;
        private System.Windows.Forms.Label lblModulos;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button btnFechar;
    }
}
