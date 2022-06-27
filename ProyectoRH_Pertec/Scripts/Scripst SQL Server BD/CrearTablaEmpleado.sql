USE [RH]
GO

/****** Object:  Table [dbo].[Templeado]    Script Date: 26/06/2022 23:45:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Templeado](
	[EempleadoID] [int] NOT NULL,
	[Enombre] [varchar](30) NOT NULL,
	[Eapellido] [varchar](30) NOT NULL,
	[Eapellido2] [varchar](30) NULL,
	[Etelefono] [varchar](30) NULL,
	[Ecorreo] [varchar](30) NULL,
	[EpuestoID] [int] NOT NULL,
 CONSTRAINT [PK_Templeado] PRIMARY KEY CLUSTERED 
(
	[EempleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Templeado]  WITH CHECK ADD  CONSTRAINT [FK_Templeado_Tpuesto] FOREIGN KEY([EpuestoID])
REFERENCES [dbo].[Tpuesto] ([PpuestoID])
GO

ALTER TABLE [dbo].[Templeado] CHECK CONSTRAINT [FK_Templeado_Tpuesto]
GO


