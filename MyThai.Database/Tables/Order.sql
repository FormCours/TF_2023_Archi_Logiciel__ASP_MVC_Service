CREATE TABLE [dbo].[Order]
(
	[Id_Order] INT NOT NULL IDENTITY,		-- Alternative -> UNIQUEIDENTIFIER
	[ClientName] NVARCHAR(50) NOT NULL,
	[ClientPhone] VARCHAR(50) NOT NULL,		-- Format supporté : +324 123 45 67
	[OrderDate] DATETIME2 NOT NULL DEFAULT(GETDATE()),
	[ReadyDate] DATETIME2 NOT NULL,
	[TotalPrice] DECIMAL(9,2) NOT NULL,

	CONSTRAINT PK_Order PRIMARY KEY([Id_Order])
)
