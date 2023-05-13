SELECT ObcanID AS [ObcanID], Jmeno, Prijmeni, Text, Typ AS [TypID] FROM EvidenceObcanu
JOIN EvidencePrestupku on EvidencePrestupku.Viník = ObcanID
WHERE Typ = 4 -- dopravní nehoda