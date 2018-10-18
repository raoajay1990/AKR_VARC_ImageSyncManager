USE [Practice]
GO

/****** Object:  StoredProcedure [dbo].[procAddImages]    Script Date: 10/14/2018 17:18:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Ajay>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procAddImages] 
	-- Add the parameters for the stored procedure here
	@ImageName nvarchar (20),
	@ImagePath nvarchar (50),
	@Image varbinary (max),
	@PageID int,
	@IsActive bit,
	@CreatedDate Date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Images(ImageName,ImagePath,Image,PageID,IsActive,CreatedDate) values (@ImageName,@ImagePath,@Image,@PageID,@IsActive,@CreatedDate)
END

GO


