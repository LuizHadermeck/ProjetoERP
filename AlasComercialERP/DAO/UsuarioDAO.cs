using AlasComercialERP.Autenticacao;
using AlasComercialERP.Mapeamento;
using Dapper;
using System;

namespace AlasComercialERP.DAO
{
    public class UsuarioDAO : Conexao, IUsuarioRepositorio
    {
        public void GarantirEstrutura()
        {
            string sql = @"
if object_id('dbo.Usuarios', 'U') is null
begin
    create table dbo.Usuarios
    (
        IdUsuario int identity(1,1) not null primary key,
        NomeUsuario nvarchar(50) not null unique,
        NomeExibicao nvarchar(100) not null,
        SenhaHash nvarchar(100) not null,
        SenhaSalt nvarchar(100) not null,
        Ativo bit not null constraint DF_Usuarios_Ativo default 1,
        CriadoEm datetime2 not null constraint DF_Usuarios_CriadoEm default sysdatetime()
    );
end
else
begin
    if col_length('dbo.Usuarios', 'NomeUsuario') is null
        alter table dbo.Usuarios add NomeUsuario nvarchar(50) null;

    if col_length('dbo.Usuarios', 'NomeExibicao') is null
        alter table dbo.Usuarios add NomeExibicao nvarchar(100) null;

    if col_length('dbo.Usuarios', 'SenhaHash') is null
        alter table dbo.Usuarios add SenhaHash nvarchar(100) null;

    if col_length('dbo.Usuarios', 'SenhaSalt') is null
        alter table dbo.Usuarios add SenhaSalt nvarchar(100) null;

    if col_length('dbo.Usuarios', 'Ativo') is null
        alter table dbo.Usuarios add Ativo bit null;

    if col_length('dbo.Usuarios', 'CriadoEm') is null
        alter table dbo.Usuarios add CriadoEm datetime2 null;
end";

            banco.Execute(sql);
            MigrarUsuariosLegados();
        }

        public void GarantirUsuarioInicial()
        {
            int totalUsuarios = banco.ExecuteScalar<int>(
                "select count(1) from dbo.Usuarios where NomeUsuario is not null and SenhaHash is not null and SenhaSalt is not null");

            if (totalUsuarios > 0)
                return;

            SenhaService.GerarHash("admin123", out string hash, out string salt);

            if (ColunaExiste("Usuario") && ColunaExiste("Senha") && ColunaExiste("Nome"))
            {
                banco.Execute(
                    @"insert into dbo.Usuarios
                        (Nome, Usuario, Senha, NivelAcesso, NomeUsuario, NomeExibicao, SenhaHash, SenhaSalt, Ativo, CriadoEm)
                      values
                        (@NomeExibicao, @NomeUsuario, @SenhaLegada, @NivelAcesso, @NomeUsuario, @NomeExibicao, @SenhaHash, @SenhaSalt, 1, sysdatetime())",
                    new
                    {
                        NomeUsuario = "admin",
                        NomeExibicao = "Administrador",
                        SenhaLegada = "admin123",
                        NivelAcesso = "Administrador",
                        SenhaHash = hash,
                        SenhaSalt = salt
                    });
            }
            else
            {
                banco.Execute(
                    "insert into dbo.Usuarios (NomeUsuario, NomeExibicao, SenhaHash, SenhaSalt, Ativo) values (@NomeUsuario, @NomeExibicao, @SenhaHash, @SenhaSalt, 1)",
                    new
                    {
                        NomeUsuario = "admin",
                        NomeExibicao = "Administrador",
                        SenhaHash = hash,
                        SenhaSalt = salt
                    });
            }
        }

        public Usuario BuscarPorNomeUsuario(string nomeUsuario)
        {
            return banco.QuerySingleOrDefault<Usuario>(
                "select IdUsuario, NomeUsuario, NomeExibicao, SenhaHash, SenhaSalt, Ativo, CriadoEm from dbo.Usuarios where NomeUsuario = @NomeUsuario",
                new { NomeUsuario = nomeUsuario });
        }

        internal static DadosMigracaoUsuarioLegado CriarDadosMigracaoLegado(int idUsuario, string nomeUsuario, string nomeExibicao, string senha)
        {
            string usuarioNormalizado = Normalizar(nomeUsuario);
            string exibicaoNormalizada = Normalizar(nomeExibicao);

            if (string.IsNullOrWhiteSpace(usuarioNormalizado))
                usuarioNormalizado = string.IsNullOrWhiteSpace(exibicaoNormalizada) ? "usuario" + idUsuario : exibicaoNormalizada;

            if (string.IsNullOrWhiteSpace(exibicaoNormalizada))
                exibicaoNormalizada = usuarioNormalizado;

            SenhaService.GerarHash(senha, out string hash, out string salt);

            return new DadosMigracaoUsuarioLegado
            {
                IdUsuario = idUsuario,
                NomeUsuario = usuarioNormalizado,
                NomeExibicao = exibicaoNormalizada,
                SenhaHash = hash,
                SenhaSalt = salt
            };
        }

        private void MigrarUsuariosLegados()
        {
            if (!ColunaExiste("Usuario") || !ColunaExiste("Senha"))
                return;

            string colunaNome = ColunaExiste("Nome")
                ? "cast(Nome as nvarchar(100))"
                : "cast(null as nvarchar(100))";

            string sql = $@"
select
    IdUsuario,
    cast(Usuario as nvarchar(50)) as NomeUsuario,
    {colunaNome} as NomeExibicao,
    cast(Senha as nvarchar(4000)) as Senha
from dbo.Usuarios
where (SenhaHash is null or SenhaSalt is null)
  and Senha is not null
  and ltrim(rtrim(Senha)) <> ''";

            foreach (UsuarioLegado usuario in banco.Query<UsuarioLegado>(sql))
            {
                DadosMigracaoUsuarioLegado dados = CriarDadosMigracaoLegado(
                    usuario.IdUsuario,
                    usuario.NomeUsuario,
                    usuario.NomeExibicao,
                    usuario.Senha);

                banco.Execute(
                    @"update dbo.Usuarios
                      set NomeUsuario = case when NomeUsuario is null or ltrim(rtrim(NomeUsuario)) = '' then @NomeUsuario else NomeUsuario end,
                          NomeExibicao = case when NomeExibicao is null or ltrim(rtrim(NomeExibicao)) = '' then @NomeExibicao else NomeExibicao end,
                          SenhaHash = @SenhaHash,
                          SenhaSalt = @SenhaSalt,
                          Ativo = coalesce(Ativo, 1),
                          CriadoEm = coalesce(CriadoEm, sysdatetime())
                      where IdUsuario = @IdUsuario",
                    dados);
            }
        }

        private bool ColunaExiste(string nomeColuna)
        {
            return banco.ExecuteScalar<int>(
                @"select count(1)
                  from sys.columns
                  where object_id = object_id('dbo.Usuarios', 'U')
                    and name = @NomeColuna",
                new { NomeColuna = nomeColuna }) > 0;
        }

        private static string Normalizar(string valor)
        {
            return string.IsNullOrWhiteSpace(valor) ? string.Empty : valor.Trim();
        }

        internal sealed class DadosMigracaoUsuarioLegado
        {
            public int IdUsuario { get; set; }
            public string NomeUsuario { get; set; }
            public string NomeExibicao { get; set; }
            public string SenhaHash { get; set; }
            public string SenhaSalt { get; set; }
        }

        private sealed class UsuarioLegado
        {
            public int IdUsuario { get; set; }
            public string NomeUsuario { get; set; }
            public string NomeExibicao { get; set; }
            public string Senha { get; set; }
        }
    }
}
