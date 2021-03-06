USE [master]
GO
/****** Object:  Database [sistema_ventas]    Script Date: 5/4/2021 8:16:33 AM ******/
CREATE DATABASE [sistema_ventas]
 
USE [sistema_ventas]
GO
/****** Object:  Table [dbo].[tb_cliente]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cliente](
	[iDCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[direccionCliente] [varchar](50) NULL,
	[duiCliente] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_detalleVenta]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_detalleVenta](
	[iDDetalleVenta] [int] IDENTITY(1,1) NOT NULL,
	[iDVenta] [int] NULL,
	[iDProducto] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 5) NULL,
	[total] [decimal](18, 5) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_documento]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_documento](
	[iDDocumento] [int] IDENTITY(1,1) NOT NULL,
	[nombreDocumento] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_producto]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](50) NULL,
	[precioProducto] [varchar](50) NULL,
	[estadoProducto] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuario](
	[iDUsuario] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NULL,
	[contrasena] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[iDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_venta]    Script Date: 5/4/2021 8:16:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_venta](
	[iDVenta] [int] IDENTITY(1,1) NOT NULL,
	[iDDocumento] [int] NULL,
	[iDCliente] [int] NULL,
	[iDUsuario] [int] NULL,
	[totalVenta] [decimal](18, 5) NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[iDVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_detalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tb_detalleVenta_tb_producto] FOREIGN KEY([iDProducto])
REFERENCES [dbo].[tb_producto] ([idProducto])
GO
ALTER TABLE [dbo].[tb_detalleVenta] CHECK CONSTRAINT [FK_tb_detalleVenta_tb_producto]
GO
ALTER TABLE [dbo].[tb_detalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_tb_detalleVenta_tb_venta] FOREIGN KEY([iDVenta])
REFERENCES [dbo].[tb_venta] ([iDVenta])
GO
ALTER TABLE [dbo].[tb_detalleVenta] CHECK CONSTRAINT [FK_tb_detalleVenta_tb_venta]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_cliente] FOREIGN KEY([iDCliente])
REFERENCES [dbo].[tb_cliente] ([iDCliente])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_cliente]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_documento1] FOREIGN KEY([iDDocumento])
REFERENCES [dbo].[tb_documento] ([iDDocumento])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_documento1]
GO
ALTER TABLE [dbo].[tb_venta]  WITH CHECK ADD  CONSTRAINT [FK_tb_venta_tb_usuario] FOREIGN KEY([iDUsuario])
REFERENCES [dbo].[tb_usuario] ([iDUsuario])
GO
ALTER TABLE [dbo].[tb_venta] CHECK CONSTRAINT [FK_tb_venta_tb_usuario]
GO
USE [master]
GO
ALTER DATABASE [sistema_ventas] SET  READ_WRITE 
GO

use sistema_ventas;
alter table tb_detalleventa alter column precio decimal(18,5)
alter table tb_detalleventa alter column total decimal(18,5)

alter table tb_venta alter column totalventa decimal(18,5)


use sistema_ventas;
--CRUD

--Create

Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Gerardo','Chalatenango','78727658')
Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Kevin','San Ignacio','3672736320')
Insert into tb_cliente  (nombreCliente,direccionCliente,duiCliente) values ('Will','Ilobasco','43628838')

--READ

Select * from tb_cliente

--UPDATE
update tb_cliente set duiCliente = 0987666432 where iDCliente = 12

--DELETE
delete from tb_cliente where iDCliente =12


--Create

Insert into tb_usuario(email,contrasena) values ('gerson@gmail','1234')
Insert into tb_usuario(email,contrasena) values ('aris@unab','1234')

--READ

Select * from tb_usuario

--UPDATE
update tb_usuario set contrasena = 1256 where iDUsuario = 6

--DELETE
delete from tb_usuario where iDUsuario =6

--Create

Insert into tb_documento(nombreDocumento) values ('Doc1')
Insert into tb_documento  (nombreDocumento) values ('Doc2')

--READ
Select * from tb_documento

--UPDATE
update tb_documento set nombreDocumento = ('Docf') where iDDocumento = 10

--DELETE
delete from tb_documento where iDDocumento =10


---Create
Insert into tb_producto  (nombreProducto,precioProducto,estadoProducto) values ('Teclado','233','Nuevo')
Insert into tb_producto  (nombreProducto,precioProducto,estadoProducto) values ('Bateria','10','Nuevo')

--READ
Select * from tb_producto

--UPDATE
update tb_producto set precioProducto = 2 where idProducto = 6

--DELETE
delete from tb_producto where idProducto =6

