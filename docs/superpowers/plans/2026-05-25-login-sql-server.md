# Sistema de Login Implementation Plan

> **For agentic workers:** REQUIRED SUB-SKILL: Use superpowers:subagent-driven-development (recommended) or superpowers:executing-plans to implement this plan task-by-task. Steps use checkbox (`- [ ]`) syntax for tracking.

**Goal:** Build SQL Server backed login that prevents the ERP main window from opening until a user authenticates.

**Architecture:** Add small authentication classes under `Autenticacao`, a code-built `LoginForm`, and change `Program.Main` to gate `PrincipalForm` behind a modal dialog. The database is self-initializing: `UsuarioDAO` creates `Usuarios` when missing and seeds `admin` / `admin123` only when no users exist.

**Tech Stack:** C# .NET Framework 4.8, Windows Forms, Dapper, SQL Server, SHA-256 with per-user salt.

---

### Task 1: Password Hashing

**Files:**
- Create: `AlasComercialERP/Autenticacao/SenhaService.cs`
- Create: `AlasComercialERP.Tests/SenhaServiceTests.cs`
- Create: `AlasComercialERP.Tests/AlasComercialERP.Tests.csproj`

- [ ] **Step 1: Write failing tests**

Create a console test runner that calls `SenhaService.GerarHash`, `SenhaService.VerificarSenha`, and `SenhaService.CompararTempoFixo`.

- [ ] **Step 2: Run tests and verify RED**

Run the test project before `SenhaService` exists. Expected result: compilation fails because `AlasComercialERP.Autenticacao.SenhaService` is missing.

- [ ] **Step 3: Implement `SenhaService`**

Add salt generation with `RNGCryptoServiceProvider`, SHA-256 hash of salt bytes plus UTF-8 password bytes, Base64 persistence, and fixed-time byte comparison.

- [ ] **Step 4: Run tests and verify GREEN**

Run the console test project. Expected result: all password tests pass.

### Task 2: Authentication Data Layer

**Files:**
- Create: `AlasComercialERP/Mapeamento/Usuario.cs`
- Create: `AlasComercialERP/DAO/UsuarioDAO.cs`
- Create: `AlasComercialERP/Autenticacao/AutenticacaoService.cs`
- Create: `AlasComercialERP/Autenticacao/SessaoUsuario.cs`
- Modify: `AlasComercialERP.Tests/SenhaServiceTests.cs`
- Modify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] **Step 1: Write failing service tests**

Extend the console test runner with a fake user repository around `AutenticacaoService` behavior: active users authenticate, wrong passwords fail, inactive/missing users fail.

- [ ] **Step 2: Run tests and verify RED**

Run the test project. Expected result: compilation fails because `AutenticacaoService` and `Usuario` are missing.

- [ ] **Step 3: Implement mapping, DAO, session and service**

Create a `Usuario` model, an `IUsuarioRepositorio` interface, a SQL-backed `UsuarioDAO`, `SessaoUsuario`, and `AutenticacaoService`.

- [ ] **Step 4: Run tests and verify GREEN**

Run the console test project. Expected result: password and service tests pass.

### Task 3: Login UI Gate

**Files:**
- Create: `AlasComercialERP/Forms/LoginForm.cs`
- Modify: `AlasComercialERP/Program.cs`
- Modify: `AlasComercialERP/AlasComercialERP.csproj`

- [ ] **Step 1: Gate startup**

Change `Program.Main` to instantiate `LoginForm`, call `ShowDialog`, and only call `Application.Run(new PrincipalForm())` when the result is `DialogResult.OK`.

- [ ] **Step 2: Build code-only login form**

Create `LoginForm` with labels, text boxes, buttons, error label, `AcceptButton`, `CancelButton`, and a call to `AutenticacaoService.Autenticar`.

- [ ] **Step 3: Verify build**

Compile the solution or project. Expected result: build exits with code 0.

### Task 4: Final Verification

**Files:**
- Modify only if verification finds compile issues.

- [ ] **Step 1: Run tests**

Run the test project fresh and confirm all tests pass.

- [ ] **Step 2: Run build**

Compile the WinForms project fresh and confirm the build exits with code 0.

- [ ] **Step 3: Review requirements**

Confirm `Program.Main` blocks `PrincipalForm`, `LoginForm` cancels without opening the app, SQL initialization exists, passwords are hashed with salt, and `admin` / `admin123` seeds only when the table is empty.
