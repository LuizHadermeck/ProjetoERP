if db_id(N'alascomercialerp') is null
begin
    create database alascomercialerp;
end
go

use alascomercialerp;
go

if object_id(N'dbo.Clientes', N'U') is null
begin
    create table dbo.Clientes
    (
        IdCliente int identity(1,1) not null,
        Nome nvarchar(150) not null,
        CPF_CNPJ nvarchar(20) null,
        Telefone nvarchar(30) null,
        Email nvarchar(150) null,
        Endereco nvarchar(250) null,
        constraint PK_Clientes primary key (IdCliente)
    );
end
go

if object_id(N'dbo.Fornecedores', N'U') is null
begin
    create table dbo.Fornecedores
    (
        IdFornecedor int identity(1,1) not null,
        Nome nvarchar(150) not null,
        CNPJ nvarchar(20) null,
        Telefone nvarchar(30) null,
        Email nvarchar(150) null,
        constraint PK_Fornecedores primary key (IdFornecedor)
    );
end
go

if object_id(N'dbo.Produtos', N'U') is null
begin
    create table dbo.Produtos
    (
        IdProduto int identity(1,1) not null,
        Nome nvarchar(150) not null,
        Descricao nvarchar(500) null,
        PrecoCusto decimal(18,2) not null constraint DF_Produtos_PrecoCusto default 0,
        PrecoVenda decimal(18,2) not null constraint DF_Produtos_PrecoVenda default 0,
        Estoque int not null constraint DF_Produtos_Estoque default 0,
        IdFornecedor int null,
        constraint PK_Produtos primary key (IdProduto),
        constraint FK_Produtos_Fornecedores foreign key (IdFornecedor)
            references dbo.Fornecedores (IdFornecedor)
    );
end
go

if object_id(N'dbo.Vendas', N'U') is null
begin
    create table dbo.Vendas
    (
        IdVenda int identity(1,1) not null,
        IdCliente int not null,
        DataVenda datetime2 not null constraint DF_Vendas_DataVenda default sysdatetime(),
        ValorTotal decimal(18,2) not null constraint DF_Vendas_ValorTotal default 0,
        StatusVenda nvarchar(50) null,
        constraint PK_Vendas primary key (IdVenda),
        constraint FK_Vendas_Clientes foreign key (IdCliente)
            references dbo.Clientes (IdCliente)
    );
end
go

if object_id(N'dbo.ItensVenda', N'U') is null
begin
    create table dbo.ItensVenda
    (
        IdItemVenda int identity(1,1) not null,
        IdVenda int not null,
        IdProduto int not null,
        Quantidade int not null,
        PrecoUnitario decimal(18,2) not null,
        constraint PK_ItensVenda primary key (IdItemVenda),
        constraint FK_ItensVenda_Vendas foreign key (IdVenda)
            references dbo.Vendas (IdVenda),
        constraint FK_ItensVenda_Produtos foreign key (IdProduto)
            references dbo.Produtos (IdProduto)
    );
end
go

if object_id(N'dbo.ProdutoComposicao', N'U') is null
begin
    create table dbo.ProdutoComposicao
    (
        IdComposicao int identity(1,1) not null,
        IdProdutoFinal int not null,
        IdProdutoMaterial int not null,
        Quantidade decimal(18,3) not null,
        constraint PK_ProdutoComposicao primary key (IdComposicao),
        constraint FK_ProdutoComposicao_ProdutoFinal foreign key (IdProdutoFinal)
            references dbo.Produtos (IdProduto),
        constraint FK_ProdutoComposicao_ProdutoMaterial foreign key (IdProdutoMaterial)
            references dbo.Produtos (IdProduto)
    );
end
go

if object_id(N'dbo.Usuarios', N'U') is null
begin
    create table dbo.Usuarios
    (
        IdUsuario int identity(1,1) not null,
        NomeUsuario nvarchar(50) not null,
        NomeExibicao nvarchar(100) not null,
        SenhaHash nvarchar(100) not null,
        SenhaSalt nvarchar(100) not null,
        Ativo bit not null constraint DF_Usuarios_Ativo default 1,
        CriadoEm datetime2 not null constraint DF_Usuarios_CriadoEm default sysdatetime(),
        constraint PK_Usuarios primary key (IdUsuario),
        constraint UQ_Usuarios_NomeUsuario unique (NomeUsuario)
    );
end
go

if not exists (select 1 from dbo.Usuarios where NomeUsuario = N'admin')
begin
    insert into dbo.Usuarios
        (NomeUsuario, NomeExibicao, SenhaHash, SenhaSalt, Ativo)
    values
        (
            N'admin',
            N'Administrador',
            N'KP5RRMXlfY1+zEE0yU+fVuQHoTxmEAzmpBiM8s7ZfbI=',
            N'AQIDBAUGBwgJCgsMDQ4PEA==',
            1
        );
end
go
