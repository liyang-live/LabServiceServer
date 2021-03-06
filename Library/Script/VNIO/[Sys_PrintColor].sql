USE [LAB_VNIO_MIX]
GO
/****** Object:  Table [dbo].[Sys_PrintColor]    Script Date: 02/17/2012 08:42:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_PrintColor](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [nvarchar](255) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Argb] [int] NOT NULL,
 CONSTRAINT [PK_Sys_PrintColor] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
