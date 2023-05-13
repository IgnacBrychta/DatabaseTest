CREATE TABLE [dbo].[EvidencePrestupku]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Text] NCHAR(500) NOT NULL, 
    [Vydal] INT NOT NULL, 
    [Typ] INT NOT NULL, 
    [Datum] DATETIME NOT NULL
)
