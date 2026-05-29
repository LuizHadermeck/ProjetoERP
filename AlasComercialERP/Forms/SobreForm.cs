using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace AlasComercialERP.Forms
{
    public partial class SobreForm : Form
    {
        public SobreForm()
        {
            InitializeComponent();
            CarregarInformacoes();
            LoadTheme();
            btnFechar.Click += BtnFechar_Click;
        }

        private void CarregarInformacoes()
        {
            Text = "Sistema";
            lblProdutoValor.Text = ValorOuPadrao(AssemblyProduct, "Alas Comercial ERP");
            lblVersaoValor.Text = AssemblyVersion;
            lblEmpresaValor.Text = ValorOuPadrao(AssemblyCompany, "Alas Comercial");
            lblCopyrightValor.Text = ValorOuPadrao(AssemblyCopyright, "Copyright 2026");
            txtDescricao.Text =
                "Sistema ERP comercial para controle de produtos, clientes, fornecedores, estoque e relatorios operacionais." +
                Environment.NewLine + Environment.NewLine +
                "Desenvolvido para apoiar a organizacao das rotinas comerciais da empresa de forma simples, centralizada e eficiente.";
        }

        private string ValorOuPadrao(string valor, string padrao)
        {
            return string.IsNullOrWhiteSpace(valor) ? padrao : valor;
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadTheme()
        {
            BackColor = UiTema.Background;
            UiTema.ApplyHeader(headerPanel, lblTitulo, lblSubtitulo);
            UiTema.ApplySurface(infoPanel, modulesPanel, actionPanel);
            UiTema.ApplyFormControls(infoPanel);
            UiTema.ApplyFormControls(modulesPanel);
            UiTema.ApplyButtons(actionPanel);
            txtDescricao.BackColor = Color.White;
            txtDescricao.ForeColor = UiTema.MutedText;
            txtDescricao.Font = UiTema.BodyFont(10F);
        }

        private string AssemblyVersion
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version.ToString(); }
        }

        private string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        private string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        private string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                return attributes.Length == 0 ? "" : ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }
}
