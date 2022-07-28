# PruebaAPIUSE [PruebaApi]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 28/07/2022 1:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Edad] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (1, N'Perrito', N'12        ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (6, N'Lala', N'10        ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (7, N'Pepe', N'5         ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (8, N'Ñañaña', N'120       ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (9, N'Lila', N'30        ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (10, N'', N'120       ')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad]) VALUES (11, N'', N'120       ')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
