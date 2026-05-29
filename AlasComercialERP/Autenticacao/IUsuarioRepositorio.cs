using AlasComercialERP.Mapeamento;

namespace AlasComercialERP.Autenticacao
{
    public interface IUsuarioRepositorio
    {
        void GarantirEstrutura();
        void GarantirUsuarioInicial();
        Usuario BuscarPorNomeUsuario(string nomeUsuario);
    }
}
