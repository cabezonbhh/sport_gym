
CREATE DATABASE [DB_Sport_Gym]
 
USE [DB_Sport_Gym]
GO
/****** Object:  Table [dbo].[Cuotas]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  Table [dbo].[Inscripciones]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  Table [dbo].[Socios]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  Table [dbo].[Ventas]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[codVenta] [int] IDENTITY(1,1) NOT NULL,
	[monto] [numeric](18, 2) NULL,
	[descripcion] [varchar](1000) NULL,
	[fechaVenta] [datetime] NULL,
	[codSocio] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [pk_venta] PRIMARY KEY CLUSTERED 
(
	[codVenta] ASC
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
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [fk_venta_socio] FOREIGN KEY([codSocio])
REFERENCES [dbo].[Socios] ([nroSocio])
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [fk_venta_socio]
GO
ALTER TABLE [dbo].[Cuotas]  WITH CHECK ADD  CONSTRAINT [monto_ingresado_mayor_a] CHECK  (([monto]>(-1)))
GO
ALTER TABLE [dbo].[Cuotas] CHECK CONSTRAINT [monto_ingresado_mayor_a]
GO
ALTER TABLE [dbo].[Ventas]  WITH CHECK ADD  CONSTRAINT [c_monto_ingresado] CHECK  (([monto]>(-1)))
GO
ALTER TABLE [dbo].[Ventas] CHECK CONSTRAINT [c_monto_ingresado]
GO
/****** Object:  StoredProcedure [dbo].[cuotas_por_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_socios_por_apellido]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_socios_por_dni]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_socios_por_nombre]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[listar_socios_por_nroSocio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_baja_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_cancelar_deuda]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_cancelar_deuda]
@codSocio int,
@codVenta int
as
update Ventas
set borrado = 0
where codSocio = @codSocio and codVenta = @codVenta
GO
/****** Object:  StoredProcedure [dbo].[sp_contar_ventas_fiadas]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_contar_ventas_fiadas]
@codSocio int
as
select codVenta
from Ventas
where borrado = 1 and codSocio = @codSocio
GO
/****** Object:  StoredProcedure [dbo].[sp_emilinar_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_get_estado_venta]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_get_estado_venta]
@codigo int
as
select borrado 
from ventas
where codVenta = @codigo
GO
/****** Object:  StoredProcedure [dbo].[sp_get_inscripcion_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_historial_pago_por_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ingresos_esperados_por_mes]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ingresos_reales]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_inscripciones_por_apellido]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inscripciones_por_apellido]
@apellido varchar(50) 
as
select i.* 
from Inscripciones i join Socios s on i.nroSocio = s.nroSocio
where i.borrado = 0 and apellido like @apellido+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_inscripciones_por_nombre]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_inscripciones_por_nombre]
@nombre varchar(50) 
as
select i.* 
from Inscripciones i join Socios s on i.nroSocio = s.nroSocio
where i.borrado = 0 and nombre like @nombre+'%'
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_cuotas_por_inscripcion]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_inscripciones_activas]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_inscripciones_inactivas]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_activos]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_baja]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_con_cuota_vencida]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listar_socios_con_cuota_vencida]
as
SELECT s.nroSocio, s.nombre, s.apellido, c.fechaPago, c.fechaInicio, c.fechaFin
from Socios s join Inscripciones i on s.nroSocio = i.nroSocio join Cuotas c on i.codInscripcion = c.codInscripcion
where c.fechaPago in (	select max(c2.fechaPago)
						from Cuotas c2
						where c2.codInscripcion = i.codInscripcion	
					 ) and DAY(c.fechaFin) < DAY(GETDATE()) and MONTH(c.fechaFin) = MONTH(GETDATE()) and YEAR(c.fechaFin) = YEAR(GETDATE())
order by 1
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_pagaron_este_mes]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_socios_por_hora]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_listar_ventas_fiadas]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_ventas_fiadas]
@codSocio int
as
select *
from Ventas
where borrado = 1 and codSocio = @codSocio
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_ventas_por_socio]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_ventas_por_socio]
@codSocio int
as
select *
from Ventas
where codSocio = @codSocio
GO
/****** Object:  StoredProcedure [dbo].[sp_modificar_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_registrar_cuota]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_registrar_socio]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_registrar_venta]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrar_venta]
@monto numeric(18,2),
@descripcion varchar(1000),
@codSocio int
as
insert into Ventas(monto,descripcion,fechaVenta,codSocio,borrado)
values(@monto,@descripcion,GETDATE(),@codSocio,0)
GO
/****** Object:  StoredProcedure [dbo].[sp_registrar_venta_fiado]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_registrar_venta_fiado]
@monto numeric(18,2),
@descripcion varchar(1000),
@codSocio int
as
insert into Ventas(monto,descripcion,fechaVenta,codSocio,borrado)
values(@monto,@descripcion,GETDATE(),@codSocio,1)
GO
/****** Object:  StoredProcedure [dbo].[sp_socios_con_cuota_vencida]    Script Date: 28/8/2020 23:35:27 ******/
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
/****** Object:  StoredProcedure [dbo].[sp_ultimos_pagos]    Script Date: 28/8/2020 23:35:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_ultimos_pagos]
as
SELECT c.*
FROM Socios s JOIN Inscripciones i on (s.nroSocio = i.nroSocio) join Cuotas c on (i.codInscripcion = c.codInscripcion)
WHERE c.fechaPago in (SELECT MAX(c2.fechaPago)
   FROM Cuotas c2 join Inscripciones i2 on c2.codInscripcion = i2.codInscripcion
   WHERE i2.nroSocio = s.nroSocio)  and s.borrado = 0
order by 4
GO
USE [master]
GO
ALTER DATABASE [DB_Sport_Gym] SET  READ_WRITE 
GO
