CREATE TABLE [dbo].[user]
(
	[u_no] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [u_id] VARCHAR(10) NULL, 
    [u_pw] VARCHAR(10) NULL, 
    [u_name] NVARCHAR(10) NULL, 
    [u_date] DATE NULL
)
