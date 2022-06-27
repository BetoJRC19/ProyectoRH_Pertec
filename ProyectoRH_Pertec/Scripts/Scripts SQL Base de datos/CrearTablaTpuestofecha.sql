USE [RH]
GO

/****** Object:  Table [dbo].[Tpuestofecha]    Script Date: 26/06/2022 23:46:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tpuestofecha](
	[PEfechaXempresaID] [int] IDENTITY(1,1) NOT NULL,
	[PEempleadoID] [int] NOT NULL,
	[PEpuestoID] [int] NULL,
	[PEfechainicio] [date] NULL,
	[PEfechafin] [date] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tpuestofecha]  WITH CHECK ADD  CONSTRAINT [FK_Tpuestofecha_Templeado] FOREIGN KEY([PEempleadoID])
REFERENCES [dbo].[Templeado] ([EempleadoID])
GO

ALTER TABLE [dbo].[Tpuestofecha] CHECK CONSTRAINT [FK_Tpuestofecha_Templeado]
GO


