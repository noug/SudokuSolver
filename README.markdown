# F# SudokuSolver Projekt

## Spielregeln

Das Ziel is es ein 9×9-Gitter mit den Ziffern 1 bis 9 so zu füllen, dass jede Ziffer in jeder Spalte, in jeder Zeile und in jedem Block (3×3-Unterquadrat) genau einmal vorkommt.

Mehr dazu unter http://de.wikipedia.org/wiki/Sudoku

## Aufgaben

* Festlegung eines sinnvollen Datentypen für das Spielfeld
* Zerlegung des Spielfelds in Zeilen, Spalten und Blöcke
* Bestimmung ob eine Zeile, Spalte oder Block valide ist
  * Alle Ziffern sind zwischen 1 und 9
  * Keine Ziffer kommt doppelt vor
* Entwicklung einer Funktion die prüft ob ein gegebenes Spielfeld gegen die Regeln verstößt
* Entwicklung einer Funktion die prüft ob ein gegebenes Spielfeld noch eine 0 enthält
* Entwicklung des Lösungsalgorithmus

## Hausaufgaben

* Beschreibung des Algorithmus in Worten - Leicht
* Implementierung von fillFirstEmptyPosition - Mittelschwer
* Implementierung von transpose in C# - Mittelschwer
* Extraktion der Boxen - Schwer

    let original =
        [[ 1;  2;  3;  4]
         [ 5;  6;  7;  8]
         [ 9; 10; 11; 12]
         [13; 14; 15; 16]]

    let extracted_boxes =
        [[ 1;  2;  5;  6]
         [ 3;  4;  7;  8]
         [ 9; 10; 13; 14]
         [11; 12; 15; 16]]

