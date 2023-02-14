PC2: Was möchten sie tun? (Bediene die Button per Maus)

-
-> Divert1

== Divert1 ==
 + [Inspect] Inspect
    Datum: 02/09/2023 Uhrzeit: 13:25:26 | <>
    Prozessname: explorer.exe | <>
    Prozess-ID: 1234 | <>
    Prozessorbenutzung: 100% | <>
    Speicherverbrauch: 1GB
        ++[Zurück] -> Divert1
 + [Isolate] Isolate
    Das Isolieren des PCs sorgt für eine Abkapslung vom Netzwerk wodurch kein Zugang zum Internet oder zu jeglichen Servern möglich ist. Möchten Sie fortfahren?
        ++[Ja] 
            Der PC wurde aufgrund verdächtigen Logfiles isoliert. Zur weiteren Überprüfung wurde ein Ticket erstellt. Code: 2 
                +++[Leave] ->EndPart
        ++[Nein] -> Divert1
 + [Shutdown] Shutdown
    Das Herunterfahren des PCs kann zum Verlust von Daten führen die für die Forensik essentiell sind. Möchten Sie fortfahren?
        ++[Ja]
            Probieren Sie es von vorn. 
                +++[Leave] ->EndPart
        ++[Nein] -> Divert1
 + [Leave] ->EndPart


== EndPart ==
        
 
    -> END