# Telas Relatorios Estoque Sistema Design

## Objetivo

Finalizar as telas `RelatoriosForm`, `EstoqueForm` e `SobreForm` com visual consistente com os cadastros ja implementados no ERP.

## Relatorios

A tela de relatorios tera cabecalho, cards de resumo e uma grade de consulta. Um seletor permite alternar entre produtos, clientes, fornecedores, vendas e estoque baixo. Os dados serao carregados pelos DAOs existentes.

## Estoque

A tela de estoque tera um formulario para escolher produto, ver estoque atual, informar quantidade e registrar entrada ou saida. A grade exibira os produtos e seus saldos. A saida nao deve permitir quantidade maior que o estoque atual.

## Sistema

A tela de sistema substitui o AboutBox padrao por uma area institucional do ERP, mostrando nome, versao, empresa, copyright, modulos disponiveis e descricao operacional.

## Verificacao

A verificacao principal sera compilar o projeto WinForms. As consultas reais dependem da instancia SQL configurada em `Conexao.cs`.
