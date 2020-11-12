CREATE TABLE [dbo].[student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NOT NULL, 
    [cep] VARCHAR(10) NULL, 
    [district] VARCHAR(100) NULL, 
    [address] VARCHAR(100) NULL, 
    [number] INT NULL, 
    [birth] VARCHAR(10) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL,
    [photo] IMAGE NULL
    
)

CREATE TABLE [dbo].[situation_student] (
    [id]         INT          NOT NULL,
    [situation]  VARCHAR (10) NOT NULL,
    [student_id] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([student_id]) REFERENCES [dbo].[student] ([id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[responsible_student]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NOT NULL, 
    [kinship] VARCHAR(100) NULL,
    [student_id] INT NOT NULL,
    FOREIGN KEY([student_id]) REFERENCES [dbo].[student]([id]) ON DELETE CASCADE
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
    [birth] VARCHAR(10) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[package]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [description] VARCHAR(100) NULL, 
    [value] DECIMAL(18, 2) NULL
)

CREATE TABLE [dbo].[situation_package]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [situation] VARCHAR(10) NOT NULL,
	package_id INT NOT NULL,
	FOREIGN KEY ([package_id]) REFERENCES [dbo].[package]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[billing_parameters]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [value_penalty] DECIMAL(18, 2) NULL, 
    [value_interest] DECIMAL(18, 2) NULL, 
    [package_id] INT NULL,
	FOREIGN KEY ([package_id]) REFERENCES [dbo].[package]([id]) ON DELETE CASCADE
)