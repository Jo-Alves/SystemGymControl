CREATE TABLE [dbo].[student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NOT NULL, 
    [cep] VARCHAR(10) NULL, 
    [district] VARCHAR(100) NULL, 
    [address] VARCHAR(100) NULL, 
    [number] INT NULL, 
    [birthday] VARCHAR(10) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[personal]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NULL, 
    [cep] VARCHAR(10) NULL, 
    [district] VARCHAR(100) NULL, 
    [address] VARCHAR(100) NULL, 
    [number] INT NULL, 
    [birthday] VARCHAR(10) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[responsible]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NOT NULL, 
    [kinship] VARCHAR(100) NULL,
    [student_id] INT NOT NULL,
    FOREIGN KEY([student_id]) REFERENCES [dbo].[student]([id]) ON DELETE CASCADE
)

drop table teacher