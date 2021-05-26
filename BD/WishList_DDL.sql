--DDL

CREATE DATABASE WishList
GO

USE WishList
GO

CREATE TABLE Desejos
(
	idDesejos INT PRIMARY KEY IDENTITY
	,Desejo	VARCHAR(200) NOT NULL
	,Descricao VARCHAR(500)
)
GO

CREATE TABLE Usuarios
(
	idUsuario INT PRIMARY KEY IDENTITY
	,Email	VARCHAR(200) NOT NULL
	,Senha	VARCHAR(20) NOT NULL
)
GO