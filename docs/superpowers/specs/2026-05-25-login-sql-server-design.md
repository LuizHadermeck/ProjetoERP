# Sistema de Login Design

## Objetivo

Adicionar autenticacao ao Alas Comercial ERP para impedir acesso a qualquer modulo enquanto o usuario nao estiver logado.

## Interface

O aplicativo exibira uma tela `LoginForm` antes do `PrincipalForm`. A tela tera campos de usuario e senha, botao Entrar e botao Cancelar. Enter acionara a entrada e Esc cancelara. Mensagens de erro serao exibidas no proprio formulario quando as credenciais forem invalidas ou quando houver falha de conexao.

## Fluxo

`Program.Main` abrira `LoginForm` usando `ShowDialog`. Apenas `DialogResult.OK` inicia `PrincipalForm`. Cancelamento, fechamento da tela de login ou autenticacao recusada encerram a aplicacao sem criar a tela principal. Como o formulario principal nao existe antes do login, todos os menus e modulos permanecem bloqueados.

## Dados

Sera criada a tabela `Usuarios` no SQL Server se ela nao existir, com identificador, nome de usuario unico, nome de exibicao, hash da senha, salt, flag ativo e data de criacao. Se a tabela estiver vazia, o sistema criara automaticamente o usuario inicial `admin` com senha `admin123`.

## Seguranca

As senhas nao serao salvas em texto puro. O sistema gerara um salt por usuario e armazenara o hash SHA-256 de salt + senha. A validacao de senha comparara os hashes em tempo fixo para evitar atalhos de comparacao.

## Componentes

`SenhaService` cuidara de salt, hash e verificacao de senha. `UsuarioDAO` cuidara de criacao da tabela, usuario inicial e busca de usuarios ativos. `AutenticacaoService` coordenara inicializacao e validacao. `SessaoUsuario` guardara o usuario autenticado para uso futuro. `LoginForm` ficara responsavel apenas pela interface e chamadas ao servico.

## Verificacao

A verificacao automatizada cobrira o hash de senha e a comparacao de credenciais. A verificacao de build compilara o projeto WinForms. O teste real de conexao e login dependera da instancia SQL Server configurada em `App.config`.
