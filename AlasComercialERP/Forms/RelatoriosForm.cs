using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlasComercialERP.DAO;

namespace AlasComercialERP.Forms
{
    public partial class RelatoriosForm : Form
    {
        private readonly ProdutoDAO produtoDao = new ProdutoDAO();
        private readonly ClienteDAO clienteDao = new ClienteDAO();
        private readonly FornecedorDAO fornecedorDao = new FornecedorDAO();
        private readonly VendaDAO vendaDao = new VendaDAO();
        private readonly BindingSource relatorioBindingSource = new BindingSource();

        public RelatoriosForm()
        {
            InitializeComponent();
            ConfigurarTela();
            LoadTheme();
            CarregarResumo();
            CarregarRelatorio();
        }

        private void ConfigurarTela()
        {
            dgvRelatorio.DataSource = relatorioBindingSource;
            cboRelatorio.Items.AddRange(new object[]
            {
                "Produtos",
                "Clientes",
                "Fornecedores",
                "Vendas",
                "Estoque baixo"
            });
            cboRelatorio.SelectedIndex = 0;
            cboRelatorio.SelectedIndexChanged += CboRelatorio_SelectedIndexChanged;
            btnAtualizar.Click += BtnAtualizar_Click;
            btnFechar.Click += BtnFechar_Click;
        }

        private async void CarregarResumo()
        {
            try
            {
                UseWaitCursor = true;
                var resumo = await Task.Run(() =>
                {
                    var produtos = new ProdutoDAO().Listar();
                    var clientes = new ClienteDAO().Listar();
                    var vendas = new VendaDAO().Listar();

                    return new
                    {
                        TotalProdutos = produtos.Count,
                        TotalClientes = clientes.Count,
                        TotalVendas = vendas.Sum(v => v.ValorTotal),
                        EstoqueBaixo = produtos.Count(p => p.Estoque <= 5)
                    };
                });

                if (IsDisposed)
                    return;

                lblTotalProdutos.Text = resumo.TotalProdutos.ToString();
                lblTotalClientes.Text = resumo.TotalClientes.ToString();
                lblTotalVendas.Text = resumo.TotalVendas.ToString("C2");
                lblTotalEstoqueBaixo.Text = resumo.EstoqueBaixo.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar resumo: " + ex.Message, "Relatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private async void CarregarRelatorio()
        {
            try
            {
                UseWaitCursor = true;
                object dados;

                switch (cboRelatorio.Text)
                {
                    case "Clientes":
                        dados = await Task.Run(() => new ClienteDAO().Listar()
                            .Select(c => new
                            {
                                Codigo = c.IdCliente,
                                Cliente = c.Nome,
                                Documento = c.CPF_CNPJ,
                                c.Telefone,
                                c.Email,
                                c.Endereco
                            })
                            .ToList());
                        break;

                    case "Fornecedores":
                        dados = await Task.Run(() => new FornecedorDAO().Listar()
                            .Select(f => new
                            {
                                Codigo = f.IdFornecedor,
                                Fornecedor = f.Nome,
                                f.CNPJ,
                                f.Telefone,
                                f.Email
                            })
                            .ToList());
                        break;

                    case "Vendas":
                        dados = await Task.Run(() => new VendaDAO().Listar()
                            .Select(v => new
                            {
                                Codigo = v.IdVenda,
                                Cliente = v.IdCliente,
                                Data = v.DataVenda,
                                Total = v.ValorTotal,
                                Status = v.StatusVenda
                            })
                            .ToList());
                        break;

                    case "Estoque baixo":
                        dados = await Task.Run(() => new ProdutoDAO().Listar()
                            .Where(p => p.Estoque <= 5)
                            .Select(p => new
                            {
                                Codigo = p.IdProduto,
                                Produto = p.Nome,
                                p.Estoque,
                                Custo = p.PrecoCusto,
                                Venda = p.PrecoVenda
                            })
                            .ToList());
                        break;

                    default:
                        dados = await Task.Run(() => new ProdutoDAO().Listar()
                            .Select(p => new
                            {
                                Codigo = p.IdProduto,
                                Produto = p.Nome,
                                p.Descricao,
                                Custo = p.PrecoCusto,
                                Venda = p.PrecoVenda,
                                p.Estoque,
                                Fornecedor = p.IdFornecedor
                            })
                            .ToList());
                        break;
                }

                if (IsDisposed)
                    return;

                relatorioBindingSource.DataSource = dados;
                FormatarGrade();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar relatorio: " + ex.Message, "Relatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                UseWaitCursor = false;
            }
        }

        private void FormatarGrade()
        {
            foreach (DataGridViewColumn column in dgvRelatorio.Columns)
            {
                if (column.ValueType == typeof(decimal))
                    column.DefaultCellStyle.Format = "C2";

                if (column.Name == "Data")
                    column.DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void CboRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarResumo();
            CarregarRelatorio();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTheme()
        {
            BackColor = UiTema.Background;
            UiTema.ApplyHeader(headerPanel, lblTitulo, lblSubtitulo);
            UiTema.ApplySurface(filterPanel, gridPanel);
            UiTema.ApplyFormControls(filterPanel);
            UiTema.ApplyButtons(filterPanel);
            UiTema.ApplySectionTitle(lblRelatorio);
            UiTema.ApplySummaryCards(summaryPanel);
            UiTema.ApplyGrid(dgvRelatorio);
        }
    }
}
