# Tela de Fornecedores Design

## Objetivo

Transformar `FornecedoresForm` em uma tela completa de cadastro de fornecedores, com visual consistente com as telas de produtos e clientes e CRUD usando o `FornecedorDAO` existente.

## Interface

A tela tera cabecalho com o titulo "Cadastro de Fornecedores", um painel de formulario para edicao e uma grade para listagem. O formulario tera campos para nome, CNPJ, telefone e email. A grade permitira selecionar um fornecedor para preencher o formulario.

## Fluxo

`Novo` limpa os campos. `Salvar` insere um novo fornecedor. `Alterar` atualiza o fornecedor selecionado. `Excluir` remove o fornecedor selecionado apos confirmacao. `Listar` recarrega os dados da grade. `Fechar` fecha o formulario filho.

## Dados e Validacao

A tela usa `FornecedorDAO` para listar, inserir, alterar e excluir. O nome e obrigatorio. CNPJ, telefone e email ficam opcionais para respeitar o cadastro simples do projeto.

## Verificacao

A verificacao principal sera compilar o projeto WinForms. A validacao real do CRUD depende da instancia SQL configurada em `Conexao.cs`.
