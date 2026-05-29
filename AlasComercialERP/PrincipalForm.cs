using AlasComercialERP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlasComercialERP
{
    public partial class PrincipalForm : Form
    {
        private readonly Color menuColor = UiTema.Menu;
        private readonly Color menuHoverColor = UiTema.MenuHover;
        private readonly Color headerColor = UiTema.Primary;
        private readonly Color contentColor = UiTema.Background;
        private readonly Font menuFont = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        private readonly Font menuActiveFont = new Font("Segoe UI Semibold", 12.5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public PrincipalForm()
        {
            InitializeComponent();
            random = new Random();
            fecharButton.Visible = false;
            ConfigurarTelaPrincipal();
            MontarPainelInicial();
            FormClosing += PrincipalForm_FormClosing;
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(CorTema.cores.Count);
            while (tempIndex == index)
            {
                index = random.Next(CorTema.cores.Count);
            }
            tempIndex = index;
            string color = CorTema.cores[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object senderBtn)
        {
            if(senderBtn != null)
            {
                if(currentButton != (Button)senderBtn)
                {
                    DisableButton();
                    Color color = SelectThemeColor();

                    currentButton = (Button)senderBtn;                   
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = menuActiveFont;

                    topMenuPanel.BackColor = color;
                    homePanel.BackColor = ControlPaint.Dark(color);
                    nomeLabel.ForeColor = Color.White;
                    homeLabel.ForeColor = Color.White;

                    CorTema.PrimaryColor = color;
                    CorTema.SecondaryColor = ControlPaint.Dark(color);
                }
            }
        }

        private void OpenChildForm(Func<Form> childFactory, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }

            ActivateButton(btnSender);

            Form childForm = childFactory();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.centralPanel.Controls.Clear();
            this.centralPanel.Controls.Add(childForm);
            this.centralPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            homeLabel.Text = childForm.Text;

            fecharButton.Visible = true;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = menuColor;
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = menuFont;
                }
            }
        }

        private void produtosButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new ProdutosForm(), sender);
        }

        private void clientesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new ClientesForm(), sender);
        }

        private void fornecedoresButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new FornecedoresForm(), sender);
        }

        private void relatoriosButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new RelatoriosForm(), sender);

        }

        private void estoqueButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new EstoqueForm(), sender);

        }

        private void sistemaButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(() => new SobreForm(), sender);

        }

        private void fecharButton_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();                        
                activeForm = null;
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            homeLabel.Text = "HOME";
            nomeLabel.ForeColor = Color.White;
            topMenuPanel.BackColor = UiTema.MenuTop;
            homePanel.BackColor = headerColor;
            CorTema.PrimaryColor = headerColor;
            CorTema.SecondaryColor = ControlPaint.Dark(headerColor);
            fecharButton.Visible = false;
            MontarPainelInicial();
        }

        private void ConfigurarTelaPrincipal()
        {
            Text = "Alas Comercial ERP";
            MinimumSize = new Size(1100, 700);
            BackColor = contentColor;

            panelMenu.BackColor = menuColor;
            topMenuPanel.BackColor = UiTema.MenuTop;
            homePanel.BackColor = headerColor;
            centralPanel.BackColor = contentColor;

            nomeLabel.Text = "Alas Comercial\nERP";
            nomeLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.ForeColor = Color.White;
            nomeLabel.TextAlign = ContentAlignment.MiddleCenter;

            homeLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            homeLabel.ForeColor = Color.White;

            foreach (Control control in panelMenu.Controls)
            {
                if (control is Button button)
                    ConfigurarBotaoMenu(button);
            }

            fecharButton.FlatAppearance.MouseOverBackColor = ControlPaint.Light(headerColor);
            fecharButton.Cursor = Cursors.Hand;
        }

        private void ConfigurarBotaoMenu(Button button)
        {
            button.BackColor = menuColor;
            button.ForeColor = Color.Gainsboro;
            button.Font = menuFont;
            button.Height = 58;
            button.Padding = new Padding(18, 0, 0, 0);
            button.Cursor = Cursors.Hand;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = menuHoverColor;
            button.FlatAppearance.MouseDownBackColor = Color.FromArgb(54, 59, 80);
        }

        private void MontarPainelInicial()
        {
            centralPanel.Controls.Clear();

            var dashboard = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = contentColor,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(38, 34, 38, 34)
            };
            dashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            dashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var titulo = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Bem-vindo ao Alas Comercial ERP",
                Font = UiTema.TitleFont(28F),
                ForeColor = UiTema.Text,
                TextAlign = ContentAlignment.BottomLeft
            };

            var subtitulo = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                Text = "Controle cadastros, estoque e relatorios em uma interface integrada.",
                Font = UiTema.BodyFont(11F),
                ForeColor = UiTema.MutedText,
                TextAlign = ContentAlignment.TopLeft
            };

            var tituloPanel = new Panel { Dock = DockStyle.Fill };
            tituloPanel.Controls.Add(titulo);
            tituloPanel.Controls.Add(subtitulo);

            var cards = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = contentColor
            };
            cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            cards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            cards.Controls.Add(CriarCardInicial("Cadastros", "Produtos, clientes, fornecedores e composicoes organizados."), 0, 0);
            cards.Controls.Add(CriarCardInicial("Estoque", "Entradas, saidas e saldos de produtos com validacao."), 1, 0);
            cards.Controls.Add(CriarCardInicial("Relatorios", "Visao rapida de indicadores e consultas operacionais."), 2, 0);

            var rodape = new Label
            {
                Dock = DockStyle.Top,
                Height = 48,
                Text = "Escolha um modulo no menu lateral para comecar.",
                Font = UiTema.TitleFont(12F),
                ForeColor = headerColor,
                TextAlign = ContentAlignment.MiddleLeft
            };

            dashboard.Controls.Add(tituloPanel, 0, 0);
            dashboard.Controls.Add(cards, 0, 1);
            dashboard.Controls.Add(rodape, 0, 2);

            centralPanel.Controls.Add(dashboard);
        }

        private Panel CriarCardInicial(string titulo, string descricao)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Margin = new Padding(0, 0, 18, 0),
                Padding = new Padding(22)
            };

            var tituloLabel = new Label
            {
                Dock = DockStyle.Top,
                Height = 34,
                Text = titulo,
                Font = UiTema.TitleFont(14F),
                ForeColor = UiTema.Text
            };

            var descricaoLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = descricao,
                Font = UiTema.BodyFont(10F),
                ForeColor = UiTema.MutedText
            };

            card.Controls.Add(descricaoLabel);
            card.Controls.Add(tituloLabel);
            return card;
        }

        private void PrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente fechar o Alas Comercial ERP?",
                "Confirmar saida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
