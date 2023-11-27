CREATE TABLE [dbo].[OrderDetail]
(
	[Id_OrderDetail] INT NOT NULL IDENTITY,
	[Id_Order] INT NOT NULL,
	[Id_Dish] INT NOT NULL,
	[Price] DECIMAL(9,2) NOT NULL,
	[Reduc] DECIMAL(9,2) NOT NULL DEFAULT 0,

	CONSTRAINT PK_OrderDetail PRIMARY KEY([Id_OrderDetail]),
	CONSTRAINT FK_OrderDetail__Order
		FOREIGN KEY([Id_Order]) REFERENCES [Order]([Id_Order]),
	CONSTRAINT FK_OrderDetail__Dish
		FOREIGN KEY([Id_Dish]) REFERENCES [Dish]([Id_Dish]),

)
