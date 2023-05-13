SELECT MAX(BarvaID) AS BarvaID, PrestupekID, MAX(EvidenceVozidel.VozidloID) AS VozidloID, MAX(Vlastnik) AS [Provinilec], MAX(Text) AS [Duvod], MAX(Vydal) AS [VydalID], MAX(EvidenceObcanu.ObcanID) AS [ObcanID], MAX(Jmeno) AS Jmeno, MAX(Prijmeni) AS Prijmeni
FROM EvidenceVozidel
JOIN EvidenceObcanu ON EvidenceObcanu.ObcanID = Vlastnik
JOIN EvidencePrestupku ON EvidencePrestupku.Viník = EvidenceObcanu.ObcanID
WHERE BarvaID = 0 AND Vydal = 2 -- Pavel
GROUP BY PrestupekID