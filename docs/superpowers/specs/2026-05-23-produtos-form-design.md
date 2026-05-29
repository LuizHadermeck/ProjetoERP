# Tela de Produtos Design

## Objetivo

Transformar `ProdutosForm` em uma tela completa de cadastro de produtos para WinForms, com visual mais organizado e CRUD usando o `ProdutoDAO` existente.

## Interface

A tela tera um cabecalho com o titulo "Cadastro de Produtos", um painel de formulario para edicao e uma grade para listagem. O formulario tera campos para nome, descricao, preco de custo, preco de venda, estoque e fornecedor. A grade permitira selecionar um produto para preencher o formulario.

## Fluxo

`Novo` limpa os campos. `Salvar` insere um novo produto. `Alterar` atualiza o produto selecionado. `Excluir` remove o produto selecionado apos confirmacao. `Listar` recarrega os dados da grade. `Fechar` fecha o formulario filho.

## Dados e Validacao

A tela usa `ProdutoDAO` para listar, inserir, alterar e excluir. A lista de fornecedores sera carregada por `FornecedorDAO`; se nao for possivel carregar fornecedores, o cadastro ainda podera continuar sem fornecedor. O nome e obrigatorio, os precos devem ser maiores ou iguais a zero e o estoque nao pode ser negativo.

## Verificacao

A verificacao principal sera compilar o projeto WinForms. A validacao visual e o acesso real ao banco dependem da instancia SQL configurada em `Conexao.cs`.
