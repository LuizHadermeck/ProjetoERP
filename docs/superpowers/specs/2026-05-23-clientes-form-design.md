# Tela de Clientes Design

## Objetivo

Transformar `ClientesForm` em uma tela completa de cadastro de clientes, com visual consistente com a tela de produtos e CRUD usando o `ClienteDAO` existente.

## Interface

A tela tera cabecalho com o titulo "Cadastro de Clientes", um painel de formulario para edicao e uma grade para listagem. O formulario tera campos para nome, CPF/CNPJ, telefone, email e endereco. A grade permitira selecionar um cliente para preencher o formulario.

## Fluxo

`Novo` limpa os campos. `Salvar` insere um novo cliente. `Alterar` atualiza o cliente selecionado. `Excluir` remove o cliente selecionado apos confirmacao. `Listar` recarrega os dados da grade. `Fechar` fecha o formulario filho.

## Dados e Validacao

A tela usa `ClienteDAO` para listar, inserir, alterar e excluir. O nome e obrigatorio. Email, telefone, CPF/CNPJ e endereco ficam opcionais para respeitar o cadastro simples do projeto.

## Verificacao

A verificacao principal sera compilar o projeto WinForms. A validacao real do CRUD depende da instancia SQL configurada em `Conexao.cs`.
