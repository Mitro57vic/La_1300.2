### Arbeitspakete

|Datum|	Arbeitspaket|	Verantwortliche Person|
| ---- | ------------ | ------- | ----------------- |
|23.08.2023|	Speichern zufallszahl 1-100 als geheimzahl|	Filip Mitrovic|
|23.08.2023	|Benutzer kann Zahlen raten|	Filip Mitrovic|
|23.08.2023|	Ausgabe von Hinweisen wenn Zahl falsch geraten wurde|	Filip Mitrovic|
|23.08.2023|	Ausgabe von Rateversuche|	Filip Mitrovic|
|23.08.2023|	Programm soll fehleingaben abfangen|	Filip Mitrovic|
|23.08.2023|	Highscore wird angezeigt|	Filip Mitrovic|
|23.08.2023|	Soundeffekte bei Flascheingaben|	Filip Mitrovic|




### Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
|      1.1      |   Programm wird geöffnet   |keine|Es soll eine zufällige Zahl generieren und speichern.        |
|     2.1       |     Programm läuft|Geratene Zahl vom User    |  Das Programm soll ausgeben ob es richtig oder falsch ist.                               |
| 2.2|   Programm Läuft  |  keine             |    Wenn die eingegebene Zahl vom User falsch war soll das Programm einen kleinen Hinweis geben, ob die Zahl grösser oder kleiner als die generierte Zahl ist.|
|  3.1   |     Programm Läuft |Alles andere als Integer| Programm gibt Hinweis, dass der User eine ungültige eingabe gemacht hat   |
|  3.2      |    Programm Läuft|Alles andere als Integer  |Programm lässt einen Sound abspielen wenn der falsche eingaben macht  |
|   4.1         |     Programm Läuft|keine     |Programm gibt aus wie viel versuche man gebraucht hat                                 |
|   4.2         |    Programm Läuft    |        keine       |    Programm gibt den aktuellen Highscore an.     |
|       5.1     |    Programm Läuft    |    User gibt "Ja" ein bei der Frage ob er nochmal eine Runde spielen möchte           |   neue zuffällige Zahl wird generiert und abgefragt |
|       5.2     |     Programm Läuft   |  User gibt "Nein" ein bei der Frage ob er noch einmal spielen möchte             |     Programm wird beendet                            |

			
