namespace AlasComercialERP.Forms
{
    partial class RelatoriosForm
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
            this.summaryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cardProdutos = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.lblCardProdutos = new System.Windows.Forms.Label();
            this.cardClientes = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.lblCardClientes = new System.Windows.Forms.Label();
            this.cardVendas = new System.Windows.Forms.Panel();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.lblCardVendas = new System.Windows.Forms.Label();
            this.cardEstoqueBaixo = new System.Windows.Forms.Panel();
            this.lblTotalEstoqueBaixo = new System.Windows.Forms.Label();
            this.lblCardEstoqueBaixo = new System.Windows.Forms.Label();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.cboRelatorio = new System.Windows.Forms.ComboBox();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            this.cardProdutos.SuspendLayout();
            this.cardClientes.SuspendLayout();
            this.cardVendas.SuspendLayout();
            this.cardEstoqueBaixo.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
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
            this.lblSubtitulo.Size = new System.Drawing.Size(372, 17);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Consulte indicadores e listas operacionais do ERP";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(24, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(124, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Relatorios";
            // 
            // summaryPanel
            // 
            this.summaryPanel.ColumnCount = 4;
            this.summaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.Controls.Add(this.cardProdutos, 0, 0);
            this.summaryPanel.Controls.Add(this.cardClientes, 1, 0);
            this.summaryPanel.Controls.Add(this.cardVendas, 2, 0);
            this.summaryPanel.Controls.Add(this.cardEstoqueBaixo, 3, 0);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.summaryPanel.Location = new System.Drawing.Point(0, 82);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Padding = new System.Windows.Forms.Padding(18, 16, 18, 8);
            this.summaryPanel.RowCount = 1;
            this.summaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.summaryPanel.Size = new System.Drawing.Size(944, 124);
            this.summaryPanel.TabIndex = 1;
            // 
            // cardProdutos
            // 
            this.cardProdutos.BackColor = System.Drawing.Color.White;
            this.cardProdutos.Controls.Add(this.lblTotalProdutos);
            this.cardProdutos.Controls.Add(this.lblCardProdutos);
            this.cardProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardProdutos.Location = new System.Drawing.Point(21, 19);
            this.cardProdutos.Name = "cardProdutos";
            this.cardProdutos.Padding = new System.Windows.Forms.Padding(16);
            this.cardProdutos.Size = new System.Drawing.Size(221, 94);
            this.cardProdutos.TabIndex = 0;
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalProdutos.Location = new System.Drawing.Point(12, 33);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(38, 45);
            this.lblTotalProdutos.TabIndex = 1;
            this.lblTotalProdutos.Text = "0";
            // 
            // lblCardProdutos
            // 
            this.lblCardProdutos.AutoSize = true;
            this.lblCardProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardProdutos.Location = new System.Drawing.Point(16, 13);
            this.lblCardProdutos.Name = "lblCardProdutos";
            this.lblCardProdutos.Size = new System.Drawing.Size(66, 19);
            this.lblCardProdutos.TabIndex = 0;
            this.lblCardProdutos.Text = "Produtos";
            // 
            // cardClientes
            // 
            this.cardClientes.BackColor = System.Drawing.Color.White;
            this.cardClientes.Controls.Add(this.lblTotalClientes);
            this.cardClientes.Controls.Add(this.lblCardClientes);
            this.cardClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardClientes.Location = new System.Drawing.Point(248, 19);
            this.cardClientes.Name = "cardClientes";
            this.cardClientes.Padding = new System.Windows.Forms.Padding(16);
            this.cardClientes.Size = new System.Drawing.Size(221, 94);
            this.cardClientes.TabIndex = 1;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalClientes.Location = new System.Drawing.Point(12, 33);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(38, 45);
            this.lblTotalClientes.TabIndex = 1;
            this.lblTotalClientes.Text = "0";
            // 
            // lblCardClientes
            // 
            this.lblCardClientes.AutoSize = true;
            this.lblCardClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardClientes.Location = new System.Drawing.Point(16, 13);
            this.lblCardClientes.Name = "lblCardClientes";
            this.lblCardClientes.Size = new System.Drawing.Size(58, 19);
            this.lblCardClientes.TabIndex = 0;
            this.lblCardClientes.Text = "Clientes";
            // 
            // cardVendas
            // 
            this.cardVendas.BackColor = System.Drawing.Color.White;
            this.cardVendas.Controls.Add(this.lblTotalVendas);
            this.cardVendas.Controls.Add(this.lblCardVendas);
            this.cardVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardVendas.Location = new System.Drawing.Point(475, 19);
            this.cardVendas.Name = "cardVendas";
            this.cardVendas.Padding = new System.Windows.Forms.Padding(16);
            this.cardVendas.Size = new System.Drawing.Size(221, 94);
            this.cardVendas.TabIndex = 2;
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalVendas.Location = new System.Drawing.Point(14, 39);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(47, 32);
            this.lblTotalVendas.TabIndex = 1;
            this.lblTotalVendas.Text = "R$0";
            // 
            // lblCardVendas
            // 
            this.lblCardVendas.AutoSize = true;
            this.lblCardVendas.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardVendas.Location = new System.Drawing.Point(16, 13);
            this.lblCardVendas.Name = "lblCardVendas";
            this.lblCardVendas.Size = new System.Drawing.Size(112, 19);
            this.lblCardVendas.TabIndex = 0;
            this.lblCardVendas.Text = "Total em Vendas";
            // 
            // cardEstoqueBaixo
            // 
            this.cardEstoqueBaixo.BackColor = System.Drawing.Color.White;
            this.cardEstoqueBaixo.Controls.Add(this.lblTotalEstoqueBaixo);
            this.cardEstoqueBaixo.Controls.Add(this.lblCardEstoqueBaixo);
            this.cardEstoqueBaixo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardEstoqueBaixo.Location = new System.Drawing.Point(702, 19);
            this.cardEstoqueBaixo.Name = "cardEstoqueBaixo";
            this.cardEstoqueBaixo.Padding = new System.Windows.Forms.Padding(16);
            this.cardEstoqueBaixo.Size = new System.Drawing.Size(221, 94);
            this.cardEstoqueBaixo.TabIndex = 3;
            // 
            // lblTotalEstoqueBaixo
            // 
            this.lblTotalEstoqueBaixo.AutoSize = true;
            this.lblTotalEstoqueBaixo.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalEstoqueBaixo.Location = new System.Drawing.Point(12, 33);
            this.lblTotalEstoqueBaixo.Name = "lblTotalEstoqueBaixo";
            this.lblTotalEstoqueBaixo.Size = new System.Drawing.Size(38, 45);
            this.lblTotalEstoqueBaixo.TabIndex = 1;
            this.lblTotalEstoqueBaixo.Text = "0";
            // 
            // lblCardEstoqueBaixo
            // 
            this.lblCardEstoqueBaixo.AutoSize = true;
            this.lblCardEstoqueBaixo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCardEstoqueBaixo.Location = new System.Drawing.Point(16, 13);
            this.lblCardEstoqueBaixo.Name = "lblCardEstoqueBaixo";
            this.lblCardEstoqueBaixo.Size = new System.Drawing.Size(94, 19);
            this.lblCardEstoqueBaixo.TabIndex = 0;
            this.lblCardEstoqueBaixo.Text = "Estoque Baixo";
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.btnFechar);
            this.filterPanel.Controls.Add(this.btnAtualizar);
            this.filterPanel.Controls.Add(this.cboRelatorio);
            this.filterPanel.Controls.Add(this.lblRelatorio);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 206);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Padding = new System.Windows.Forms.Padding(18, 8, 18, 8);
            this.filterPanel.Size = new System.Drawing.Size(944, 70);
            this.filterPanel.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFechar.Location = new System.Drawing.Point(825, 14);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(101, 40);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnAtualizar.Location = new System.Drawing.Point(342, 14);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(101, 40);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // cboRelatorio
            // 
            this.cboRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRelatorio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRelatorio.FormattingEnabled = true;
            this.cboRelatorio.Location = new System.Drawing.Point(21, 29);
            this.cboRelatorio.Name = "cboRelatorio";
            this.cboRelatorio.Size = new System.Drawing.Size(295, 25);
            this.cboRelatorio.TabIndex = 1;
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRelatorio.Location = new System.Drawing.Point(18, 9);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(62, 17);
            this.lblRelatorio.TabIndex = 0;
            this.lblRelatorio.Text = "Consulta";
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dgvRelatorio);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 276);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Padding = new System.Windows.Forms.Padding(18, 8, 18, 18);
            this.gridPanel.Size = new System.Drawing.Size(944, 337);
            this.gridPanel.TabIndex = 3;
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.White;
            this.dgvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRelatorio.Location = new System.Drawing.Point(18, 8);
            this.dgvRelatorio.MultiSelect = false;
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersVisible = false;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(908, 311);
            this.dgvRelatorio.TabIndex = 0;
            // 
            // RelatoriosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(944, 613);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.headerPanel);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "RelatoriosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.summaryPanel.ResumeLayout(false);
            this.cardProdutos.ResumeLayout(false);
            this.cardProdutos.PerformLayout();
            this.cardClientes.ResumeLayout(false);
            this.cardClientes.PerformLayout();
            this.cardVendas.ResumeLayout(false);
            this.cardVendas.PerformLayout();
            this.cardEstoqueBaixo.ResumeLayout(false);
            this.cardEstoqueBaixo.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel summaryPanel;
        private System.Windows.Forms.Panel cardProdutos;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.Label lblCardProdutos;
        private System.Windows.Forms.Panel cardClientes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label lblCardClientes;
        private System.Windows.Forms.Panel cardVendas;
        private System.Windows.Forms.Label lblTotalVendas;
        private System.Windows.Forms.Label lblCardVendas;
        private System.Windows.Forms.Panel cardEstoqueBaixo;
        private System.Windows.Forms.Label lblTotalEstoqueBaixo;
        private System.Windows.Forms.Label lblCardEstoqueBaixo;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cboRelatorio;
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dgvRelatorio;
    }
}
