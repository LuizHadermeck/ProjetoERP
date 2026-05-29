using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Autenticacao
{
    public static class SessaoUsuario
    {
        public static Usuario UsuarioAtual { get; private set; }

        public static bool EstaLogado
        {
            get { return UsuarioAtual != null; }
        }

        public static void Entrar(Usuario usuario)
        {
            UsuarioAtual = usuario;
        }

        public static void Sair()
        {
            UsuarioAtual = null;
        }
    }
}
