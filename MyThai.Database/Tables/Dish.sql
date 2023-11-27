CREATE TABLE [dbo].[Dish]
(
	[Id_Dish] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(100) NOT NULL,
	[Description] NVARCHAR(500) NULL,
	[Price] DECIMAL(9, 2) NOT NULL,
	[Id_Category] INT NOT NULL,
	[IsDisabled] BIT NOT NULL DEFAULT 0,

	CONSTRAINT PK_Dish PRIMARY KEY ([Id_Dish]),
	CONSTRAINT CK_Dish__Price CHECK ([Price] >= 0),
	CONSTRAINT FK_Dish__Category
		FOREIGN KEY([Id_Category]) REFERENCES [DishCategory]([Id_DishCategory])
);
