/****** Script for SelectTopNRows command from SSMS  ******/
USE TestRegistration
GO


/*  
==============================================================================================  

==============================================================================================  
Name:        INITIALIZATION SCRIPTS: Populate States
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

IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'AL') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'AL', N'Alabama', 1 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'AK') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'AK', N'Alaska', 2 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'AZ') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'AZ', N'Arizona', 3 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'AR') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'AR', N'Arkansas', 4 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'CA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'CA', N'California', 5 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'CO') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'CO', N'Colorado', 6 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'CT') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'CT', N'Connecticut', 7 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'DE') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'DE', N'Delaware', 8 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'DC') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'DC', N'District of Columbia', 9 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'FL') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'FL', N'Florida', 10 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'GA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'GA', N'Georgia', 11 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'HI') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'HI', N'Hawaii', 12 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'ID') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'ID', N'Idaho', 13 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'IL') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'IL', N'Illinois', 14 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'IN') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'IN', N'Indiana', 15 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'IA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'IA', N'Iowa', 16 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'KS') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'KS', N'Kansas', 17 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'KY') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'KY', N'Kentucky', 18 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'LA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'LA', N'Louisiana', 19 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'ME') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'ME', N'Maine', 20 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MD') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MD', N'Maryland', 21 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MA', N'Massachusetts', 22 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MI') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MI', N'Michigan', 23 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MN') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MN', N'Minnesota', 24 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MS') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MS', N'Mississippi', 25 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MO') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MO', N'Missouri', 26 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'MT') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'MT', N'Montana', 27 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NE') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NE', N'Nebraska', 28 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NV') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NV', N'Nevada', 29 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NH') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NH', N'New Hampshire', 30 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NJ') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NJ', N'New Jersey', 31 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NM') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NM', N'New Mexico', 32 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NY') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NY', N'New York', 33 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'NC') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'NC', N'North Carolina',34 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'ND') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'ND', N'North Dakota', 35 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'OH') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'OH', N'Ohio', 36 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'OK') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'OK', N'Oklahoma', 37 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'OR') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'OR', N'Oregon', 38 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'PA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'PA', N'Pennsylvania', 39 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'RI') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'RI', N'Rhode Island', 40 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'SC') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'SC', N'South Carolina', 41 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'SD') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'SD', N'South Dakota', 42 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'TN') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'TN', N'Tennessee', 43 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'TX') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'TX', N'Texas', 44 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'UT') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'UT', N'Utah', 45 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'VT') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'VT', N'Vermont', 46 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'VA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'VA', N'Virginia', 47 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'WA') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'WA', N'Washington', 48 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'WV') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'WV', N'West Virginia', 49 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'WI') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'WI', N'Wisconsin', 50 ) END
IF NOT EXISTS(SELECT * FROM dbo.States WHERE [USPSCode] LIKE N'WY') BEGIN
INSERT INTO dbo.States([USPSCode], [Name], [Position])VALUES (N'WY', N'Wyoming', 51 ) END

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
