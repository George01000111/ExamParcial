
CREATE DATABASE BDEventos
GO
USE [BDEventos]
GO

/****** Object:  Table [dbo].[Eventos]    Script Date: 05/13/2019 22:28:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Eventos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [varchar](50) NULL,
	[Fecha_inicio] [datetime] NULL,
	[Autor] [varchar](50) NULL,
	[Tiempo_Inicio] [varchar](50) NULL,
	[Duracion_Horas] [varchar](50) NULL,
	[Descripcion] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
	[Id_User] [nvarchar](128) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


GO

/****** Object:  Table [dbo].[Comentario]    Script Date: 05/13/2019 22:28:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Comentario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEvento] [int] NULL,
	[Contenido] [varchar](50) NULL,
	[Fecha] [varchar](50) NULL,
	[Autor] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD  CONSTRAINT [FK_Comentario_Eventos] FOREIGN KEY([IdEvento])
REFERENCES [dbo].[Eventos] ([Id])
GO

ALTER TABLE [dbo].[Comentario] CHECK CONSTRAINT [FK_Comentario_Eventos]
GO


