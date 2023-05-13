CREATE TABLE [dbo].[EvidenceObcanu]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Jmeno] NCHAR(20) NOT NULL,
	[Prijmeni] NCHAR(20) NOT NULL, 
    [DatumNarozeni] DATETIME NOT NULL, 
    [CisloObcanskehoPrukazu] INT NOT NULL, 
    [Pohlavi] NCHAR(10) NOT NULL 
)
