# Tela de Produtos Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build a polished WinForms product registration screen with complete CRUD.

**Architecture:** Keep the existing `ProdutosForm` as the UI boundary and use the existing `ProdutoDAO` and `FornecedorDAO` for data access. The form owns validation, field mapping, grid binding, and user messages.

**Tech Stack:** C# WinForms on .NET Framework 4.8, Dapper DAO classes, SQL Server connection from `Conexao.cs`.

---

### Task 1: Replace Product Form Layout

**Files:**
- Modify: `AlasComercialERP/Forms/ProdutosForm.Designer.cs`

- [ ] Replace the current top-only toolbar layout with a header, a left product form panel, a right product grid, and a bottom action bar.
- [ ] Add controls named `txtNome`, `txtDescricao`, `numPrecoCusto`, `numPrecoVenda`, `numEstoque`, `cboFornecedor`, `dgvProdutos`, `btnNovo`, `btnSalvar`, `btnAlterar`, `btnExcluir`, `btnListar`, and `btnFechar`.

### Task 2: Implement Product CRUD Behavior

**Files:**
- Modify: `AlasComercialERP/Forms/ProdutosForm.cs`

- [ ] Add private fields for `ProdutoDAO`, `FornecedorDAO`, selected product id, and a binding source.
- [ ] On load, configure the grid, load suppliers, and list products.
- [ ] Add validation that requires product name and reads numeric fields from `NumericUpDown`.
- [ ] Implement insert, update, delete, reload, clear form, selection-fill, and close handlers.

### Task 3: Verify Build

**Files:**
- Verify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] Compile the project with MSBuild or Visual Studio build tools.
- [ ] If build tools are unavailable, report that limitation and the static checks performed.
