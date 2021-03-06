USE [master]
GO
/****** Object:  Database [HotelManagement]    Script Date: 8/12/2021 3:49:03 PM ******/
CREATE DATABASE [HotelManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelManagement', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelManagement_log', FILENAME = N'D:\SQL\MSSQL15.MSSQLSERVER\MSSQL\DATA\HotelManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HotelManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HotelManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [HotelManagement] SET  MULTI_USER 
GO
ALTER DATABASE [HotelManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HotelManagement', N'ON'
GO
ALTER DATABASE [HotelManagement] SET QUERY_STORE = OFF
GO
USE [HotelManagement]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [char](100) NULL,
	[password] [char](100) NULL,
 CONSTRAINT [PK__Admin__43AA4141AFAC360D] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[bill_id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[customer_id] [int] NULL,
	[begin_date] [date] NULL,
	[end_date] [date] NULL,
	[total] [money] NULL,
	[status] [nvarchar](100) NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK__Bill__D706DDB3B6B3A835] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[booking_id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[customer_id] [int] NULL,
	[status] [nvarchar](20) NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK__Booking__5DE3A5B1B2B424D7] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](100) NULL,
	[last_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[sex] [nvarchar](10) NULL,
	[phone_number] [char](15) NULL,
	[identity_card_number] [char](20) NULL,
 CONSTRAINT [PK__Customer__CD65CB8590E12A7B] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[price] [money] NULL,
	[type] [nvarchar](20) NULL,
	[amount] [int] NULL,
 CONSTRAINT [PK__Item__52020FDDACAA0E36] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[room_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[type] [nvarchar](50) NULL,
	[price] [money] NULL,
	[description] [nvarchar](500) NULL,
	[status] [nvarchar](20) NULL,
 CONSTRAINT [PK__Room__19675A8A35131D5D] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] IDENTITY(1,1) NOT NULL,
	[item_id] [int] NULL,
	[quantity] [int] NULL,
	[bill_id] [int] NULL,
 CONSTRAINT [PK__Service__3E0DB8AFC0564FA1] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[staff_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[position] [nvarchar](100) NULL,
 CONSTRAINT [PK__Staff__1963DD9CBBC7490B] PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([admin_id], [username], [password]) VALUES (1, N'admin                                                                                               ', N'admin                                                                                               ')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([bill_id], [room_id], [customer_id], [begin_date], [end_date], [total], [status], [created_at]) VALUES (1, 1, 1, CAST(N'2021-07-28' AS Date), CAST(N'2021-07-30' AS Date), 2000000.0000, N'Đã thanh toán', CAST(N'2021-07-28T22:01:57.237' AS DateTime))
INSERT [dbo].[Bill] ([bill_id], [room_id], [customer_id], [begin_date], [end_date], [total], [status], [created_at]) VALUES (2, 2, 1, CAST(N'2021-07-29' AS Date), CAST(N'2021-08-11' AS Date), 14000000.0000, N'Đã thanh toán', CAST(N'2021-07-29T09:58:37.380' AS DateTime))
INSERT [dbo].[Bill] ([bill_id], [room_id], [customer_id], [begin_date], [end_date], [total], [status], [created_at]) VALUES (3, 1, 2, CAST(N'2021-08-11' AS Date), CAST(N'2021-08-12' AS Date), 2075500.0000, N'Đã thanh toán', CAST(N'2021-08-11T23:17:19.390' AS DateTime))
INSERT [dbo].[Bill] ([bill_id], [room_id], [customer_id], [begin_date], [end_date], [total], [status], [created_at]) VALUES (4, 3, 3, CAST(N'2021-08-11' AS Date), NULL, 1000000.0000, N'Đặt trước', CAST(N'2021-08-11T23:29:00.953' AS DateTime))
INSERT [dbo].[Bill] ([bill_id], [room_id], [customer_id], [begin_date], [end_date], [total], [status], [created_at]) VALUES (1002, 2, 2, CAST(N'2021-08-12' AS Date), NULL, 1001000.0000, N'Chưa thanh toán', CAST(N'2021-08-12T14:47:33.853' AS DateTime))
SET IDENTITY_INSERT [dbo].[Bill] OFF
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([customer_id], [first_name], [last_name], [address], [sex], [phone_number], [identity_card_number]) VALUES (1, N'Nguyễn', N'Thái Sơn', N'Hà Nội', N'Nam', N'1231213        ', N'123123123           ')
INSERT [dbo].[Customer] ([customer_id], [first_name], [last_name], [address], [sex], [phone_number], [identity_card_number]) VALUES (2, N'Đào', N'Hải Long', N'Vĩnh Phúc', N'Nam', N'1231213        ', N'123123123           ')
INSERT [dbo].[Customer] ([customer_id], [first_name], [last_name], [address], [sex], [phone_number], [identity_card_number]) VALUES (3, N'Ngô', N'Việt Hà', N'Hà Nội', N'Nam', N'1231213        ', N'17287873            ')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Item] ON 

INSERT [dbo].[Item] ([item_id], [name], [price], [type], [amount]) VALUES (3, N'Coca Cola', 100.0000, NULL, 200)
INSERT [dbo].[Item] ([item_id], [name], [price], [type], [amount]) VALUES (4, N'Bò húc', 15000.0000, NULL, 30)
SET IDENTITY_INSERT [dbo].[Item] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (1, N'101', N'Phòng VIP', 1000000.0000, NULL, N'Còn trống')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (2, N'102', N'Phòng VIP', 1000000.0000, NULL, N'Có người')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (3, N'103', N'Phòng VIP', 1000000.0000, NULL, N'Đã đặt')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (4, N'104', N'Phòng đôi', 200000.0000, NULL, N'Còn trống')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (5, N'105', N'Phòng đơn', 300000.0000, NULL, N'Còn trống')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (6, N'106', N'Phòng đôi', 150000.0000, NULL, N'Còn trống')
INSERT [dbo].[Room] ([room_id], [name], [type], [price], [description], [status]) VALUES (7, N'107', N'Phòng VIP', 500000.0000, NULL, N'Còn trống')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Service] ON 

INSERT [dbo].[Service] ([service_id], [item_id], [quantity], [bill_id]) VALUES (2, 3, 5, 3)
INSERT [dbo].[Service] ([service_id], [item_id], [quantity], [bill_id]) VALUES (3, 4, 5, 3)
INSERT [dbo].[Service] ([service_id], [item_id], [quantity], [bill_id]) VALUES (1002, 3, 10, 1002)
SET IDENTITY_INSERT [dbo].[Service] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([staff_id], [name], [address], [position]) VALUES (1, N'Nguyễn Hoàng Hải', N'Nam Định', N'Quản lý')
INSERT [dbo].[Staff] ([staff_id], [name], [address], [position]) VALUES (2, N'Trần Thu Hà', N'Hà Nội', N'Lễ tân')
INSERT [dbo].[Staff] ([staff_id], [name], [address], [position]) VALUES (3, N'Nguyễn Thị Ngân', N'Hải Dương', N'Phục vụ phòng')
INSERT [dbo].[Staff] ([staff_id], [name], [address], [position]) VALUES (4, N'Hoàng Thu Thủy', N'Nam Định', N'Phục vụ phòng')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
ALTER TABLE [dbo].[Bill] ADD  CONSTRAINT [DF__Bill__created_at__31EC6D26]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Booking] ADD  CONSTRAINT [DF__Booking__created__32E0915F]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__customer_i__33D4B598] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([customer_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__customer_i__33D4B598]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK__Bill__room_id__34C8D9D1] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([room_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK__Bill__room_id__34C8D9D1]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK__Booking__custome__35BCFE0A] FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customer] ([customer_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK__Booking__custome__35BCFE0A]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK__Booking__room_id__36B12243] FOREIGN KEY([room_id])
REFERENCES [dbo].[Room] ([room_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK__Booking__room_id__36B12243]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK__Service__bill_id__37A5467C] FOREIGN KEY([bill_id])
REFERENCES [dbo].[Bill] ([bill_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK__Service__bill_id__37A5467C]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK__Service__item_id__38996AB5] FOREIGN KEY([item_id])
REFERENCES [dbo].[Item] ([item_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK__Service__item_id__38996AB5]
GO
/****** Object:  StoredProcedure [dbo].[updateBill]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateBill](@billid int,@roomId int,@customerId int,@beginDate date,@endDate date)
AS
BEGIN
	DECLARE @total money
	DECLARE @roomPrice money
	SELECT @roomPrice=DATEDIFF(DAY,@beginDate,@endDate)*R.price FROM Room R
						JOIN Bill B ON R.room_id=B.room_id
						WHERE B.bill_id=1
	SELECT @total= SUM(S.quantity*I.price) FROM Service S
					JOIN Item I ON S.item_id=I.item_id
					WHERE bill_id=1
	UPDATE Bill SET total=@total+@roomPrice WHERE @billid=bill_id
END
GO
/****** Object:  StoredProcedure [dbo].[updateItemFromService]    Script Date: 8/12/2021 3:49:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateItemFromService](@serviceId int,@quantity int)
AS
BEGIN
	DECLARE @amount int
	DECLARE @oldQuantity int
	DECLARE @itemId int
	DECLARE @result int
	SELECT @itemId=item_id FROM Service WHERE service_id=@serviceId
	SELECT @oldQuantity=quantity FROM Service WHERE service_id=@serviceId
	SELECT @amount=I.amount FROM Item I
					JOIN Service S ON S.item_id=I.item_id
					WHERE S.service_id=1
	IF(@quantity>@amount)
	BEGIN
		PRINT(N'Không có tên thuốc nào thỏa mãn!')
		RETURN 0
	END
	ELSE IF(@quantity>@oldQuantity)
	BEGIN
		UPDATE Service SET quantity=@quantity WHERE service_id=@serviceId
		UPDATE Item SET amount=amount-@quantity+@oldQuantity WHERE @itemId=item_id
		RETURN 1
	END
	ELSE IF(@quantity<@oldQuantity)
	BEGIN
		UPDATE Service SET quantity=@quantity WHERE service_id=@serviceId
		UPDATE Item SET amount=amount+@oldQuantity-@quantity WHERE @itemId=item_id
		RETURN 1
	END
	ELSE
	BEGIN
		RETURN 1
	END
END
GO
USE [master]
GO
ALTER DATABASE [HotelManagement] SET  READ_WRITE 
GO
