# Projekt-Dokumentation


Gruppe Cheetah: Eser, Willi, Evans, Manser, Greub  
Gruppenleiter: Greub

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|25.10.22 | 0.0.1   | User stories, Testfälle und Arbeitspakete wurden geschrieben.|
| 01.11.22| 0.0.2    |  User Stories 1 - 8 umgesetzt und in die Projektdokumentation eingetragen       |
|8.11.22| 0.0.3| User Stories 1-9 weiterhin umgesetzt und Probleme im Programm behoben.| 

## 1 Informieren

### 1.1 Ihr Projekt

In diesem Projekt geht es darum, einen Vokabel Trainer zu programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |Funktional| Als Benutzer möchte ich, dass die Eingaben gespeichert werden.|
| 2    | Muss            |Funktional| Als Benutzer möchte ich, dass ich die Wörter eingeben.        |
| 3    | Muss            |Qualität  | Als Benutzer möchte ich, dass meine Punktezahl angezeigt wird.|
| 4    | Kann            |Qualität | Als Benutzer möchte ich, dass ich auf die Rechtschreibung überprüft werde.|
| 5    | Kann            |Qualität | Als Benutzer möchte ich, dass ich die Wörter die ich falsch hatte, wiederholen kann.|
| 6    | Kann            |Qualität | Als Benutzer möchte ich, dass von den gleichen Lernsets die Highscores verglichen werden.|
| 7    | Muss            |Funktional| Als Benutzer möchte ich gefragt werden, wie viele Wörter ich eingeben möchte.|
| 8    | kann            |Funtional | Als Benutzer möchte ich gefragt werden, in welcher Sprache ich die Wörter lernen will.|
| 9    | Muss            | Funktional| Als Benutzer möchte, dass Fehleingaben abgefangen werden.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Program gestartet | 1. Deutsch English 2. 1 3. Baum Tree         | Diese Wörter wurden gespeichert |
| 2.1  | Program gestartet | 1. Deutsch English 2. 1        | Welche Wörter wollen sie üben?                |
| 3.1  | Program gestartet | 1. Deutsch English 2. 2 3. Baum Tree 4. Auto Car 5. Deutsch 6. Tee 7. Tree 8. Car | ihr Score ist 1, Der Highscore ist 2 |
| 4.1  | Program gestartet | 1. Deutsch English 2. 1 3. Baum Tree 4. Baum Tee | Dies ist nicht korrekt, probieren sie es nochmal |
| 5.1  | Program gestartet | 1. Deutsch English 2. 1 3. Baum Tree 4. Baum Tee | Dies ist nicht korrekt, probieren sie es nochmal |
| 6.1  | Program gestartet | 1. Deutsch English 2. 2 3. Baum Tree 4. Auto Car 5. Baum Tee 6. Baum Tree 7. Auto Car | ihr Score ist 1, Der Highscore ist 2 |
| 7.1  | Program gestartet | 1. Deutsch EnglishD 4 | Geben sie hier ihre 4 Wörter ein: |
| 8.1  | Program gestartet | 1. Deutsch English 2. 1 3.Baum Tree | Wollen sie Deutsch zu Fremdsprache oder Fremdsprache zu Deutsch übersetzten [Deutsch/Fremd] |
| 9.1  | Program gestartet | 1. 4 | Inkorrekte eingabe, Geben sie ihre gewünschte Sprache ein |



### 1.4 Diagramme

![grafik](https://user-images.githubusercontent.com/110893008/197731211-13462d47-89ed-4213-912c-b27d8b4ca209.png)

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A | 1.11 | Manser | Eingaben werden gespeichert | 30 min |
| 2.A | 1.11 | Manser | Wörter eingeben | 10 min |
| 3.A | 1.11 | Evans | Punktezahl anzeigen | 30 min |
| 4.A | 1.11 | Willi | Falsche Wörter überprüfen | 30 min |
| 5.A | 8.11 | Willi | Falsche Wörter wiederholen | 30 min |
| 6.A | 8.11 | Evans | Highscore abspeichern | 60 min |
| 7.A | 1.11 | Eser | "Wie viele Wörter" Abfrage | 20 min |
| 8.A | 1.11 | Eser | Sprach Abfrage | 30 min |
| 9.A | 8.11 | Greub | Fehlerhafte Eingaben abfangen | 60 min |

Total: 


## 3 Entscheiden

Wir haben die User Storie 6 und 8 Nicht durchgeführt da wir es als unnötig empfunden haben

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   01.11.22    |     Manser      |      30 min        |     40 min              |
| 2.A  |   01.11.22    |     Manser      |        10 min      |         25 min          |
| 3.A  |  01.11.22     |     Evans      |           30 min    |       40 min            |
| 4.A  |   01.11.22    |       Willi    |            30 min  |              25 min     |
| 5.A  |    01.11.22   |      Willi     |        30 min      |              20 min     |
| 6.A  |   01.11.22    |     Evans      |         60 min     |      45 min             |
| 7.A  |  01.11.22     |      Eser     |       20 min       |        30 min           |
| 8.A  |   01.11.22    |      Eser     |      30 min        |             35 min      |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 15.11.22      | ok         | Greub      |
| 2.1  | 15.11.22     | ok         | Greub       |
| 3.1  | 15.11.22     | ok        |Greub|
| 4.1  | 15.11.22 | ok | Greub|
| 5.1  | 15.11.22 | ok | Greub|
| 7.1  | 15.11.22 | ok | Manser|
| 9.1 | 15.11.22 | ok |Manser|


Program ist bereit zur veröffentlichung


## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
