USE [RH]
GO

/****** Object:  Table [dbo].[Tempresafecha]    Script Date: 26/06/2022 23:47:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tempresafecha](
	[IEfechaingreso] [date] NULL,
	[IEfechaegreso] [date] NULL,
	[IEmotivo] [text] NULL,
	[IEempleadoID] [int] NOT NULL,
 CONSTRAINT [PK_Tempresafecha] PRIMARY KEY CLUSTERED 
(
	[IEempleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Tempresafecha]  WITH CHECK ADD  CONSTRAINT [FK_Tempresafecha_Templeado] FOREIGN KEY([IEempleadoID])
REFERENCES [dbo].[Templeado] ([EempleadoID])
GO

ALTER TABLE [dbo].[Tempresafecha] CHECK CONSTRAINT [FK_Tempresafecha_Templeado]
GO


