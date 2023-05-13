SELECT ObcanID, EvidenceObcanu.Jmeno, Prijmeni, DatumNarozeni, COALESCE(SPZ, 'No Vehicle') AS SPZ
FROM EvidenceObcanu
JOIN VyrobciVozidel ON VyrobciVozidel.CEO = ObcanID
LEFT JOIN EvidenceVozidel ON EvidenceVozidel.Vlastnik = ObcanID
