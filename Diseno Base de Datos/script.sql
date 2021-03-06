USE [master]
GO
/****** Object:  Database [Billetera_Electronica]    Script Date: 20/12/2020 14:21:31 ******/
CREATE DATABASE [Billetera_Electronica]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Billetera_Electronica', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Billetera_Electronica.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Billetera_Electronica_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Billetera_Electronica_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Billetera_Electronica] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Billetera_Electronica].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Billetera_Electronica] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET ARITHABORT OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Billetera_Electronica] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Billetera_Electronica] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Billetera_Electronica] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Billetera_Electronica] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Billetera_Electronica] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Billetera_Electronica] SET  MULTI_USER 
GO
ALTER DATABASE [Billetera_Electronica] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Billetera_Electronica] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Billetera_Electronica] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Billetera_Electronica] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Billetera_Electronica] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Billetera_Electronica] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Billetera_Electronica', N'ON'
GO
ALTER DATABASE [Billetera_Electronica] SET QUERY_STORE = OFF
GO
USE [Billetera_Electronica]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[barrio] [nchar](100) NOT NULL,
	[id_localidad] [int] NOT NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaAmiga]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaAmiga](
	[id_cuenta_amiga] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NOT NULL,
	[CVU] [bigint] NOT NULL,
	[fecha_ultima_transaccion] [date] NULL,
 CONSTRAINT [PK_CuentaAmiga] PRIMARY KEY CLUSTERED 
(
	[id_cuenta_amiga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cuentas]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuentas](
	[CVU] [bigint] IDENTITY(1000000,1) NOT NULL,
	[balance] [float] NOT NULL,
	[descripcion] [varchar](100) NOT NULL,
	[id_tipo_cuenta] [int] NULL,
	[estado] [bit] NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_baja] [datetime] NULL,
	[usuario] [nchar](50) NULL,
	[alias] [nchar](80) NOT NULL,
	[total_giro_descubierto] [float] NOT NULL,
 CONSTRAINT [PK_Cuentas] PRIMARY KEY CLUSTERED 
(
	[CVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaTipo]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaTipo](
	[id_tipo_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](100) NOT NULL,
	[descripcion] [nchar](100) NULL,
	[id_moneda] [int] NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_CuentaTipo] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidades]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidades](
	[id_localidad] [int] IDENTITY(1,1) NOT NULL,
	[localidad] [nchar](40) NOT NULL,
	[id_provincia] [int] NULL,
 CONSTRAINT [PK_Localidades] PRIMARY KEY CLUSTERED 
(
	[id_localidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Monedas]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Monedas](
	[id_moneda] [int] IDENTITY(1,1) NOT NULL,
	[abreviación] [nchar](10) NULL,
	[descripcion] [nchar](100) NULL,
	[estado] [bit] NULL,
	[cotizacion] [float] NULL,
	[nombre] [nchar](100) NULL,
 CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED 
(
	[id_moneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operaciones]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operaciones](
	[id_operacion] [int] NOT NULL,
	[CVU_cuenta] [bigint] NOT NULL,
	[CVU_cuenta_destino] [bigint] NULL,
	[CVU_cuenta_origen] [bigint] NULL,
	[verificacion_banco] [bit] NULL,
	[descripcion] [nchar](200) NULL,
	[fecha_ocurrencia] [date] NULL,
	[monto_original] [float] NOT NULL,
	[monto] [float] NULL,
	[id_tipo_operacion] [int] NOT NULL,
	[verificacion_origen_destino] [bit] NULL,
	[id_moneda] [int] NULL,
 CONSTRAINT [PK_Operaciones] PRIMARY KEY CLUSTERED 
(
	[id_operacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperacionesTipo]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperacionesTipo](
	[id_tipo_operacion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nchar](50) NULL,
	[estado] [bit] NULL,
	[nombre] [nchar](50) NULL,
 CONSTRAINT [PK_TransferenciaTipo] PRIMARY KEY CLUSTERED 
(
	[id_tipo_operacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PagoFacturas]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagoFacturas](
	[numero_factura] [int] NOT NULL,
	[id_servicio] [int] NOT NULL,
	[estado] [bit] NOT NULL,
	[fecha_factura] [datetime] NOT NULL,
	[monto] [float] NOT NULL,
	[CVU_cuenta] [bigint] NULL,
 CONSTRAINT [PK_PagoFacturas] PRIMARY KEY CLUSTERED 
(
	[numero_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[id_pais] [int] IDENTITY(1,1) NOT NULL,
	[pais] [nchar](40) NOT NULL,
 CONSTRAINT [PK_Paises] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlazosFijos]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlazosFijos](
	[id_plazo_fijo] [int] NOT NULL,
	[nombre] [nchar](40) NOT NULL,
	[descripcion] [nchar](100) NULL,
	[monto_ingresado] [float] NOT NULL,
	[monto_salida] [float] NOT NULL,
	[fecha_creacion] [datetime] NOT NULL,
	[fecha_finalizacion] [datetime] NOT NULL,
	[CVU_cuenta] [bigint] NULL,
 CONSTRAINT [PK_PlazosFijos] PRIMARY KEY CLUSTERED 
(
	[id_plazo_fijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[id_provincia] [int] IDENTITY(1,1) NOT NULL,
	[provincia] [nchar](100) NOT NULL,
	[id_pais] [int] NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[id_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Servicios]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicios](
	[id_servicio] [int] NOT NULL,
	[nombre] [nchar](20) NOT NULL,
	[descripcion] [nchar](50) NULL,
	[id_tipo_servicio] [int] NULL,
 CONSTRAINT [PK_Servicios] PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiciosTipo]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiciosTipo](
	[id_tipo_servicio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](30) NOT NULL,
 CONSTRAINT [PK_ServiciosTipo] PRIMARY KEY CLUSTERED 
(
	[id_tipo_servicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/12/2020 14:21:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[usuario] [nchar](50) NOT NULL,
	[nombre_titular] [nchar](80) NOT NULL,
	[contrasenia] [nchar](500) NOT NULL,
	[telefono] [nchar](100) NULL,
	[mail] [nchar](100) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[DNI] [int] NOT NULL,
	[calle_direccion] [nchar](100) NOT NULL,
	[numero_direccion] [int] NOT NULL,
	[id_barrio] [int] NOT NULL,
	[apellido_titular] [nchar](100) NULL,
	[id_usuario] [int] IDENTITY(100,1) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Barrios]  WITH CHECK ADD  CONSTRAINT [FK_Barrios_Localidades] FOREIGN KEY([id_localidad])
REFERENCES [dbo].[Localidades] ([id_localidad])
GO
ALTER TABLE [dbo].[Barrios] CHECK CONSTRAINT [FK_Barrios_Localidades]
GO
ALTER TABLE [dbo].[CuentaAmiga]  WITH CHECK ADD  CONSTRAINT [FK_CuentaAmiga_Cuentas1] FOREIGN KEY([CVU])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[CuentaAmiga] CHECK CONSTRAINT [FK_CuentaAmiga_Cuentas1]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_CuentaTipo] FOREIGN KEY([id_tipo_cuenta])
REFERENCES [dbo].[CuentaTipo] ([id_tipo_cuenta])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Cuentas_CuentaTipo]
GO
ALTER TABLE [dbo].[Cuentas]  WITH CHECK ADD  CONSTRAINT [FK_Cuentas_Usuarios] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuarios] ([usuario])
GO
ALTER TABLE [dbo].[Cuentas] CHECK CONSTRAINT [FK_Cuentas_Usuarios]
GO
ALTER TABLE [dbo].[CuentaTipo]  WITH CHECK ADD  CONSTRAINT [FK_CuentaTipo_Monedas] FOREIGN KEY([id_moneda])
REFERENCES [dbo].[Monedas] ([id_moneda])
GO
ALTER TABLE [dbo].[CuentaTipo] CHECK CONSTRAINT [FK_CuentaTipo_Monedas]
GO
ALTER TABLE [dbo].[Localidades]  WITH CHECK ADD  CONSTRAINT [FK_Localidades_Provincias] FOREIGN KEY([id_provincia])
REFERENCES [dbo].[Provincias] ([id_provincia])
GO
ALTER TABLE [dbo].[Localidades] CHECK CONSTRAINT [FK_Localidades_Provincias]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_Cuentas] FOREIGN KEY([CVU_cuenta])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_Cuentas]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_Monedas] FOREIGN KEY([id_moneda])
REFERENCES [dbo].[Monedas] ([id_moneda])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_Monedas]
GO
ALTER TABLE [dbo].[Operaciones]  WITH CHECK ADD  CONSTRAINT [FK_Operaciones_TipoOperacion] FOREIGN KEY([id_tipo_operacion])
REFERENCES [dbo].[OperacionesTipo] ([id_tipo_operacion])
GO
ALTER TABLE [dbo].[Operaciones] CHECK CONSTRAINT [FK_Operaciones_TipoOperacion]
GO
ALTER TABLE [dbo].[PagoFacturas]  WITH CHECK ADD  CONSTRAINT [FK_PagoFacturas_Cuentas] FOREIGN KEY([CVU_cuenta])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[PagoFacturas] CHECK CONSTRAINT [FK_PagoFacturas_Cuentas]
GO
ALTER TABLE [dbo].[PagoFacturas]  WITH CHECK ADD  CONSTRAINT [FK_PagoFacturas_Servicios] FOREIGN KEY([id_servicio])
REFERENCES [dbo].[Servicios] ([id_servicio])
GO
ALTER TABLE [dbo].[PagoFacturas] CHECK CONSTRAINT [FK_PagoFacturas_Servicios]
GO
ALTER TABLE [dbo].[PlazosFijos]  WITH CHECK ADD  CONSTRAINT [FK_PlazosFijos_Cuentas] FOREIGN KEY([CVU_cuenta])
REFERENCES [dbo].[Cuentas] ([CVU])
GO
ALTER TABLE [dbo].[PlazosFijos] CHECK CONSTRAINT [FK_PlazosFijos_Cuentas]
GO
ALTER TABLE [dbo].[Provincias]  WITH CHECK ADD  CONSTRAINT [FK_Provincias_Paises] FOREIGN KEY([id_pais])
REFERENCES [dbo].[Paises] ([id_pais])
GO
ALTER TABLE [dbo].[Provincias] CHECK CONSTRAINT [FK_Provincias_Paises]
GO
ALTER TABLE [dbo].[Servicios]  WITH CHECK ADD  CONSTRAINT [FK_Servicios_ServiciosTipo] FOREIGN KEY([id_tipo_servicio])
REFERENCES [dbo].[ServiciosTipo] ([id_tipo_servicio])
GO
ALTER TABLE [dbo].[Servicios] CHECK CONSTRAINT [FK_Servicios_ServiciosTipo]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Barrios]
GO
USE [master]
GO
ALTER DATABASE [Billetera_Electronica] SET  READ_WRITE 
GO
