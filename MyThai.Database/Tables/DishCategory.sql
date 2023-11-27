CREATE TABLE [dbo].[DishCategory]
(
	[Id_DishCategory] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,

	CONSTRAINT PK_DishCategory PRIMARY KEY ([Id_DishCategory]),
	CONSTRAINT UK_DishCategory UNIQUE([Name])
);

-- Possiblité d'ajouter d'autre info, par exemple l'ordre d'affichage