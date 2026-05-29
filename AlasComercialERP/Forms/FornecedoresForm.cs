using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlasComercialERP.DAO;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Forms
{
    public partial class FornecedoresForm : Form
    {
        private readonly FornecedorDAO fornecedorDao = new FornecedorDAO();
        private readonly ProdutoDAO produtoDao = new ProdutoDAO();
        private readonly BindingSource fornecedoresBindingSource = new BindingSource();
        private int? fornecedorSelecionadoId;
        private bool limpandoFormulario;

        public FornecedoresForm()
        {
            InitializeComponent();
            ConfigurarTela();
            LoadTheme();
            ListarFornecedores();
        }

        private void ConfigurarTela()
        {
            dgvFornecedores.AutoGenerateColumns = true;
            dgvFornecedores.DataSource = fornecedoresBindingSource;
            dgvFornecedores.SelectionChanged += DgvFornecedores_SelectionChanged;
            dgvFornecedores.CellDoubleClick += DgvFornecedores_CellDoubleClick;

            btnNovo.Click += BtnNovo_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnAlterar.Click += BtnAlterar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnListar.Click += BtnListar_Click;
            btnFechar.Click += BtnFechar_Click;
        }

        private async void ListarFornecedores()
        {
            try
            {
                UseWaitCursor = true;
                var fornecedores = await Task.Run(() => fornecedorDao.Listar());

                if (IsDisposed)
                    return;

                fornecedoresBindingSource.DataSource = fornecedores;
                FormatarGrade();
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao listar fornecedores: " + ex.Message,
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
            if (dgvFornecedores.Columns.Count == 0)
                return;

            if (dgvFornecedores.Columns.Contains("IdFornecedor"))
            {
                dgvFornecedores.Columns["IdFornecedor"].HeaderText = "Codigo";
                dgvFornecedores.Columns["IdFornecedor"].Width = 70;
            }

            if (dgvFornecedores.Columns.Contains("Nome"))
                dgvFornecedores.Columns["Nome"].HeaderText = "Fornecedor";

            if (dgvFornecedores.Columns.Contains("CNPJ"))
                dgvFornecedores.Columns["CNPJ"].HeaderText = "CNPJ";

            if (dgvFornecedores.Columns.Contains("Telefone"))
                dgvFornecedores.Columns["Telefone"].HeaderText = "Telefone";

            if (dgvFornecedores.Columns.Contains("Email"))
                dgvFornecedores.Columns["Email"].HeaderText = "Email";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!TryCriarFornecedor(out Fornecedor fornecedor))
                return;

            try
            {
                fornecedorDao.Inserir(fornecedor);
                MessageBox.Show("Fornecedor cadastrado com sucesso.", "Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarFornecedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!fornecedorSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um fornecedor para alterar.", "Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryCriarFornecedor(out Fornecedor fornecedor))
                return;

            fornecedor.IdFornecedor = fornecedorSelecionadoId.Value;

            try
            {
                fornecedorDao.Alterar(fornecedor);
                MessageBox.Show("Fornecedor alterado com sucesso.", "Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarFornecedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!fornecedorSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um fornecedor para excluir.", "Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmacao = MessageBox.Show(
                "Deseja excluir o fornecedor selecionado?",
                "Confirmar Exclusao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                UseWaitCursor = true;
                int totalProdutos = await Task.Run(() => produtoDao.ContarPorFornecedor(fornecedorSelecionadoId.Value));

                if (totalProdutos > 0)
                {
                    MessageBox.Show(
                        "Nao e possivel excluir este fornecedor porque ele esta vinculado a " +
                        totalProdutos +
                        (totalProdutos == 1 ? " produto." : " produtos.") +
                        "\n\nAltere esses produtos para outro fornecedor ou deixe-os sem fornecedor antes de excluir.",
                        "Fornecedor em uso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                await Task.Run(() => fornecedorDao.Excluir(fornecedorSelecionadoId.Value));

                if (IsDisposed)
                    return;

                MessageBox.Show("Fornecedor excluido com sucesso.", "Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarFornecedores();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show(
                    "Nao e possivel excluir este fornecedor porque existem registros vinculados a ele.\n\n" +
                    "Verifique os produtos cadastrados e remova ou altere o fornecedor antes de tentar novamente.",
                    "Fornecedor em uso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir fornecedor: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarFornecedores();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                PreencherFormularioSelecionado();
        }

        private void DgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            PreencherFormularioSelecionado();
        }

        private void PreencherFormularioSelecionado()
        {
            if (limpandoFormulario)
                return;

            if (!(dgvFornecedores.CurrentRow?.DataBoundItem is Fornecedor fornecedor))
                return;

            fornecedorSelecionadoId = fornecedor.IdFornecedor;
            txtNome.Text = fornecedor.Nome;
            txtCnpj.Text = fornecedor.CNPJ;
            txtTelefone.Text = fornecedor.Telefone;
            txtEmail.Text = fornecedor.Email;
        }

        private bool TryCriarFornecedor(out Fornecedor fornecedor)
        {
            fornecedor = null;

            string nome = txtNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do fornecedor.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            fornecedor = new Fornecedor
            {
                Nome = nome,
                CNPJ = txtCnpj.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            return true;
        }

        private void LimparFormulario()
        {
            limpandoFormulario = true;

            try
            {
                fornecedorSelecionadoId = null;
                txtNome.Clear();
                txtCnpj.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                dgvFornecedores.ClearSelection();

                if (dgvFornecedores.Rows.Count > 0)
                    dgvFornecedores.CurrentCell = null;
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
            UiTema.ApplySectionTitle(lblListaFornecedores);
            UiTema.ApplyGrid(dgvFornecedores);
        }
    }
}
