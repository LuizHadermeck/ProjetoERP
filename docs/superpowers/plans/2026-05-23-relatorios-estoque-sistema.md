# Telas Relatorios Estoque Sistema Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Finish Reports, Stock, and System screens with consistent visual design and useful ERP behavior.

**Architecture:** Keep each existing WinForms form as its screen boundary. Use existing DAO classes for data reads and stock updates; keep UI validation and binding in the form code-behind.

**Tech Stack:** C# WinForms on .NET Framework 4.8, Dapper DAO classes, SQL Server connection from `Conexao.cs`.

---

### Task 1: Reports Screen

**Files:**
- Modify: `AlasComercialERP/Forms/RelatoriosForm.Designer.cs`
- Modify: `AlasComercialERP/Forms/RelatoriosForm.cs`

- [ ] Replace placeholder controls with header, summary cards, report selector, grid, and action buttons.
- [ ] Load products, clients, suppliers, sales, and low-stock projections from existing DAOs.

### Task 2: Stock Screen

**Files:**
- Modify: `AlasComercialERP/Forms/EstoqueForm.Designer.cs`
- Modify: `AlasComercialERP/Forms/EstoqueForm.cs`

- [ ] Replace placeholder controls with header, product selector, current stock indicator, quantity input, grid, and action buttons.
- [ ] Use `ProdutoDAO.AdicionarEstoque` and `ProdutoDAO.BaixarEstoque` for entry and exit operations.

### Task 3: System Screen

**Files:**
- Modify: `AlasComercialERP/Forms/SobreForm.Designer.cs`
- Modify: `AlasComercialERP/Forms/SobreForm.cs`

- [ ] Replace AboutBox layout with a full ERP system information screen.
- [ ] Show assembly product, version, company, copyright, modules, and operational description.

### Task 4: Verify Build

**Files:**
- Verify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] Compile the project with `dotnet build 'AlasComercialERP\AlasComercialERP.csproj'`.
