# Tela de Materiais Design

## Objetivo

Transformar `MateriaisForm` em uma tela completa para cadastrar a composicao de materiais dos produtos, com visual consistente com as telas de produtos, clientes e fornecedores.

## Interface

A tela tera cabecalho com o titulo "Cadastro de Materiais", um painel de formulario para edicao e uma grade para listagem. O formulario tera campos para produto final, produto material e quantidade. A grade exibira as composicoes cadastradas.

## Fluxo

`Novo` limpa os campos. `Salvar` insere uma nova composicao. `Alterar` atualiza a composicao selecionada. `Excluir` remove a composicao selecionada apos confirmacao. `Listar` recarrega os dados da grade. `Fechar` fecha o formulario filho.

## Dados e Validacao

A tela usa `ProdutoComposicaoDAO` para listar, inserir, alterar e excluir. Ela usa `ProdutoDAO` para carregar os produtos nos combos. Produto final e produto material sao obrigatorios, nao podem ser o mesmo produto e a quantidade deve ser maior que zero.

## Verificacao

A verificacao principal sera compilar o projeto WinForms. A validacao real do CRUD depende da instancia SQL configurada em `Conexao.cs`.
