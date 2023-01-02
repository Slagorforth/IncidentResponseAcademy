Was möchten sie tun?

-
-> Divert1

== Divert1 ==
 + [Shutdown]
    Das Herunterfahren des PCs kann zum Verlust von Daten führen die für die Forensik essentiell sind. Möchten Sie fortfahren?
        **[Ja]
            Der PC wird heruntergefahren. -> Divert1
        **[Nein] -> Divert1
 + [Isolate] 
    Das Isolieren des PCs sorgt für eine Abkapslung vom Netzwerk wodurch kein Zugang zum Internet oder zu jeglichen Servern möglich ist. Möchten Sie fortfahren?
        **[Ja] 
            Der PC wird isoliert. -> Divert1
        **[Nein] -> Divert1
 + [Inspect] 
    Logfiles, bla bla Pc infiziert oder nicht.
        **[Ja]
            Der PC wird heruntergefahren. -> Divert1
        **[Nein] -> Divert1
 + [Leave] ->EndPart


== EndPart ==
        
 
    -> END