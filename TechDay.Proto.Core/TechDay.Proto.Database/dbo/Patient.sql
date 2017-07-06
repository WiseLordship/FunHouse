CREATE TABLE [dbo].[Patient]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Prefix] VARCHAR(100) Null,
	[FirstName] VARCHAR(100) Null,
	[MiddleName] VARCHAR(100) Null,
	[LastName] VARCHAR(100) Null,
	[Suffix] VARCHAR(10) null
)
