SELECT ObcanID AS [ObcanID], Jmeno, Prijmeni, Text, Typ FROM EvidenceObcanu
JOIN EvidencePrestupku on EvidencePrestupku.Viník = ObcanID
WHERE Typ = 4 -- dopravní nehoda