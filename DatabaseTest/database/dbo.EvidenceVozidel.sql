CREATE TABLE [dbo].[EvidenceVozidel] (
    [VozidloID] INT        NOT NULL PRIMARY KEY,
    [SPZ]      NCHAR (10) NOT NULL,
    [Vlastnik] INT        NULL,
    [BarvaID]    INT        NOT NULL,
    [Vyrobce]  INT        NOT NULL,
);

