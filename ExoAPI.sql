CREATE DATABASE ExoAPI
GO

USE ExoAPI 
GO

CREATE TABLE Projetos (
	Id INT PRIMARY KEY IDENTITY,
	Titulo VARCHAR(50) NOT NULL UNIQUE,
	Estado VARCHAR(30) NOT NULL,
	DataInicio DATE NOT NULL,
	Tecnologia VARCHAR(50) NOT NULL,
	Requisitos VARCHAR(50) NOT NULL,
	Area VARCHAR(50) NOT NULL,
)
GO

INSERT INTO Projetos (Titulo, Estado, DataInicio, Tecnologia, Requisitos, Area)
VALUES ('Projeto A', 'Completo', '20180912', 'JavaScript', 'VSCode', 'Back-End')
GO

INSERT INTO Projetos (Titulo, Estado, DataInicio, Tecnologia, Requisitos, Area)
VALUES ('Projeto B', 'Em Andamento', '20190620', 'C#', 'VSCode Visual', 'Back-End')
GO

CREATE TABLE Usuarios (
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) NOT NULL UNIQUE,
	Senha VARCHAR(50) NOT NULL,
	Tipo CHAR(1) NOT NULL,
)
GO

INSERT INTO Usuarios (Email, Senha, Tipo)
VALUES ('email1@email.com', '1234', '1')
GO

INSERT INTO Usuarios (Email, Senha, Tipo)
VALUES ('email2@email.com', '4321', '2')
GO

SELECT * FROM Usuarios WHERE Email = 'email1@email.com' AND Senha = '1234'
GO