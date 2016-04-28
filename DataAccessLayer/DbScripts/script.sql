GO

/****** Object:  Table [dbo].[UserCategory]    Script Date: 4/28/2016 5:05:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
	[UserCategoryId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [fk_User_UserCat] FOREIGN KEY([UserCategoryId])
REFERENCES [dbo].[UserCategory] ([Id])
GO

ALTER TABLE [dbo].[User] CHECK CONSTRAINT [fk_User_UserCat]
GO

GO

/****** Object:  Table [dbo].[ContentType]    Script Date: 4/28/2016 5:05:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContentType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ArticleStatus]    Script Date: 4/28/2016 5:06:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ArticleStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

/****** Object:  Table [dbo].[ArticleCategory]    Script Date: 4/28/2016 5:06:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ArticleCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[Title] [nvarchar](max) NULL,
	[DateCreated] [datetime] NULL,
	[LastModifiedDate] [datetime] NULL,
	[LastModifiedBy] [int] NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[ArticleCategoryId] [int] NULL,
	[ArticleStatusId] [int] NULL,
	[Data] [nvarchar](max) NULL,
	[ContentTypeId] [int] NULL,
	[Duration] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [Content] FOREIGN KEY([ContentTypeId])
REFERENCES [dbo].[ContentType] ([Id])
GO

ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [Content]
GO

ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [fk_Article_Category] FOREIGN KEY([ArticleCategoryId])
REFERENCES [dbo].[ArticleCategory] ([Id])
GO

ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [fk_Article_Category]
GO

ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [fk_Article_LastModifiedBy] FOREIGN KEY([LastModifiedBy])
REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [fk_Article_LastModifiedBy]
GO

ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [fk_Article_Status] FOREIGN KEY([ArticleStatusId])
REFERENCES [dbo].[ArticleStatus] ([Id])
GO

ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [fk_Article_Status]
GO

ALTER TABLE [dbo].[Article]  WITH CHECK ADD  CONSTRAINT [fk_Article_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([Id])
GO

ALTER TABLE [dbo].[Article] CHECK CONSTRAINT [fk_Article_User]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Playlist](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Priority] [int] NULL,
	[ArticleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Playlist]  WITH CHECK ADD  CONSTRAINT [Fk_Playlist] FOREIGN KEY([ArticleId])
REFERENCES [dbo].[Article] ([Id])
GO

ALTER TABLE [dbo].[Playlist] CHECK CONSTRAINT [Fk_Playlist]
GO





