Hey, kann ich dir helfen?

-
-> Divert1

== Divert1 ==
 * [Firma] Ja, weißt du wo ich die Firma IR-Simulation GmbH finde?
    Na klar, da war ich sogar auch schon zu Besuch. Halte dich stehts gerade aus, an den bunten Häusern vorbei. Auf der linken Seite siehst du dann ein großes Gebäude, dort musst du rein.
        **[Stadt] Danke, gibt es hier noch andere Sachen zu entdecken? Kennst du dich aus?
            Ja, aber momentan gibt es nicht viel zu tun außer sich umzusehen. Die meisten Leute sind in Ihrer Mittagspause und nehmen sich auch nicht die Zeit zu antworten. 
                ***[Danke] Danke, einen schönen Tag noch! -> EndPart
        **[Danke] Danke -> EndPart        
 * [Stadt] Ja, gibt es hier noch irgendwelche Sachen zu entdecken? Kennst du dich aus?
    Ja, aber bis auf die Firma am Ende der Straße gibt es nicht viel zu tun außer sich umzusehen. Die meisten Leute sind in Ihrer Mittagspause und nehmen sich auch nicht die Zeit zu antworten.
        **[Firma] Firma?
            Na die IR-Simulation GmbH am Ende der Straße. Halte dich stehts gerade aus, an den bunten Häusern vorbei. Auf der linken Seite siehst du dann ein großes Gebäude, dort musst du rein.
                ***[Danke] Danke, einen schönen Tag noch! -> EndPart 
        **[Danke] Danke, einen schönen Tag noch! -> EndPart
 
 + [Nein] ->EndPart


== EndPart ==
        
 
    -> END