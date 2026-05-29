# Tela de Clientes Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build a polished WinForms customer registration screen with complete CRUD.

**Architecture:** Keep the existing `ClientesForm` as the UI boundary and use the existing `ClienteDAO` for data access. The form owns validation, field mapping, grid binding, and user messages.

**Tech Stack:** C# WinForms on .NET Framework 4.8, Dapper DAO classes, SQL Server connection from `Conexao.cs`.

---

### Task 1: Replace Client Form Layout

**Files:**
- Modify: `AlasComercialERP/Forms/ClientesForm.Designer.cs`

- [ ] Replace placeholder controls with a header, a left client form panel, a right client grid, and a bottom action bar.
- [ ] Add controls named `txtNome`, `txtCpfCnpj`, `txtTelefone`, `txtEmail`, `txtEndereco`, `dgvClientes`, `btnNovo`, `btnSalvar`, `btnAlterar`, `btnExcluir`, `btnListar`, and `btnFechar`.

### Task 2: Implement Client CRUD Behavior

**Files:**
- Modify: `AlasComercialERP/Forms/ClientesForm.cs`

- [ ] Add private fields for `ClienteDAO`, selected client id, and a binding source.
- [ ] On construction, configure the grid and list clients.
- [ ] Add validation requiring client name.
- [ ] Implement insert, update, delete, reload, clear form, selection-fill, and close handlers.

### Task 3: Verify Build

**Files:**
- Verify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] Compile the project with `dotnet build 'AlasComercialERP\AlasComercialERP.csproj'`.
