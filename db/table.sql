CREATE DATABASE dbGymControl

USE dbGymControl

CREATE TABLE [dbo].[students]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [name] VARCHAR(100) NOT NULL, 
    [cpf] VARCHAR(14) NOT NULL UNIQUE, 
    [birth] VARCHAR(10) NULL, 
    [phone] VARCHAR(15) NOT NULL, 
    [cep] VARCHAR(10) NULL, 
    [district] VARCHAR(100) NULL, 
    [address] VARCHAR(100) NULL, 
    [number] INT NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL,
    [photo] VARCHAR(100) NULL    
)

CREATE TABLE [dbo].[frequencies_student]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [situation] VARCHAR(7) NOT NULL, 
    [date] VARCHAR(10) NOT NULL, 
    [student_id] INT NOT NULL,    
	FOREIGN KEY ([student_id]) REFERENCES [dbo].[students]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[situations_student] (
    [id]         INT          NOT NULL,
    [situation]  VARCHAR (10) NOT NULL,
    [observation] VARCHAR(100) NULL,
    [student_id] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([student_id]) REFERENCES [dbo].[students] ([id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[responsibles_student] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (100) NULL,
    [cpf]        VARCHAR (14)  NOT NULL,
    [kinship]    VARCHAR (100) NULL,
    [phone]    VARCHAR (15) NULL,
    [student_id] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([student_id]) REFERENCES [dbo].[students] ([id]) ON DELETE CASCADE
);

CREATE TABLE modalities(
    [id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [description] VARCHAR(50) NOT NULL,
    [student_id] INT NOT NULL,
    FOREIGN KEY([student_id]) REFERENCES [dbo].[students]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[personal]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(100) NULL, 
    [cpf] VARCHAR(14) NULL UNIQUE, 
    [cep] VARCHAR(10) NULL, 
    [district] VARCHAR(100) NULL, 
    [address] VARCHAR(100) NULL, 
    [number] INT NULL, 
    [birth] VARCHAR(10) NULL, 
    [city] VARCHAR(50) NULL, 
    [state] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[packages] (
    [id]          INT             IDENTITY (1, 1) NOT NULL,
    [description] VARCHAR (100)   NOT NULL,
    [duration]    INT             NOT NULL,
    [period] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([id] ASC)
);


CREATE TABLE [dbo].[items_packages]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY (1, 1), 
    [formOfPayment] VARCHAR(50) NOT NULL, 
    [value] DECIMAL(18, 2) NOT NULL, 
    [package_id] INT NOT NULL,
	FOREIGN KEY ([package_id]) REFERENCES [dbo].[packages]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[billing_parameters_package] (
    [id]             INT             IDENTITY (1, 1) NOT NULL,
    [value_penalty]  DECIMAL (18, 2) NULL,
    [value_interest] DECIMAL (18, 2) NULL,
	[type_penalty]  VARCHAR (20) NULL,
    [type_interest] VARCHAR (20) NULL,
    [package_id]     INT             NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY REFERENCES [dbo].[packages] ON DELETE CASCADE
);

CREATE TABLE [dbo].[plans]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
	[number_portions] INT NOT NULL,
    [date_purchase_plan] VARCHAR NOT NULL,
    [package_id] INT NOT NULL, 
    [student_id] INT NOT NULL,
	FOREIGN KEY ([package_id]) REFERENCES [dbo].[packages]([id]) ON DELETE CASCADE,
	FOREIGN KEY ([student_id]) REFERENCES [dbo].[students]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[situations_plan] (
    [id]         INT          NOT NULL Identity,
    [situation]  VARCHAR (10) NOT NULL,
    [plan_id] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    FOREIGN KEY ([plan_id]) REFERENCES [dbo].[plans] ([id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[payments]
(
	[id] INT NOT NULL PRIMARY KEY,
    [portion] int NOT NULL, 
	[dueDate] VARCHAR(10) NOT NULL,
	[payday] VARCHAR(10) NULL,
    [plan_id] INT NULL,	
	FOREIGN KEY ([plan_id]) REFERENCES [dbo].[plans]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[forms_of_payment]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[description] VARCHAR(50) NOT NULL,
	payment_id INT NOT NULL,
	FOREIGN KEY ([payment_id]) REFERENCES [dbo].[payments]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[users]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[name_user] VARCHAR(50) NOT NULL UNIQUE,
	[password] VARCHAR(MAX) NOT NULL,
	[question] VARCHAR(100) NOT NULL,
	[answer] VARCHAR(100) NOT NULL,
    [avatar] varchar(MAX) NOT NULL,
	[date_registion] VARCHAR(10) NOT NULL
)

CREATE TABLE [dbo].[cash_flow]
(
	[id] INT NOT NULL PRIMARY KEY, 
	[opening_date] VARCHAR(10),
	[opening_time] VARCHAR(8),
    [cash_value_total] DECIMAL(18, 2) NULL, 
    [output_value_total] DECIMAL(18, 2) NULL,
	[closing_date] VARCHAR(10),
	[closing_time] VARCHAR(8),
	[user_id] INT NOT NULL,
	FOREIGN KEY ([user_id]) REFERENCES [dbo].[users]([id])
)


CREATE TABLE [dbo].[icoming_cash_flow]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[entry_date] VARCHAR(10) NOT NULL,
	[entry_time] VARCHAR(10) NOT NULL,
	[value_money] DECIMAL(18,2) NOT NULL,
	[value_card] DECIMAL(18,2) NOT NULL,
	[cash_flow_id] INT NOT NULL,
	FOREIGN KEY ([cash_flow_id]) REFERENCES [dbo].[cash_flow]([id]) ON DELETE CASCADE
)

CREATE TABLE [dbo].[outgoing_cash_flow]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[exit_date] VARCHAR(10) NOT NULL,
	[exit_time] VARCHAR(10) NOT NULL,
	[description_exit] VARCHAR(MAX) NOT NULL,
	[value_output] DECIMAL(18,2) NOT NULL,
	[cash_flow_id] INT NOT NULL,
	FOREIGN KEY ([cash_flow_id]) REFERENCES [dbo].[cash_flow]([id]) ON DELETE CASCADE)
