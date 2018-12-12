USE [Practice]
GO

/****** Object:  Table [dbo].[Images]    Script Date: 12/12/2018 21:59:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Images](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[ImageName] [nvarchar](20) NOT NULL,
	[ImagePath] [nvarchar](400) NOT NULL,
	[PageID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedDate] [date] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [ForeignKey] FOREIGN KEY([PageID])
REFERENCES [dbo].[Pages] ([PageID])
GO

ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [ForeignKey]
GO


