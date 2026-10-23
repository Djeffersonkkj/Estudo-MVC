USE DB_CadastroPessoa
GO

CREATE TABLE Pessoa (
	Id				INT IDENTITY,
	Nome			VARCHAR(200)	NOT NULL,
	DataNascimento	DATE			NOT NULL,
	Sexo			CHAR(1)			NOT NULL,
	EstadoCivil		VARCHAR(10)		NOT NULL,
	CPF				CHAR(11)		NOT NULL,
	CEP				CHAR(8)			NOT NULL,
	Endereco		VARCHAR(100)	NOT NULL,
	Numero			VARCHAR(10)		NOT NULL,
	Complemento		VARCHAR(50),
	Bairro			VARCHAR(30)		NOT NULL,
	Cidade			VARCHAR(30)		NOT NULL,
	Uf				CHAR(2)			NOT NULL,

	CONSTRAINT PK_IdPessoa PRIMARY KEY (Id),
	CONSTRAINT UQ_CPF UNIQUE (CPF),
	CONSTRAINT CHK_CPF CHECK (LEN(CPF) = 11),
	CONSTRAINT CHK_Sexo CHECK (Sexo IN ('M', 'F')),
	CONSTRAINT CHK_EstadoCivil CHECK (EstadoCivil IN ('Solteiro', 'Casado', 'Divorciado', 'Viúvo'))
)