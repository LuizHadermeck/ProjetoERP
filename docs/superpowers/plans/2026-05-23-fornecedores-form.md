# Tela de Fornecedores Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build a polished WinForms supplier registration screen with complete CRUD.

**Architecture:** Keep the existing `FornecedoresForm` as the UI boundary and use the existing `FornecedorDAO` for data access. The form owns validation, field mapping, grid binding, and user messages.

**Tech Stack:** C# WinForms on .NET Framework 4.8, Dapper DAO classes, SQL Server connection from `Conexao.cs`.

---

### Task 1: Replace Supplier Form Layout

**Files:**
- Modify: `AlasComercialERP/Forms/FornecedoresForm.Designer.cs`

- [ ] Replace placeholder controls with a header, a left supplier form panel, a right supplier grid, and a bottom action bar.
- [ ] Add controls named `txtNome`, `txtCnpj`, `txtTelefone`, `txtEmail`, `dgvFornecedores`, `btnNovo`, `btnSalvar`, `btnAlterar`, `btnExcluir`, `btnListar`, and `btnFechar`.

### Task 2: Implement Supplier CRUD Behavior

**Files:**
- Modify: `AlasComercialERP/Forms/FornecedoresForm.cs`

- [ ] Add private fields for `FornecedorDAO`, selected supplier id, and a binding source.
- [ ] On construction, configure the grid and list suppliers.
- [ ] Add validation requiring supplier name.
- [ ] Implement insert, update, delete, reload, clear form, selection-fill, and close handlers.

### Task 3: Verify Build

**Files:**
- Verify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] Compile the project with `dotnet build 'AlasComercialERP\AlasComercialERP.csproj'`.
