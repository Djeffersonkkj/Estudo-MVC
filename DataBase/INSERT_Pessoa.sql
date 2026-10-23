USE DB_CadastroPessoa
GO

INSERT INTO Pessoa (Nome, DataNascimento, Sexo, EstadoCivil, CPF, CEP, Endereco, Numero, Complemento, Bairro, Cidade, Uf)
VALUES  ('João da Silva', '1990-05-15', 'M', 'Solteiro', '12345678901', '12345678', 'Rua A', '100', 'Apto 101', 'Bairro A', 'Cidade A', 'SP'),
        ('Maria Souza', '1985-10-20', 'F', 'Casado', '98765432100', '87654321', 'Rua B', '200', NULL, 'Bairro B', 'Cidade B', 'RJ'),
        ('Carlos Oliveira', '1992-03-10', 'M', 'Divorciado', '45678912345', '23456789', 'Rua C', '300', NULL, 'Bairro C', 'Cidade C', 'MG'),
        ('Ana Santos', '1988-07-25', 'F', 'Viúvo', '32165498700', '34567890', 'Rua D', '400', NULL, 'Bairro D', 'Cidade D', 'BA'),
        ('Pedro Lima', '1995-12-05', 'M', 'Solteiro', '65498732100', '45678901', 'Rua E', '500', NULL, 'Bairro E', 'Cidade E', 'RS');