USE [Practice]
GO

/****** Object:  StoredProcedure [dbo].[procAddArticle]    Script Date: 10/14/2018 17:20:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Ajay>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procAddArticle]
	-- Add the parameters for the stored procedure here
	@ArticleTitle nvarchar(20),
	@ArticleDescription nvarchar(max),
	@pageID int,
	@CreatedDate Date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Articles (ArticleTitle,ArticleDescription,pageID,CreatedDate) values (@ArticleTitle,@ArticleDescription,@pageID,@CreatedDate)
END

GO


