SELECT PrestupekID, Datum, VozidloID, EvidenceVozidel.SPZ AS SPZ, 
	EvidenceVozidel.BarvaID AS BarvaVozidlaID, Barvy.Barva,
	Text AS [Duvod], EvidencePrestupku.Vydal AS [VydalID], EvidenceVydal.Jmeno AS JmenoVydal, 
	EvidenceVydal.Prijmeni AS PrijmeniVydal, EvidenceObcanu.ObcanID AS [ObcanID], 
	EvidenceObcanu.Jmeno AS JmenoVinik, EvidenceObcanu.Prijmeni AS PrijmeniVinik
FROM EvidenceVozidel
JOIN EvidenceObcanu ON EvidenceObcanu.ObcanID = EvidenceVozidel.Vlastnik
JOIN EvidencePrestupku ON EvidencePrestupku.Vozidlo = EvidenceVozidel.VozidloID
JOIN EvidenceObcanu AS EvidenceVydal ON EvidenceVydal.ObcanID = EvidencePrestupku.Vydal
JOIN Barvy ON Barvy.BarvaID = EvidenceVozidel.BarvaID
WHERE EvidenceVozidel.BarvaID = 0 -- Červená
AND EvidencePrestupku.Vydal = 2 -- Pavel;
ORDER BY PrestupekID desc