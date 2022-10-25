# Projekt-Dokumentation


Gruppe Cheetah: Eser, Willi, Evans, Manser, Greub  
Gruppenleiter: Greub

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ Beschreiben Sie Ihr Projekt in einem griffigen Satz.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |Funktional| Als Benutzer möchte ich, dass die Eingaben gespeichert werden.|
| 2    | Muss            |Funktional| Als Benutzer möchte ich, dass ich die Wörter eingeben.        |
| 3    | Muss            |Qualität  | Als Benutzer möchte ich, dass meine Punktezahl angezeigt wird.|
| 4    | Kann            |Qualität | Als Benutzer möchte ich, dass ich auf die Rechtschreibung überprüft werde.|
| 5    | Kann            |Qualität | Als Benutzer möchte ich, dass ich die Wörter die ich falsch hatte, wiederholen kann.|
| 6    | Kann            |Qualität | Als Benutzer möchte ich, dass ich die gleichen Wörter immmer wieder lernen kann.|
| 7    | Kann            |Qualität | Als Benutzer möchte ich, dass von den gleichen Lernsets die Highscores verglichen werden.|
| 8    | Muss            |Funktional| Als Benutzer möchte ich gefragt werden, wie viele Wörter ich eingeben möchte.|
| 9    | Muss            |Funtional | Als Benutzer möchte ich gefragt werden, in welcher Sprache ich die Wörter lernen will.|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

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

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
