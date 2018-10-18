USE [Practice]
GO

/****** Object:  StoredProcedure [dbo].[procAddPage]    Script Date: 10/18/2018 15:27:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Ajay>
-- Create date: <Create Date,13OCT 2018>
-- Description:	<Description,Added Page>
-- =============================================
CREATE PROCEDURE [dbo].[procAddPage]
	-- Add the parameters for the stored procedure here
	@pageName nvarchar(20),
	@isActive bit,
	@createdDate Date
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Pages (PageName ,IsActive,CreatedDate,Status) values(@pageName , @isActive,@createdDate,'completed')
	
	Select PageID from Pages where PageName=@pageName and IsActive = @isActive
END

GO


