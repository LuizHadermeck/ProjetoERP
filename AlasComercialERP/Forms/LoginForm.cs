using AlasComercialERP.Autenticacao;
using AlasComercialERP.Mapeamento;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlasComercialERP.Forms
{
    public class LoginForm : Form
    {
        private readonly AutenticacaoService autenticacaoService;
        private readonly TextBox usuarioTextBox;
        private readonly TextBox senhaTextBox;
        private readonly Label erroLabel;
        private readonly Button entrarButton;

        public LoginForm()
            : this(new AutenticacaoService())
        {
        }

        public LoginForm(AutenticacaoService autenticacaoService)
        {
            this.autenticacaoService = autenticacaoService;

            Text = "Login - Alas Comercial ERP";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ClientSize = new Size(430, 330);
            MinimumSize = Size;
            MaximumSize = Size;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = UiTema.Background;

            var container = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(34, 26, 34, 26),
                BackColor = UiTema.Background,
                ColumnCount = 1,
                RowCount = 7
            };
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            container.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            container.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var tituloLabel = new Label
            {
                Dock = DockStyle.Fill,
                Text = "Alas Comercial ERP",
                Font = UiTema.TitleFont(21F),
                ForeColor = UiTema.Text,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var usuarioLabel = CriarLabel("Usuario");
            usuarioTextBox = CriarTextBox();

            var senhaLabel = CriarLabel("Senha");
            senhaTextBox = CriarTextBox();
            senhaTextBox.UseSystemPasswordChar = true;

            erroLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = UiTema.BodyFont(9.5F),
                ForeColor = Color.FromArgb(185, 28, 28),
                TextAlign = ContentAlignment.MiddleLeft
            };

            var botoesPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.RightToLeft,
                BackColor = UiTema.Background,
                Padding = new Padding(0, 8, 0, 0)
            };

            entrarButton = CriarBotao("Entrar");
            entrarButton.Click += EntrarButton_Click;

            var cancelarButton = CriarBotao("Cancelar");
            cancelarButton.DialogResult = DialogResult.Cancel;

            botoesPanel.Controls.Add(entrarButton);
            botoesPanel.Controls.Add(cancelarButton);

            AcceptButton = entrarButton;
            CancelButton = cancelarButton;

            container.Controls.Add(tituloLabel, 0, 0);
            container.Controls.Add(usuarioLabel, 0, 1);
            container.Controls.Add(usuarioTextBox, 0, 2);
            container.Controls.Add(senhaLabel, 0, 3);
            container.Controls.Add(senhaTextBox, 0, 4);
            container.Controls.Add(erroLabel, 0, 5);
            container.Controls.Add(botoesPanel, 0, 6);

            Controls.Add(container);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            usuarioTextBox.Focus();
        }

        private static Label CriarLabel(string texto)
        {
            return new Label
            {
                Dock = DockStyle.Fill,
                Text = texto,
                Font = UiTema.TitleFont(9.5F),
                ForeColor = UiTema.Secondary,
                TextAlign = ContentAlignment.BottomLeft
            };
        }

        private static TextBox CriarTextBox()
        {
            return new TextBox
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                Font = UiTema.BodyFont(11F),
                Margin = new Padding(0, 2, 0, 8)
            };
        }

        private static Button CriarBotao(string texto)
        {
            var button = new Button
            {
                Width = 104,
                Height = 36,
                Text = texto,
                Margin = new Padding(8, 0, 0, 0)
            };

            UiTema.ApplyButton(button);
            return button;
        }

        private void EntrarButton_Click(object sender, EventArgs e)
        {
            erroLabel.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(usuarioTextBox.Text) || string.IsNullOrWhiteSpace(senhaTextBox.Text))
            {
                erroLabel.Text = "Informe usuario e senha.";
                return;
            }

            try
            {
                entrarButton.Enabled = false;
                Cursor = Cursors.WaitCursor;

                autenticacaoService.Inicializar();
                Usuario usuario = autenticacaoService.Autenticar(usuarioTextBox.Text, senhaTextBox.Text);

                if (usuario == null)
                {
                    erroLabel.Text = "Usuario ou senha invalidos.";
                    senhaTextBox.SelectAll();
                    senhaTextBox.Focus();
                    return;
                }

                SessaoUsuario.Entrar(usuario);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                erroLabel.Text = "Nao foi possivel conectar ao banco de dados.";
            }
            finally
            {
                Cursor = Cursors.Default;
                entrarButton.Enabled = true;
            }
        }
    }
}
