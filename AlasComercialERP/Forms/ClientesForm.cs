using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlasComercialERP.DAO;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Forms
{
    public partial class ClientesForm : Form
    {
        private readonly ClienteDAO clienteDao = new ClienteDAO();
        private readonly BindingSource clientesBindingSource = new BindingSource();
        private int? clienteSelecionadoId;
        private bool limpandoFormulario;

        public ClientesForm()
        {
            InitializeComponent();
            ConfigurarTela();
            LoadTheme();
            ListarClientes();
        }

        private void ConfigurarTela()
        {
            dgvClientes.AutoGenerateColumns = true;
            dgvClientes.DataSource = clientesBindingSource;
            dgvClientes.SelectionChanged += DgvClientes_SelectionChanged;
            dgvClientes.CellDoubleClick += DgvClientes_CellDoubleClick;

            btnNovo.Click += BtnNovo_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnAlterar.Click += BtnAlterar_Click;
            btnExcluir.Click += BtnExcluir_Click;
            btnListar.Click += BtnListar_Click;
            btnFechar.Click += BtnFechar_Click;
        }

        private async void ListarClientes()
        {
            try
            {
                UseWaitCursor = true;
                var clientes = await Task.Run(() => clienteDao.Listar());

                if (IsDisposed)
                    return;

                clientesBindingSource.DataSource = clientes;
                FormatarGrade();
                LimparFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao listar clientes: " + ex.Message,
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
            if (dgvClientes.Columns.Count == 0)
                return;

            if (dgvClientes.Columns.Contains("IdCliente"))
            {
                dgvClientes.Columns["IdCliente"].HeaderText = "Codigo";
                dgvClientes.Columns["IdCliente"].Width = 70;
            }

            if (dgvClientes.Columns.Contains("Nome"))
                dgvClientes.Columns["Nome"].HeaderText = "Cliente";

            if (dgvClientes.Columns.Contains("CPF_CNPJ"))
                dgvClientes.Columns["CPF_CNPJ"].HeaderText = "CPF/CNPJ";

            if (dgvClientes.Columns.Contains("Telefone"))
                dgvClientes.Columns["Telefone"].HeaderText = "Telefone";

            if (dgvClientes.Columns.Contains("Email"))
                dgvClientes.Columns["Email"].HeaderText = "Email";

            if (dgvClientes.Columns.Contains("Endereco"))
                dgvClientes.Columns["Endereco"].HeaderText = "Endereco";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimparFormulario();
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!TryCriarCliente(out Cliente cliente))
                return;

            try
            {
                clienteDao.Inserir(cliente);
                MessageBox.Show("Cliente cadastrado com sucesso.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (!clienteSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um cliente para alterar.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TryCriarCliente(out Cliente cliente))
                return;

            cliente.IdCliente = clienteSelecionadoId.Value;

            try
            {
                clienteDao.Alterar(cliente);
                MessageBox.Show("Cliente alterado com sucesso.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!clienteSelecionadoId.HasValue)
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirmacao = MessageBox.Show(
                "Deseja excluir o cliente selecionado?",
                "Confirmar Exclusao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
                return;

            try
            {
                clienteDao.Excluir(clienteSelecionadoId.Value);
                MessageBox.Show("Cliente excluido com sucesso.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                PreencherFormularioSelecionado();
        }

        private void DgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            PreencherFormularioSelecionado();
        }

        private void PreencherFormularioSelecionado()
        {
            if (limpandoFormulario)
                return;

            if (!(dgvClientes.CurrentRow?.DataBoundItem is Cliente cliente))
                return;

            clienteSelecionadoId = cliente.IdCliente;
            txtNome.Text = cliente.Nome;
            txtCpfCnpj.Text = cliente.CPF_CNPJ;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;
            txtEndereco.Text = cliente.Endereco;
        }

        private bool TryCriarCliente(out Cliente cliente)
        {
            cliente = null;

            string nome = txtNome.Text.Trim();
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome do cliente.", "Validacao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return false;
            }

            cliente = new Cliente
            {
                Nome = nome,
                CPF_CNPJ = txtCpfCnpj.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Endereco = txtEndereco.Text.Trim()
            };

            return true;
        }

        private void LimparFormulario()
        {
            limpandoFormulario = true;

            try
            {
                clienteSelecionadoId = null;
                txtNome.Clear();
                txtCpfCnpj.Clear();
                txtTelefone.Clear();
                txtEmail.Clear();
                txtEndereco.Clear();
                dgvClientes.ClearSelection();

                if (dgvClientes.Rows.Count > 0)
                    dgvClientes.CurrentCell = null;
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
            UiTema.ApplySectionTitle(lblListaClientes);
            UiTema.ApplyGrid(dgvClientes);
        }
    }
}
