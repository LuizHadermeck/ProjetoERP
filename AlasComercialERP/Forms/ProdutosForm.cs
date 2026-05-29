using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlasComercialERP.DAO;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Forms
{
    public partial class ProdutosForm : Form
    {
        private readonly ProdutoDAO produtoDao = new ProdutoDAO();
        private readonly FornecedorDAO fornecedorDao = new FornecedorDAO();
        private readonly BindingSource produtosBindingSource = new BindingSource();
        private int? produtoSelecionadoId;
        private bool limpandoFormulario;

        public ProdutosForm()
        {
            InitializeComponent();
            ConfigurarTela();
            LoadTheme();
            CarregarFornecedores();
            ListarProdutos();
        }

        private void ConfigurarTela()
        {
            dgvProdutos.AutoGenerateColumns = true;
            dgvProdutos.DataSource = produtosBindingSource;
            dgvProdutos.SelectionChanged += DgvProdutos_SelectionChanged;
            dgvProdutos.CellDoubleClick += DgvProdutos_CellDoubleClick;

            btnNovo.Click += BtnNovo_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnAlterar.Click += BtnAlterar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnListar.Click += BtnListar_Click;
            btnFechar.Click += BtnFechar_Click;

            numPrecoCusto.Minimum = 0;
            numPrecoVenda.Minimum = 0;
            numEstoque.Minimum = 0;
        }

        private async void CarregarFornecedores()
        {
            var fornecedores = new List<Fornecedor>
            {
                new Fornecedor { IdFornecedor = 0, Nome = "Sem fornecedor" }
            };

            try
            {
                UseWaitCursor = true;
                fornecedores.AddRange(await Task.Run(() => fornecedorDao.Listar()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Nao foi possivel carregar fornecedores. Voce ainda pode cadastrar produtos sem fornecedor.\n\n" + ex.Message,
                    "Fornecedores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            finally
            {
                UseWaitCursor = false;
            }

            if (IsDisposed)
                return;

            cboFornecedor.DataSource = fornecedores;
            cboFornecedor.DisplayMember = "Nome";
            cboFornecedor.ValueMember = "IdFornecedor";
        }

        private async void ListarProdutos()
        {
            try
            {
                UseWaitCursor = true;
                var produtos = await Task.Run(() => produtoDao.Listar());

                if (IsDisposed)
                    return;

                produtosBindingSource.DataSource = produtos;
                FormatarGrade();
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao listar produtos: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
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
            {
                dgvProdutos.Columns["Estoque"].HeaderText = "Estoque";
                dgvProdutos.Columns["Estoque"].Width = 80;
            }

            if (dgvProdutos.Columns.Contains("IdFornecedor"))
            {
                dgvProdutos.Columns["IdFornecedor"].HeaderText = "Fornecedor";
                dgvProdutos.Columns["IdFornecedor"].Width = 90;
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!TryCriarProduto(out Produto produto))
                return;

            try
            {
                produtoDao.Inserir(produto);
                MessageBox.Show("Produto cadastrado com sucesso.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!produtoSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um produto para alterar.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryCriarProduto(out Produto produto))
                return;

            produto.IdProduto = produtoSelecionadoId.Value;

            try
            {
                produtoDao.Alterar(produto);
                MessageBox.Show("Produto alterado com sucesso.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!produtoSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um produto para excluir.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmacao = MessageBox.Show(
                "Deseja excluir o produto selecionado?",
                "Confirmar Exclusao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                produtoDao.Excluir(produtoSelecionadoId.Value);
                MessageBox.Show("Produto excluido com sucesso.", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void DgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                PreencherFormularioSelecionado();
        }

        private void DgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            PreencherFormularioSelecionado();
        }

        private void PreencherFormularioSelecionado()
        {
            if (limpandoFormulario)
                return;

            if (!(dgvProdutos.CurrentRow?.DataBoundItem is Produto produto))
                return;

            produtoSelecionadoId = produto.IdProduto;
            txtNome.Text = produto.Nome;
            txtDescricao.Text = produto.Descricao;
            numPrecoCusto.Value = AjustarValorNumerico(produto.PrecoCusto, numPrecoCusto);
            numPrecoVenda.Value = AjustarValorNumerico(produto.PrecoVenda, numPrecoVenda);
            numEstoque.Value = AjustarValorNumerico(produto.Estoque, numEstoque);
            SelecionarFornecedor(produto.IdFornecedor);
        }

        private bool TryCriarProduto(out Produto produto)
        {
            produto = null;

            string nome = txtNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do produto.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            produto = new Produto
            {
                Nome = nome,
                Descricao = txtDescricao.Text.Trim(),
                PrecoCusto = numPrecoCusto.Value,
                PrecoVenda = numPrecoVenda.Value,
                Estoque = Convert.ToInt32(numEstoque.Value),
                IdFornecedor = ObterFornecedorSelecionado()
            };

            return true;
        }

        private int? ObterFornecedorSelecionado()
        {
            if (cboFornecedor.SelectedValue == null)
                return null;

            int idFornecedor;
            if (int.TryParse(cboFornecedor.SelectedValue.ToString(), out idFornecedor) && idFornecedor > 0)
                return idFornecedor;

            return null;
        }

        private void SelecionarFornecedor(int? idFornecedor)
        {
            cboFornecedor.SelectedValue = idFornecedor.GetValueOrDefault(0);
        }

        private decimal AjustarValorNumerico(decimal valor, NumericUpDown controle)
        {
            if (valor < controle.Minimum)
                return controle.Minimum;

            if (valor > controle.Maximum)
                return controle.Maximum;

            return valor;
        }

        private void LimparFormulario()
        {
            limpandoFormulario = true;

            try
            {
                produtoSelecionadoId = null;
                txtNome.Clear();
                txtDescricao.Clear();
                numPrecoCusto.Value = 0;
                numPrecoVenda.Value = 0;
                numEstoque.Value = 0;
                SelecionarFornecedor(null);
                dgvProdutos.ClearSelection();

                if (dgvProdutos.Rows.Count > 0)
                    dgvProdutos.CurrentCell = null;
            }
            finally
            {
                limpandoFormulario = false;
            }
        }

        private void LoadTheme()
        {
            BackColor = UiTema.Background;
            UiTema.ApplyHeader(headerPanel, lblTitulo, lblSubtitulo);
            UiTema.ApplySurface(formPanel, gridPanel, actionPanel);
            UiTema.ApplyFormControls(formPanel);
            UiTema.ApplyButtons(actionPanel);
            UiTema.ApplySectionTitle(lblListaProdutos);
            UiTema.ApplyGrid(dgvProdutos);
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
