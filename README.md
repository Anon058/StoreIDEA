USE [user46020]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Manufacturers]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturers](
	[ManufacturerID] [int] NOT NULL,
	[ManufacturerName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Manufacturers] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderDetailID] [int] NOT NULL,
	[OrderID] [int] NULL,
	[ProductID] [int] NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[OrderDate] [date] NULL,
	[DeliveryDate] [date] NULL,
	[PickupPointID] [int] NULL,
	[UserID] [int] NULL,
	[ReceiptCode] [int] NULL,
	[StatusID] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PickupPoints]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PickupPoints](
	[PickupPointID] [int] NOT NULL,
	[Address] [nvarchar](100) NULL,
 CONSTRAINT [PK_PickupPoints] PRIMARY KEY CLUSTERED 
(
	[PickupPointID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] NOT NULL,
	[Articul] [nvarchar](20) NULL,
	[ProductName] [nvarchar](100) NULL,
	[UnitOfMeasurementID] [int] NULL,
	[Price] [int] NULL,
	[SupplierID] [int] NULL,
	[ManufacturerID] [int] NULL,
	[CategoryID] [int] NULL,
	[Discount] [int] NULL,
	[QuantityInStock] [int] NULL,
	[Description] [nvarchar](100) NULL,
	[image] [nvarchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] NOT NULL,
	[RoleName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[StatusID] [int] NOT NULL,
	[StatusName] [nvarchar](20) NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnitOfMeasurements]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnitOfMeasurements](
	[UnitOfMeasurementID] [int] NOT NULL,
	[UnitOfMeasurementName] [nvarchar](10) NULL,
 CONSTRAINT [PK_UnitOfMeasurements] PRIMARY KEY CLUSTERED 
(
	[UnitOfMeasurementID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.03.2026 11:23:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[RoleID] [int] NULL,
	[Surname] [nvarchar](20) NULL,
	[Name] [nvarchar](20) NULL,
	[Patronymic] [nvarchar](20) NULL,
	[Login] [nvarchar](100) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Керамика')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Металл')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Дерево')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Магниты')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Брелоки')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Чайные наборы')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Новогодние товары')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Пасхальные товары')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (9, N'Свадебные товары')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (10, N'Открытки/Упаковка')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (11, N'Шкатулки')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (12, N'Текстиль')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (13, N'Декор для дома')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (14, N'Деловые подарки')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (15, N'Романтические подарки')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (16, N'Забавные подарки')
