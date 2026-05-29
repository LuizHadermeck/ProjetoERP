using AlasComercialERP.DAO;
using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Autenticacao
{
    public class AutenticacaoService
    {
        private readonly IUsuarioRepositorio usuarioRepositorio;

        public AutenticacaoService()
            : this(new UsuarioDAO())
        {
        }

        public AutenticacaoService(IUsuarioRepositorio usuarioRepositorio)
        {
            this.usuarioRepositorio = usuarioRepositorio;
        }

        public void Inicializar()
        {
            usuarioRepositorio.GarantirEstrutura();
            usuarioRepositorio.GarantirUsuarioInicial();
        }

        public Usuario Autenticar(string nomeUsuario, string senha)
        {
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(senha))
                return null;

            Usuario usuario = usuarioRepositorio.BuscarPorNomeUsuario(nomeUsuario.Trim());

            if (usuario == null || !usuario.Ativo)
                return null;

            return SenhaService.VerificarSenha(senha, usuario.SenhaHash, usuario.SenhaSalt)
                ? usuario
                : null;
        }
    }
}
