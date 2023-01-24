PC3: Was möchten sie tun?

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
            Probieren Sie es von vorn. -> Divert1
        ++[Nein] -> Divert1
 + [Inspect] Inspect
    Datum: 01/02/2023 Uhrzeit: 12:42:56 <>
    Quelle IP: 192.168.1.1 <>
    Ziel IP: 192.168.1.2 <>
    Port: 80 Protokoll: TCP <>
    Datenmenge: 10 MB
        ++[Zurück]
            Zurück -> Divert1
 + [Leave] ->EndPart


== EndPart ==
        
 
    -> END