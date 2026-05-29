using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlasComercialERP.DAO;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Forms
{
    public partial class EstoqueForm : Form
    {
        private readonly ProdutoDAO produtoDao = new ProdutoDAO();
        private readonly BindingSource produtosBindingSource = new BindingSource();
        private List<Produto> produtos = new List<Produto>();

        public EstoqueForm()
        {
            InitializeComponent();
            ConfigurarTela();
            LoadTheme();
            ListarProdutos();
        }

        private void ConfigurarTela()
        {
            dgvProdutos.AutoGenerateColumns = true;
            dgvProdutos.DataSource = produtosBindingSource;
            dgvProdutos.SelectionChanged += DgvProdutos_SelectionChanged;
            cboProduto.SelectedIndexChanged += CboProduto_SelectedIndexChanged;

            btnEntrada.Click += BtnEntrada_Click;
            btnSaida.Click += BtnSaida_Click;
            btnListar.Click += BtnListar_Click;
            btnFechar.Click += BtnFechar_Click;

            numQuantidade.Minimum = 0;
        }

        private async void ListarProdutos()
        {
            try
            {
                UseWaitCursor = true;
                produtos = await Task.Run(() => produtoDao.Listar());

                if (IsDisposed)
                    return;

                produtosBindingSource.DataSource = produtos;
                CarregarCombo();
                FormatarGrade();
                AtualizarEstoqueAtual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar estoque: " + ex.Message, "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void CarregarCombo()
        {
            var lista = new List<Produto>
            {
                new Produto { IdProduto = 0, Nome = "Selecione" }
            };
            lista.AddRange(produtos);

            cboProduto.DataSource = lista;
            cboProduto.DisplayMember = "Nome";
            cboProduto.ValueMember = "IdProduto";
        }

        private void FormatarGrade()
        {
            if (dgvProdutos.Columns.Count == 0)
                return;

            if (dgvProdutos.Columns.Contains("IdProduto"))
            {
                dgvProdutos.Columns["IdProduto"].HeaderText = "Codigo";
                dgvProdutos.Columns["IdProduto"].Width = 70;
            }

            if (dgvProdutos.Columns.Contains("Nome"))
                dgvProdutos.Columns["Nome"].HeaderText = "Produto";

            if (dgvProdutos.Columns.Contains("Descricao"))
                dgvProdutos.Columns["Descricao"].HeaderText = "Descricao";

            if (dgvProdutos.Columns.Contains("PrecoCusto"))
            {
                dgvProdutos.Columns["PrecoCusto"].HeaderText = "Custo";
                dgvProdutos.Columns["PrecoCusto"].DefaultCellStyle.Format = "C2";
            }

            if (dgvProdutos.Columns.Contains("PrecoVenda"))
            {
                dgvProdutos.Columns["PrecoVenda"].HeaderText = "Venda";
                dgvProdutos.Columns["PrecoVenda"].DefaultCellStyle.Format = "C2";
            }

            if (dgvProdutos.Columns.Contains("Estoque"))
                dgvProdutos.Columns["Estoque"].HeaderText = "Estoque";

            if (dgvProdutos.Columns.Contains("IdFornecedor"))
                dgvProdutos.Columns["IdFornecedor"].HeaderText = "Fornecedor";
        }

        private void BtnEntrada_Click(object sender, EventArgs e)
        {
            MovimentarEstoque(true);
        }

        private void BtnSaida_Click(object sender, EventArgs e)
        {
            MovimentarEstoque(false);
        }

        private async void MovimentarEstoque(bool entrada)
        {
            Produto produto = ObterProdutoSelecionado();
            if (produto == null)
            {
                MessageBox.Show("Selecione um produto.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboProduto.Focus();
                return;
            }

            if (numQuantidade.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numQuantidade.Focus();
                return;
            }

            int quantidade = Convert.ToInt32(numQuantidade.Value);

            if (!entrada && quantidade > produto.Estoque)
            {
                MessageBox.Show("A quantidade de saida nao pode ser maior que o estoque atual.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UseWaitCursor = true;

                if (entrada)
                    await Task.Run(() => produtoDao.AdicionarEstoque(produto.IdProduto, quantidade));
                else
                    await Task.Run(() => produtoDao.BaixarEstoque(produto.IdProduto, quantidade));

                if (IsDisposed)
                    return;

                MessageBox.Show("Estoque atualizado com sucesso.", "Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numQuantidade.Value = 0;
                ListarProdutos();
                SelecionarProduto(produto.IdProduto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar estoque: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarProdutos();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarEstoqueAtual();
        }

        private void DgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow?.DataBoundItem is Produto produto)
                SelecionarProduto(produto.IdProduto);
        }

        private Produto ObterProdutoSelecionado()
        {
            int id = ObterIdSelecionado();
            return produtos.FirstOrDefault(p => p.IdProduto == id);
        }

        private int ObterIdSelecionado()
        {
            if (cboProduto.SelectedValue == null)
                return 0;

            int id;
            return int.TryParse(cboProduto.SelectedValue.ToString(), out id) ? id : 0;
        }

        private void SelecionarProduto(int idProduto)
        {
            cboProduto.SelectedValue = idProduto;
            AtualizarEstoqueAtual();
        }

        private void AtualizarEstoqueAtual()
        {
            Produto produto = ObterProdutoSelecionado();
            lblEstoqueAtualValor.Text = produto == null ? "0" : produto.Estoque.ToString();
        }

        private void LoadTheme()
        {
            BackColor = UiTema.Background;
            UiTema.ApplyHeader(headerPanel, lblTitulo, lblSubtitulo);
            UiTema.ApplySurface(formPanel, gridPanel, actionPanel);
            UiTema.ApplyFormControls(formPanel);
            UiTema.ApplyButtons(actionPanel);
            UiTema.ApplySectionTitle(lblProdutos);
            UiTema.ApplyGrid(dgvProdutos);
        }
    }
}
