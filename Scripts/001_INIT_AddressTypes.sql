/****** Script for SelectTopNRows command from SSMS  ******/
USE TestRegistration
GO


/*  
==============================================================================================  

==============================================================================================  
Name:        INITIALIZATION SCRIPTS: Populate AddressTypes
Owner:       SWE.NWOSU
Purpose:     AngularJS with WebAPI Demo
Developer:   ANWOSU, Create Date: 06/2018
Precondition: 
==============================================================================================  
*/  


SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO

BEGIN TRY	

--===== BEGIN =====
BEGIN TRANSACTION
-- INSERT SCRIPTS

IF NOT EXISTS(SELECT * FROM dbo.AddressTypes WHERE [Name] LIKE N'Address1') BEGIN
INSERT INTO dbo.AddressTypes([Name], [Description], [Position])VALUES  ( N'Address1', 'Address 1', 1) END

IF NOT EXISTS(SELECT * FROM dbo.AddressTypes WHERE [Name] LIKE N'Address2') BEGIN
INSERT INTO dbo.AddressTypes([Name], [Description], [Position])VALUES  ( N'Address2', 'Address 2', 2) END

COMMIT TRANSACTION
--===== END =====


END TRY

BEGIN CATCH

	ROLLBACK TRANSACTION
	DECLARE @ErrorMessage NVARCHAR(MAX)
	SET @ErrorMessage = ERROR_MESSAGE()
	RAISERROR (@ErrorMessage, 16,1)
	
END CATCH

GO