GO
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (1, N'Gzhel')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (2, N'Касли')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (3, N'Хохлома')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (4, N'Семенов')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (5, N'RussianGift')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (6, N'FunnyGift')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (7, N'МеталлДизайн')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (8, N'CarGift')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (9, N'Русский чай')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (10, N'ChineseTea')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (11, N'ЛФЗ')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (12, N'Тула')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (13, N'Елочка')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (14, N'LightStar')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (15, N'Пасхальный')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (16, N'ДекорПро')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (17, N'Cristal')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (18, N'PhotoBook')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (19, N'Свечной')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (20, N'CardStar')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (21, N'GiftBox')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (22, N'Палех')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (23, N'Музыка')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (24, N'Павловский Посад')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (25, N'Лен')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (26, N'WoodArt')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (27, N'PaintByNum')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (28, N'OfficeStyle')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (29, N'Parker')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (30, N'Promo')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (31, N'LoveGift')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (32, N'AntiStress')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (33, N'MagicCup')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (34, N'FunnyClock')
INSERT [dbo].[Manufacturers] ([ManufacturerID], [ManufacturerName]) VALUES (35, N'GameLand')
GO
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (2, 2, 5, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (3, 3, 20, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (4, 4, 25, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (5, 5, 29, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (6, 6, 3, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (7, 7, 16, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (8, 8, 39, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (9, 9, 51, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (10, 10, 56, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (11, 11, 60, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (12, 12, 2, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (13, 13, 8, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (14, 14, 22, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (15, 15, 27, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (16, 16, 31, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (17, 17, 54, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (18, 18, 1, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (19, 19, 15, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (20, 20, 20, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (21, 1, 6, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (22, 2, 9, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (23, 3, 21, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (24, 4, 26, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (25, 5, 30, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (26, 6, 13, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (27, 7, 18, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (28, 8, 41, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (29, 9, 52, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (30, 10, 57, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (31, 11, 61, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (32, 12, 4, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (33, 13, 11, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (34, 14, 24, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (35, 15, 17, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (36, 16, 58, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (37, 17, 55, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (38, 18, 5, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (39, 19, 16, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (40, 20, 21, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (41, 1, 10, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (42, 2, 15, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (43, 3, 23, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (44, 4, 28, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (45, 5, 32, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (46, 6, 46, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (47, 7, 19, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (48, 8, 49, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (49, 9, 53, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (50, 10, 59, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (51, 11, 63, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (52, 12, 43, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (53, 13, 48, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (54, 14, 36, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (55, 15, 40, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (56, 16, 62, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (57, 17, 13, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (58, 18, 44, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (59, 19, 9, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (60, 20, 23, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (61, 1, 38, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (62, 2, 42, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (63, 3, 36, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (64, 4, 33, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (65, 5, 34, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (66, 6, 47, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (67, 7, 37, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (68, 8, 7, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (69, 9, 14, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (70, 10, 35, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (71, 11, 12, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (72, 12, 45, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (73, 13, 50, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (74, 14, 37, 3)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (75, 15, 6, 5)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (76, 16, 64, 1)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (77, 17, 33, 4)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (78, 18, 46, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (79, 19, 38, 2)
INSERT [dbo].[OrderDetails] ([OrderDetailID], [OrderID], [ProductID], [Quantity]) VALUES (80, 20, 35, 3)
GO
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (1, CAST(N'2026-02-01' AS Date), CAST(N'2026-02-05' AS Date), 5, 7, 2001, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (2, CAST(N'2026-02-02' AS Date), CAST(N'2026-02-06' AS Date), 8, 8, 2002, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (3, CAST(N'2026-02-03' AS Date), CAST(N'2026-02-07' AS Date), 12, 9, 2003, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (4, CAST(N'2026-02-04' AS Date), CAST(N'2026-02-08' AS Date), 3, 10, 2004, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (5, CAST(N'2026-02-05' AS Date), CAST(N'2026-02-09' AS Date), 7, 11, 2005, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (6, CAST(N'2026-02-06' AS Date), CAST(N'2026-02-10' AS Date), 15, 12, 2006, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (7, CAST(N'2026-02-07' AS Date), CAST(N'2026-02-11' AS Date), 9, 13, 2007, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (8, CAST(N'2026-02-08' AS Date), CAST(N'2026-02-12' AS Date), 4, 14, 2008, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (9, CAST(N'2026-02-09' AS Date), CAST(N'2026-02-13' AS Date), 6, 7, 2009, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (10, CAST(N'2026-02-10' AS Date), CAST(N'2026-02-14' AS Date), 11, 8, 2010, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (11, CAST(N'2026-02-11' AS Date), CAST(N'2026-02-15' AS Date), 14, 9, 2011, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (12, CAST(N'2026-02-12' AS Date), CAST(N'2026-02-16' AS Date), 2, 10, 2012, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (13, CAST(N'2026-02-13' AS Date), CAST(N'2026-02-17' AS Date), 10, 11, 2013, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (14, CAST(N'2026-02-14' AS Date), CAST(N'2026-02-18' AS Date), 13, 12, 2014, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (15, CAST(N'2026-02-15' AS Date), CAST(N'2026-02-19' AS Date), 16, 13, 2015, 1)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (16, CAST(N'2026-02-16' AS Date), CAST(N'2026-02-21' AS Date), 18, 14, 2016, 2)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (17, CAST(N'2026-02-17' AS Date), CAST(N'2026-02-22' AS Date), 1, 7, 2017, 2)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (18, CAST(N'2026-02-18' AS Date), CAST(N'2026-02-23' AS Date), 5, 8, 2018, 2)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (19, CAST(N'2026-02-19' AS Date), CAST(N'2026-02-24' AS Date), 8, 9, 2019, 2)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [DeliveryDate], [PickupPointID], [UserID], [ReceiptCode], [StatusID]) VALUES (20, CAST(N'2026-02-20' AS Date), CAST(N'2026-02-25' AS Date), 12, 10, 2020, 2)
GO
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (1, N'420111, г. Казань, ул. Баумана, 142')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (2, N'125009, г. Москва, ул. Тверская, 92')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (3, N'630099, г. Новосибирск, Красный пр., 128')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (4, N'620075, г. Екатеринбург, ул. Ленина, 138')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (5, N'603005, г. Нижний Новгород, ул. Большая Покровская, 112')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (6, N'420061, г. Казань, ул. Николая Ершова, 128')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (7, N'344010, г. Ростов-на-Дону, пр. Ворошиловский, 132')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (8, N'450076, г. Уфа, ул. Ленина, 128')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (9, N'614000, г. Пермь, ул. Ленина, 138')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (10, N'660049, г. Красноярск, пр. Мира, 148')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (11, N'394018, г. Воронеж, ул. Плехановская, 118')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (12, N'443041, г. Самара, ул. Куйбышева, 158')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (13, N'400066, г. Волгоград, пр. Ленина, 128')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (14, N'410031, г. Саратов, ул. Московская, 138')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (15, N'625000, г. Тюмень, ул. Республики, 142')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (16, N'454091, г. Челябинск, ул. Кирова, 188')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (17, N'426076, г. Ижевск, ул. Пушкинская, 246')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (18, N'390000, г. Рязань, ул. Соборная, 118')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (19, N'150000, г. Ярославль, ул. Кирова, 114')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address]) VALUES (20, N'302028, г. Орел, ул. Ленина, 128')
GO
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (1, N'FIGUR001', N'Статуэтка "Сова" (керамика)', 1, 890, 1, 1, 1, 5, 34, N'Ручная роспись, высота 12см', N'figur1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (2, N'FIGUR002', N'Статуэтка "Кот" (керамика)', 1, 990, 1, 1, 1, 4, 28, N'Гжель, сине-белая роспись', N'figur2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (3, N'FIGUR003', N'Статуэтка "Дракон" (металл)', 1, 1290, 1, 2, 2, 3, 12, N'Каслинское литье, чугун', N'figur3.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (4, N'FIGUR004', N'Статуэтка "Лошадь" (дерево)', 1, 790, 1, 3, 3, 4, 23, N'Хохломская роспись', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (5, N'FIGUR005', N'Матрешка (5 в 1)', 1, 1590, 1, 4, 3, 5, 19, N'Классическая, ручная роспись', N'figur5.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (6, N'MAGN001', N'Магнит "Москва" (Кремль)', 1, 190, 2, 5, 4, 4, 156, N'Сувенирный, керамика', N'magn1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (7, N'MAGN002', N'Магнит "Санкт-Петербург"', 1, 190, 2, 5, 4, 3, 145, N'Символы города', N'magn2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (8, N'MAGN003', N'Магнит "Кот" (забавный)', 1, 150, 2, 6, 4, 5, 234, N'Смешной, с надписью', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (9, N'MAGN004', N'Набор магнитов "Города" (10 шт)', 2, 1590, 2, 5, 4, 4, 23, N'Разные города России', N'magn4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (10, N'KEY001', N'Брелок "Подкова" (металл)', 1, 290, 3, 7, 5, 4, 78, N'На удачу, никель', N'key1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (11, N'KEY002', N'Брелок "Монета" (счастливая)', 1, 350, 3, 7, 5, 3, 67, N'С инкрустацией, латунь', N'key2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (12, N'KEY003', N'Брелок "Животное" (кошка)', 1, 190, 3, 6, 5, 5, 89, N'Мягкий, плюшевый', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (13, N'KEY004', N'Набор брелоков (6 шт)', 2, 890, 3, 6, 5, 4, 34, N'Разные фигурки', N'key4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (14, N'KEY005', N'Брелок "Автомобильный"', 1, 390, 3, 8, 5, 3, 45, N'С подсветкой, кожа', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (15, N'TEA001', N'Чайный набор "Русский чай"', 2, 1290, 4, 9, 6, 5, 23, N'Чай, пряники, мед', N'tea1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (16, N'TEA002', N'Чайный набор "Китайский"', 2, 1590, 4, 10, 6, 4, 18, N'Пуэр, чайник, пиалы', N'tea2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (17, N'TEA003', N'Чайная пара (чашка+блюдце)', 2, 690, 4, 11, 6, 3, 34, N'Фарфор, золотой ободок', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (18, N'TEA004', N'Самовар (сувенирный) 1л', 1, 2990, 4, 12, 6, 5, 7, N'Сувенирный, расписной', N'tea4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (19, N'TEA005', N'Пряники тульские (набор)', 2, 590, 4, 12, 6, 4, 45, N'Печатные, разные начинки', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (20, N'NEWYEAR001', N'Елочная игрушка "Шар" (стекло)', 1, 390, 5, 13, 7, 5, 67, N'Красный, с блестками', N'newyear1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (21, N'NEWYEAR002', N'Елочная игрушка "Шишка"', 1, 290, 5, 13, 7, 4, 89, N'Золотая, пластик', N'newyear2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (22, N'NEWYEAR003', N'Набор игрушек (10 шт)', 2, 1990, 5, 13, 7, 5, 23, N'Разноцветные шары', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (23, N'NEWYEAR004', N'Гирлянда светодиодная 3м', 1, 890, 5, 14, 7, 4, 34, N'50 лампочек, мультицвет', N'newyear4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (24, N'NEWYEAR005', N'Искусственная елка 150см', 1, 3990, 5, 13, 7, 3, 12, N'Сборная, в коробке', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (25, N'EASTER001', N'Пасхальное яйцо (дерево)', 1, 490, 6, 3, 8, 4, 45, N'Ручная роспись', N'easter1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (26, N'EASTER002', N'Пасхальный набор (яйца+салфетки)', 2, 890, 6, 15, 8, 5, 23, N'5 яиц, наклейки', N'easter2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (27, N'EASTER003', N'Кулич сувенирный (керамика)', 1, 590, 6, 1, 8, 3, 19, N'С росписью', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (28, N'EASTER004', N'Пасхальный венок', 1, 990, 6, 16, 8, 4, 12, N'Декоративный, с цветами', N'easter4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (29, N'WEDD001', N'Свадебный бокалы (пара)', 2, 1590, 7, 17, 9, 5, 9, N'С гравировкой, хрусталь', N'wedd1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (30, N'WEDD002', N'Свадебный альбом (кожа)', 1, 2990, 7, 18, 9, 4, 7, N'30х30см, 50 листов', N'wedd2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (31, N'WEDD003', N'Подкова на свадьбу', 1, 890, 7, 7, 9, 3, 12, N'Деревянная, расписная', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (32, N'WEDD004', N'Свечи свадебные (набор)', 2, 690, 7, 19, 9, 4, 23, N'2 шт, с декором', N'wedd4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (33, N'BIRTH001', N'Открытка музыкальная', 1, 290, 8, 20, 10, 4, 67, N'С днем рождения, с мелодией', N'birth1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (34, N'BIRTH002', N'Открытка 3D (поп-ап)', 1, 390, 8, 20, 10, 3, 56, N'Объемная, ручная работа', N'birth2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (35, N'BIRTH003', N'Набор открыток (12 шт)', 2, 590, 8, 20, 10, 5, 34, N'Разные поводы', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (36, N'BIRTH004', N'Подарочная коробка (средняя)', 1, 190, 8, 21, 10, 2, 89, N'С крышкой, красная', N'birth4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (37, N'BIRTH005', N'Подарочный пакет (большой)', 1, 99, 8, 21, 10, 3, 145, N'С ручками, праздничный', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (38, N'SOUV001', N'Шкатулка "Хохлома" (малая)', 1, 990, 1, 3, 11, 5, 23, N'Дерево, роспись', N'souv1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (39, N'SOUV002', N'Шкатулка "Палех" (средняя)', 1, 2990, 1, 22, 11, 4, 8, N'Лаковая миниатюра', N'souv2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (40, N'SOUV003', N'Шкатулка музыкальная', 1, 1990, 1, 23, 11, 5, 12, N'С вращающейся балериной', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (41, N'SOUV004', N'Ларец (деревянный)', 1, 1590, 1, 3, 11, 3, 15, N'С замком, резной', N'souv4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (42, N'TEXT001', N'Платок павловопосадский', 1, 2490, 9, 24, 12, 5, 14, N'Шерсть, цветочный узор', N'text1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (43, N'TEXT002', N'Полотенце "Петухи" (льняное)', 1, 890, 9, 25, 12, 4, 23, N'С вышивкой, традиционное', N'text2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (44, N'TEXT003', N'Скатерть с вышивкой', 1, 1990, 9, 25, 12, 5, 9, N'Лен, 140х180см', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (45, N'TEXT004', N'Прихватки (набор 2 шт)', 2, 390, 9, 25, 12, 3, 45, N'С петухами, яркие', N'text4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (46, N'DECOR001', N'Панно настенное "Птица счастья"', 1, 1290, 10, 26, 13, 4, 12, N'Дерево, резьба', N'decor1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (47, N'DECOR002', N'Картина по номерам (набор)', 2, 890, 10, 27, 13, 5, 23, N'40х50см, краски в наборе', N'decor2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (48, N'DECOR003', N'Свеча декоративная "Дом"', 1, 490, 10, 19, 13, 3, 34, N'Ароматизированная, ваниль', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (49, N'DECOR004', N'Аромалампа керамическая', 1, 990, 10, 1, 13, 4, 15, N'Гжель, с чашей', N'decor4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (50, N'DECOR005', N'Фоторамка деревянная (10х15)', 1, 390, 10, 26, 13, 3, 56, N'С резьбой', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (51, N'BUSINESS001', N'Ежедневник (кожа) А5', 1, 1590, 11, 28, 14, 5, 23, N'Черный, с логотипом', N'bus1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (52, N'BUSINESS002', N'Ручка Parker (подарочная)', 1, 3990, 11, 29, 14, 4, 9, N'Металл, гравировка', N'bus2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (53, N'BUSINESS003', N'Набор (ручка+ежедневник)', 2, 4990, 11, 29, 14, 5, 7, N'В подарочной коробке', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (54, N'BUSINESS004', N'Бейдж с логотипом', 1, 290, 11, 30, 14, 3, 67, N'Металлический, гравировка', N'bus4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (55, N'BUSINESS005', N'Кружка с логотипом', 1, 490, 11, 30, 14, 4, 34, N'Керамика, полноцвет', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (56, N'ROMANTIC001', N'Свеча-сердце', 1, 590, 12, 31, 15, 4, 23, N'Красная, ароматическая', N'rom1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (57, N'ROMANTIC002', N'Набор для романтического вечера', 2, 1990, 12, 31, 15, 5, 8, N'Свечи, лепестки, масло', N'rom2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (58, N'ROMANTIC003', N'Валентинка ручной работы', 1, 290, 12, 31, 15, 3, 45, N'С кружевом', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (59, N'ROMANTIC004', N'Фоторамка-сердце', 1, 690, 12, 31, 15, 4, 19, N'Для двух фото', N'rom4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (60, N'FUN001', N'Игрушка-антистресс (сквиш)', 1, 390, 13, 32, 16, 4, 89, N'Котик, мягкий', N'fun1.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (61, N'FUN002', N'Светильник-проектор звездного неба', 1, 1290, 13, 14, 16, 5, 23, N'С пультом', N'fun2.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (62, N'FUN003', N'Кружка-хамелеон (меняет цвет)', 1, 590, 13, 33, 16, 4, 34, N'С фото', N'')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (63, N'FUN004', N'Будильник "Бегающий"', 1, 990, 13, 34, 16, 3, 12, N'С колесиками', N'fun4.jpg')
INSERT [dbo].[Products] ([ProductID], [Articul], [ProductName], [UnitOfMeasurementID], [Price], [SupplierID], [ManufacturerID], [CategoryID], [Discount], [QuantityInStock], [Description], [image]) VALUES (64, N'FUN005', N'Настольная игра "Подарочная"', 1, 890, 13, 35, 16, 4, 19, N'Для компании', N'')
GO
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (2, N'Менеджер')
INSERT [dbo].[Roles] ([RoleID], [RoleName]) VALUES (3, N'Авторизированный клиент')
GO
INSERT [dbo].[Statuses] ([StatusID], [StatusName]) VALUES (1, N'Завершен')
INSERT [dbo].[Statuses] ([StatusID], [StatusName]) VALUES (2, N'Новый')
GO
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (1, N'ООО "СувенирТрейд"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (2, N'ООО "СувенирМир"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (3, N'ООО "АксессуарПро"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (4, N'ООО "ПодаркиПро"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (5, N'ООО "Новогодний"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (6, N'ООО "ПасхаПро"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (7, N'ООО "СвадьбаПро"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (8, N'ООО "Поздравляю"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (9, N'ООО "ТекстильСувенир"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (10, N'ООО "ДекорПро"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (11, N'ООО "БизнесПодарок"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (12, N'ООО "Романтика"')
INSERT [dbo].[Suppliers] ([SupplierID], [SupplierName]) VALUES (13, N'ООО "FunGift"')
GO
INSERT [dbo].[UnitOfMeasurements] ([UnitOfMeasurementID], [UnitOfMeasurementName]) VALUES (1, N'шт')
INSERT [dbo].[UnitOfMeasurements] ([UnitOfMeasurementID], [UnitOfMeasurementName]) VALUES (2, N'набор')
GO
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (1, 1, N'Подарков', N'Иван', N'Петрович', N'i.podarkov@ideya.ru', N'IvanGift2026')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (2, 1, N'Сувенирова', N'Елена', N'Сергеевна', N'e.suvenirova@ideya.ru', N'ElenaSouvenir')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (3, 1, N'Праздников', N'Павел', N'Андреевич', N'p.prazdnikov@ideya.ru', N'PavelAdmin')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (4, 2, N'Магниткин', N'Денис', N'Викторович', N'd.magnitkin@ideya.ru', N'DenisManager')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (5, 2, N'Шкатулкина', N'Татьяна', N'Игоревна', N't.shkatulkina@ideya.ru', N'TatianaBox')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (6, 2, N'Открыткина', N'Ольга', N'Алексеевна', N'o.otkrytkina@ideya.ru', N'OlgaMng')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (7, 3, N'Петров', N'Сергей', N'Николаевич', N'sergei.petrov@mail.ru', N'SergeiGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (8, 3, N'Иванова', N'Ольга', N'Дмитриевна', N'olga.ivanova@yandex.ru', N'OlgaGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (9, 3, N'Смирнов', N'Алексей', N'Викторович', N'alex.smirnov@gmail.com', N'AlexGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (10, 3, N'Кузнецова', N'Елена', N'Павловна', N'elena.kuz@bk.ru', N'ElenaGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (11, 3, N'Морозов', N'Максим', N'Андреевич', N'maks.moroz@mail.ru', N'MaksGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (12, 3, N'Волкова', N'Наталья', N'Сергеевна', N'nat.volkova@yandex.ru', N'NataliaGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (13, 3, N'Козлов', N'Денис', N'Игоревич', N'den.kozlov@gmail.com', N'DenisGift')
INSERT [dbo].[Users] ([UserID], [RoleID], [Surname], [Name], [Patronymic], [Login], [Password]) VALUES (14, 3, N'Соколова', N'Анна', N'Владимировна', N'anna.sokol@bk.ru', N'AnnaGift')
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PickupPoints] FOREIGN KEY([PickupPointID])
REFERENCES [dbo].[PickupPoints] ([PickupPointID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PickupPoints]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Statuses] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Statuses] ([StatusID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Statuses]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Users]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Manufacturers] FOREIGN KEY([ManufacturerID])
REFERENCES [dbo].[Manufacturers] ([ManufacturerID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Manufacturers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Suppliers]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_UnitOfMeasurements] FOREIGN KEY([UnitOfMeasurementID])
REFERENCES [dbo].[UnitOfMeasurements] ([UnitOfMeasurementID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_UnitOfMeasurements]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
