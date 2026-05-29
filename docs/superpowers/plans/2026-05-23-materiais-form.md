# Tela de Materiais Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build a polished WinForms material composition screen with complete CRUD.

**Architecture:** Keep the existing `MateriaisForm` as the UI boundary and use the existing `ProdutoComposicaoDAO` for CRUD plus `ProdutoDAO` to populate product selectors. The form owns validation, field mapping, grid binding, and user messages.

**Tech Stack:** C# WinForms on .NET Framework 4.8, Dapper DAO classes, SQL Server connection from `Conexao.cs`.

---

### Task 1: Replace Materials Form Layout

**Files:**
- Modify: `AlasComercialERP/Forms/MateriaisForm.Designer.cs`

- [ ] Replace placeholder controls with a header, a left composition form panel, a right composition grid, and a bottom action bar.
- [ ] Add controls named `cboProdutoFinal`, `cboProdutoMaterial`, `numQuantidade`, `dgvMateriais`, `btnNovo`, `btnSalvar`, `btnAlterar`, `btnExcluir`, `btnListar`, and `btnFechar`.

### Task 2: Implement Material Composition CRUD Behavior

**Files:**
- Modify: `AlasComercialERP/Forms/MateriaisForm.cs`

- [ ] Add private fields for `ProdutoComposicaoDAO`, `ProdutoDAO`, selected composition id, and a binding source.
- [ ] On construction, configure the grid, load product combos, and list compositions.
- [ ] Add validation requiring product final, product material, different selected products, and quantity greater than zero.
- [ ] Implement insert, update, delete, reload, clear form, selection-fill, and close handlers.

### Task 3: Verify Build

**Files:**
- Verify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] Compile the project with `dotnet build 'AlasComercialERP\AlasComercialERP.csproj'`.
