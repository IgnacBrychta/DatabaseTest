CREATE TABLE [dbo].[EvidenceVozidel]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[SPZ] NCHAR(10) NOT NULL,
	[Vlastnik] INT NULL,
	[Barva] INT NOT NULL,
	[Vyrobce] INT NOT NULL, 
    [Model] NCHAR(20) NOT NULL, 
    [ZarazeniDoProvozu] DATETIME NULL, 
    [Vykon] INT NOT NULL
)
