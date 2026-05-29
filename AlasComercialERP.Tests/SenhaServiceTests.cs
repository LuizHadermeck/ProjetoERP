using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AlasComercialERP.Autenticacao;
using AlasComercialERP.DAO;
using AlasComercialERP.Forms;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Tests
{
    internal static class SenhaServiceTests
    {
        private static int testesExecutados;

        private static void Main()
        {
            Executar("GerarHash cria hash e salt preenchidos", GerarHashCriaHashESaltPreenchidos);
            Executar("VerificarSenha aceita senha correta", VerificarSenhaAceitaSenhaCorreta);
            Executar("VerificarSenha recusa senha incorreta", VerificarSenhaRecusaSenhaIncorreta);
            Executar("CompararTempoFixo detecta arrays iguais e diferentes", CompararTempoFixoDetectaArrays);
            Executar("AutenticacaoService aceita usuario ativo com senha correta", AutenticacaoAceitaUsuarioAtivo);
            Executar("AutenticacaoService recusa senha incorreta", AutenticacaoRecusaSenhaIncorreta);
            Executar("AutenticacaoService recusa usuario inativo", AutenticacaoRecusaUsuarioInativo);
            Executar("AutenticacaoService recusa usuario inexistente", AutenticacaoRecusaUsuarioInexistente);
            Executar("LoginForm exibe botoes inteiros", LoginFormExibeBotoesInteiros);
            Executar("UsuarioDAO prepara usuario legado para migracao", UsuarioDAOPreparaUsuarioLegadoParaMigracao);

            Console.WriteLine($"{testesExecutados} testes passaram.");
        }

        private static void GerarHashCriaHashESaltPreenchidos()
        {
            SenhaService.GerarHash("admin123", out string hash, out string salt);

            Assert(!string.IsNullOrWhiteSpace(hash), "Hash deve ser preenchido.");
            Assert(!string.IsNullOrWhiteSpace(salt), "Salt deve ser preenchido.");
            Assert(hash != "admin123", "Hash nao deve armazenar a senha pura.");
        }

        private static void VerificarSenhaAceitaSenhaCorreta()
        {
            SenhaService.GerarHash("admin123", out string hash, out string salt);

            Assert(SenhaService.VerificarSenha("admin123", hash, salt), "Senha correta deveria ser aceita.");
        }

        private static void VerificarSenhaRecusaSenhaIncorreta()
        {
            SenhaService.GerarHash("admin123", out string hash, out string salt);

            Assert(!SenhaService.VerificarSenha("outra", hash, salt), "Senha incorreta deveria ser recusada.");
        }

        private static void CompararTempoFixoDetectaArrays()
        {
            Assert(SenhaService.CompararTempoFixo(new byte[] { 1, 2, 3 }, new byte[] { 1, 2, 3 }), "Arrays iguais deveriam ser aceitos.");
            Assert(!SenhaService.CompararTempoFixo(new byte[] { 1, 2, 3 }, new byte[] { 1, 2, 4 }), "Arrays diferentes deveriam ser recusados.");
            Assert(!SenhaService.CompararTempoFixo(new byte[] { 1, 2, 3 }, new byte[] { 1, 2 }), "Arrays com tamanhos diferentes deveriam ser recusados.");
        }

        private static void AutenticacaoAceitaUsuarioAtivo()
        {
            var repositorio = new RepositorioUsuarioFake();
            repositorio.Adicionar(CriarUsuario("admin", "admin123", true));
            var service = new AutenticacaoService(repositorio);

            Usuario usuario = service.Autenticar("admin", "admin123");

            Assert(usuario != null, "Usuario ativo com senha correta deveria autenticar.");
            Assert(usuario.NomeUsuario == "admin", "Usuario autenticado deveria ser o admin.");
        }

        private static void AutenticacaoRecusaSenhaIncorreta()
        {
            var repositorio = new RepositorioUsuarioFake();
            repositorio.Adicionar(CriarUsuario("admin", "admin123", true));
            var service = new AutenticacaoService(repositorio);

            Assert(service.Autenticar("admin", "errada") == null, "Senha incorreta deveria ser recusada.");
        }

        private static void AutenticacaoRecusaUsuarioInativo()
        {
            var repositorio = new RepositorioUsuarioFake();
            repositorio.Adicionar(CriarUsuario("admin", "admin123", false));
            var service = new AutenticacaoService(repositorio);

            Assert(service.Autenticar("admin", "admin123") == null, "Usuario inativo deveria ser recusado.");
        }

        private static void AutenticacaoRecusaUsuarioInexistente()
        {
            var service = new AutenticacaoService(new RepositorioUsuarioFake());

            Assert(service.Autenticar("admin", "admin123") == null, "Usuario inexistente deveria ser recusado.");
        }

        private static void LoginFormExibeBotoesInteiros()
        {
            using (var form = new LoginForm())
            {
                form.CreateControl();
                form.PerformLayout();

                var botoesPanel = EncontrarControles<FlowLayoutPanel>(form).Single();
                var botoes = EncontrarControles<Button>(botoesPanel).ToArray();

                Assert(botoes.Length == 2, "Tela de login deveria ter dois botoes.");

                int alturaNecessaria = botoes.Max(botao => botao.Height + botao.Margin.Vertical) + botoesPanel.Padding.Vertical;
                Assert(
                    botoesPanel.Height >= alturaNecessaria,
                    $"Painel dos botoes deveria ter pelo menos {alturaNecessaria}px de altura, mas tem {botoesPanel.Height}px.");
            }
        }

        private static void UsuarioDAOPreparaUsuarioLegadoParaMigracao()
        {
            var dados = UsuarioDAO.CriarDadosMigracaoLegado(7, " admin ", " Administrador ", "admin123");

            Assert(dados.IdUsuario == 7, "Id do usuario legado deveria ser preservado.");
            Assert(dados.NomeUsuario == "admin", "Nome de usuario legado deveria ser normalizado.");
            Assert(dados.NomeExibicao == "Administrador", "Nome de exibicao legado deveria ser normalizado.");
            Assert(!string.IsNullOrWhiteSpace(dados.SenhaHash), "Hash migrado deveria ser preenchido.");
            Assert(!string.IsNullOrWhiteSpace(dados.SenhaSalt), "Salt migrado deveria ser preenchido.");
            Assert(dados.SenhaHash != "admin123", "Senha migrada nao deveria ficar em texto puro.");
            Assert(SenhaService.VerificarSenha("admin123", dados.SenhaHash, dados.SenhaSalt), "Senha antiga deveria autenticar com o novo hash.");
        }

        private static Usuario CriarUsuario(string nomeUsuario, string senha, bool ativo)
        {
            SenhaService.GerarHash(senha, out string hash, out string salt);

            return new Usuario
            {
                IdUsuario = 1,
                NomeUsuario = nomeUsuario,
                NomeExibicao = "Administrador",
                SenhaHash = hash,
                SenhaSalt = salt,
                Ativo = ativo
            };
        }

        private static void Executar(string nome, Action teste)
        {
            try
            {
                teste();
                testesExecutados++;
                Console.WriteLine("[OK] " + nome);
            }
            catch (Exception ex)
            {
                Console.WriteLine("[FALHA] " + nome);
                Console.WriteLine(ex.Message);
                Environment.Exit(1);
            }
        }

        private static void Assert(bool condicao, string mensagem)
        {
            if (!condicao)
                throw new InvalidOperationException(mensagem);
        }

        private static IEnumerable<T> EncontrarControles<T>(Control parent) where T : Control
        {
            foreach (Control control in parent.Controls)
            {
                if (control is T encontrado)
                    yield return encontrado;

                foreach (T child in EncontrarControles<T>(control))
                    yield return child;
            }
        }

        private sealed class RepositorioUsuarioFake : IUsuarioRepositorio
        {
            private readonly Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>(StringComparer.OrdinalIgnoreCase);

            public void GarantirEstrutura()
            {
            }

            public void GarantirUsuarioInicial()
            {
            }

            public Usuario BuscarPorNomeUsuario(string nomeUsuario)
            {
                usuarios.TryGetValue(nomeUsuario, out Usuario usuario);
                return usuario;
            }

            public void Adicionar(Usuario usuario)
            {
                usuarios[usuario.NomeUsuario] = usuario;
            }
        }
    }
}
