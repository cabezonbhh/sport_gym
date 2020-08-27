USE [master]
GO
/****** Object:  Database [DB_Sport_Gym]    Script Date: 26/8/2020 10:24:57 ******/
CREATE DATABASE [DB_Sport_Gym]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_Sport_Gym', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DB_Sport_Gym.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_Sport_Gym_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\DB_Sport_Gym_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DB_Sport_Gym] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Sport_Gym].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Sport_Gym] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_Sport_Gym] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_Sport_Gym] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_Sport_Gym] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_Sport_Gym] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_Sport_Gym] SET  MULTI_USER 
GO
ALTER DATABASE [DB_Sport_Gym] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_Sport_Gym] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_Sport_Gym] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_Sport_Gym] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_Sport_Gym] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Sport_Gym', N'ON'
GO
ALTER DATABASE [DB_Sport_Gym] SET QUERY_STORE = OFF
GO
USE [DB_Sport_Gym]
GO
/****** Object:  Table [dbo].[Cuotas]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cuotas](
	[codCuota] [int] IDENTITY(1,1) NOT NULL,
	[fechaPago] [date] NULL,
	[fechaInicio] [date] NULL,
	[fechaFin] [date] NULL,
	[monto] [numeric](18, 2) NULL,
	[codInscripcion] [int] NULL,
 CONSTRAINT [pk_cuotas] PRIMARY KEY CLUSTERED 
(
	[codCuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripciones](
	[codInscripcion] [int] IDENTITY(1,1) NOT NULL,
	[fechaAlta] [date] NULL,
	[nroSocio] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_inscripciones] PRIMARY KEY CLUSTERED 
(
	[codInscripcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Socios]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Socios](
	[nroSocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](80) NULL,
	[telefono] [varchar](12) NULL,
	[celular] [varchar](12) NULL,
	[dni] [varchar](10) NULL,
	[borrado] [bit] NULL,
	[horaInicio] [varchar](5) NULL,
	[horaFin] [varchar](5) NULL,
 CONSTRAINT [pk_socios] PRIMARY KEY CLUSTERED 
(
	[nroSocio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cuotas] ADD  CONSTRAINT [DF__Cuotas__fechaPag__4316F928]  DEFAULT (getdate()) FOR [fechaPago]
GO
ALTER TABLE [dbo].[Inscripciones] ADD  CONSTRAINT [DF__Inscripci__fecha__3F466844]  DEFAULT (getdate()) FOR [fechaAlta]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__nombre__37A5467C]  DEFAULT ('Sin dato') FOR [nombre]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__apellido__38996AB5]  DEFAULT ('Sin dato') FOR [apellido]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__email__398D8EEE]  DEFAULT ('Sin dato') FOR [email]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__telefono__3A81B327]  DEFAULT ('Sin dato') FOR [telefono]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__celular__3B75D760]  DEFAULT ('Sin dato') FOR [celular]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [DF__Socios__dni__3C69FB99]  DEFAULT ('Sin dato') FOR [dni]
GO
ALTER TABLE [dbo].[Socios] ADD  CONSTRAINT [df_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Cuotas]  WITH CHECK ADD  CONSTRAINT [fk_cuotas_inscripciones] FOREIGN KEY([codInscripcion])
REFERENCES [dbo].[Inscripciones] ([codInscripcion])
GO
ALTER TABLE [dbo].[Cuotas] CHECK CONSTRAINT [fk_cuotas_inscripciones]
GO
ALTER TABLE [dbo].[Inscripciones]  WITH CHECK ADD  CONSTRAINT [fk_inscripcion_socios] FOREIGN KEY([nroSocio])
REFERENCES [dbo].[Socios] ([nroSocio])
GO
ALTER TABLE [dbo].[Inscripciones] CHECK CONSTRAINT [fk_inscripcion_socios]
GO
ALTER TABLE [dbo].[Cuotas]  WITH CHECK ADD  CONSTRAINT [monto_ingresado_mayor_a] CHECK  (([monto]>(-1)))
GO
ALTER TABLE [dbo].[Cuotas] CHECK CONSTRAINT [monto_ingresado_mayor_a]
GO
/****** Object:  StoredProcedure [dbo].[cuotas_por_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[cuotas_por_socio]
@nro int
as
select c.*
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where s.nroSocio = @nro
GO
/****** Object:  StoredProcedure [dbo].[listar_socios_por_apellido]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listar_socios_por_apellido]
@apellido varchar(50)
as
select *
from Socios
where apellido like @apellido + '%' and borrado = 0

GO
/****** Object:  StoredProcedure [dbo].[listar_socios_por_dni]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listar_socios_por_dni]
@dni varchar(10)
as
select *
from Socios
where dni  like @dni+'%' and borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[listar_socios_por_nombre]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listar_socios_por_nombre]
@nombre varchar(50)
as
select *
from Socios
where nombre like @nombre+'%' and borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[listar_socios_por_nroSocio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[listar_socios_por_nroSocio]
@id int
as
select *
from Socios
where nroSocio = @id and borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_baja_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_baja_socio]
@nroSocio int
as

BEGIN TRANSACTION 
BEGIN TRY

update Socios
set borrado = 1
where nroSocio = @nroSocio;

update Inscripciones
set borrado = 1
where nroSocio = @nroSocio


COMMIT TRANSACTION 

END TRY

BEGIN CATCH

/* si hay un error, deshacemos los cambios*/ 
ROLLBACK TRANSACTION
SELECT @@ROWCOUNT

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_emilinar_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_emilinar_socio]
@nroSocio int
as
delete Socios
where nroSocio = @nroSocio
GO
/****** Object:  StoredProcedure [dbo].[sp_get_inscripcion_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_get_inscripcion_socio]
@nroSocio int
as
select *
from Inscripciones
where nroSocio = @nroSocio and borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_historial_pago_por_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_historial_pago_por_socio]
@nroSocio int
as
select c.*
from Cuotas c join Inscripciones i on c.codInscripcion = i.codInscripcion join Socios s on s.nroSocio = i.nroSocio
where i.nroSocio = @nroSocio and i.borrado = 0 and s.borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresos_esperados_por_mes]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ingresos_esperados_por_mes]
as
SELECT c.monto
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and MONTH(c.fechaFin) = MONTH(GETDATE()) and YEAR(c.fechaFin) = YEAR(GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[sp_ingresos_reales]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_ingresos_reales]
as
SELECT c.monto
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and MONTH(c.fechaPago) = MONTH(GETDATE()) and YEAR(c.fechaPago) = YEAR(GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_cuotas_por_inscripcion]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_cuotas_por_inscripcion]
@codInscripcion int
as
select * 
from Cuotas
where codInscripcion = @codInscripcion 
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_inscripciones_activas]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_inscripciones_activas]
as
select * 
from Inscripciones
where borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_inscripciones_inactivas]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_inscripciones_inactivas]
as
select * 
from Inscripciones
where borrado = 1

GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_activos]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_socios_activos]
as
select *
from Socios
where borrado = 0
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_baja]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_socios_baja]
as
select *
from Socios
where borrado = 1
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_con_cuota_vencida]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_socios_con_cuota_vencida]
as
SELECT s.nroSocio, s.nombre, s.apellido, c.fechaPago, c.fechaInicio, c.fechaFin
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and c.fechaFin < GETDATE()
order by 1
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_pagaron_este_mes]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_socios_pagaron_este_mes]
as
SELECT s.nroSocio, s.nombre, s.apellido, c.monto, c.fechaPago
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and month(c.fechaPago) = month(getdate()) and year(c.fechaPago) = year(getdate())
order by 1
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_por_hora]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_socios_por_hora]
@horaInicio varchar(5),
@horaFin varchar(5)
as
select *
from Socios
where CAST(horaInicio AS time) >=  CAST(@horaInicio AS time)  and
	  CAST(horaFin AS time) <=  CAST(@horaFin AS time)
order by 9
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[sp_modificar_socio]
@nroSocio int,
@nombre varchar(50),
@apellido varchar(50),
@email varchar(80),
@telefono varchar(12),
@celular varchar(12),
@dni varchar(10),
@horaInicio varchar(5),
@horaFin varchar(5)
as
update Socios
set nombre = @nombre,
	apellido = @apellido,
	email = @email,
	telefono = @telefono,
	celular = @celular,
	dni = @dni,
	horaInicio = @horaInicio,
	horaFin = @horaFin
where nroSocio = @nroSocio
GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_cuota]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrar_cuota]
@inscripcion int,
@monto numeric(18,2),
@inicio datetime,
@fin datetime
as
insert into Cuotas(fechaInicio,fechaFin,monto,codInscripcion)
values(@inicio,@fin,@monto,@inscripcion)
GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_socio]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_registrar_socio]
@nombre varchar(50),
@apellido varchar(50),
@email varchar(80),
@telefono varchar(12),
@celular varchar(12),
@dni varchar(10),
@horaInicio varchar(5),
@horaFin varchar(5)
as

BEGIN TRANSACTION 
BEGIN TRY

insert into Socios(nombre,apellido,email,telefono,celular,dni,horaInicio,horaFin)
values(@nombre,@apellido,@email,@telefono,@celular,@dni,@horaInicio,@horaFin);

insert into Inscripciones(nroSocio,borrado)
values(IDENT_CURRENT('Socios'),0)

COMMIT TRANSACTION 

END TRY

BEGIN CATCH

/* si hay un error, deshacemos los cambios*/ 
ROLLBACK TRANSACTION
SELECT @@ROWCOUNT

END CATCH
GO
/****** Object:  StoredProcedure [dbo].[sp_socios_con_cuota_vencida]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_socios_con_cuota_vencida]
as
SELECT s.nroSocio
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and c.fechaFin < GETDATE()
order by 1
GO
/****** Object:  StoredProcedure [dbo].[sp_ultimos_pagos]    Script Date: 26/8/2020 10:24:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ultimos_pagos]
as
SELECT c.*
FROM Socios s JOIN Inscripciones i on (s.nroSocio = i.nroSocio) join Cuotas c on (i.codInscripcion = c.codInscripcion)
WHERE c.fechaPago in (SELECT MAX(c2.fechaPago)
   FROM Cuotas c2 join Inscripciones i2 on c2.codInscripcion = i2.codInscripcion
   WHERE i2.nroSocio = s.nroSocio)  and s.borrado = 0
order by 4

select * from Cuotas
GO
USE [master]
GO
ALTER DATABASE [DB_Sport_Gym] SET  READ_WRITE 
GO
