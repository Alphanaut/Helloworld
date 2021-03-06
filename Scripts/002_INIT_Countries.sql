/****** Script for SelectTopNRows command from SSMS  ******/
USE TestRegistration
GO


/*  
==============================================================================================  

==============================================================================================  
Name:        INITIALIZATION SCRIPTS: Populate Countries
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

IF NOT EXISTS(SELECT * FROM dbo.Countries WHERE [CountryCode] LIKE N'USA') BEGIN
INSERT INTO dbo.Countries([CountryCode], [Name])VALUES  ( N'USA', 'United States') END

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
