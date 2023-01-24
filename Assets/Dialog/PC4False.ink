PC4: Was möchten sie tun?

-
-> Divert1

== Divert1 ==
 + [Shutdown] Shutdown
    Das Herunterfahren des PCs kann zum Verlust von Daten führen die für die Forensik essentiell sind. Möchten Sie fortfahren?
        ++[Ja]
            Probieren Sie es von vorn. -> Divert1
        ++[Nein] -> Divert1
 + [Isolate] Isolate
    Das Isolieren des PCs sorgt für eine Abkapslung vom Netzwerk wodurch kein Zugang zum Internet oder zu jeglichen Servern möglich ist. Möchten Sie fortfahren?
        ++[Ja] 
            Der PC wurde aufgrund verdächtigen Logfiles isoliert. Code: 5 -> Divert1
        ++[Nein] -> Divert1
 + [Inspect] Inspect
    Datum: 02/01/2023 Uhrzeit: 16:45:26 <>
    Ereignis-ID: 1234 <>
    Ereigniskategorie: Warning <>
    Ereignisquelle: Application Name <>
    Ereignisnachricht: Unbekannte Anwendung wurde gestartet. <>
        ++[Zurück]
            Zurück -> Divert1
 + [Leave] ->EndPart


== EndPart ==
        
 
    -> END