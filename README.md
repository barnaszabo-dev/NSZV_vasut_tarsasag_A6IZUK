# 🚆 NSZV Vasúti Statisztikai Rendszer

## 📌 Projekt leírás

Az NSZV vasúttársaság számára készült rendszer célja a vasútvonalak és járatok késési adatainak feldolgozása, adatbázisban történő tárolása és statisztikai elemzése.

A program JSON formátumú fájlból olvassa be a vasútvonalak és járatok adatait, majd azokat adatbázisban tárolja és elemzi.

---

## 🛠 Alkalmazott technológiák

- C#
- JSON deszerializáció
- Adatbázis kezelés
- Eseménykezelés
- LINQ lekérdezések
- Fájlkezelés
- OOP tervezés

---

## 📂 Fő funkciók

### 🔹 JSON fájl betöltése
- A felhasználó kiválaszthat egy JSON fájlt
- A rendszer feldolgozza a vasútvonalakat és járatokat
- Az adatokat adatbázisba menti

### 🔹 Duplikáció kezelés
- Ha egy vasútvonal már létezik:
  - Csak az új járatok kerülnek hozzáadásra
  - A meglévők nem duplikálódnak

---

### 🔹 CRUD műveletek

A program futása közben lehetőség van:

- Új vasútvonal létrehozására
- Vasútvonal módosítására
- Vasútvonal törlésére
- Új járat kézi hozzáadására

---

### 🔔 Eseménykezelés

Ha egy új járat késése kisebb, mint az adott vasútvonal eddigi legkisebb késése,  
a rendszer esemény formájában értesíti a felhasználót.

---

## 📊 Generált statisztikák

A rendszer statisztikát készít és fájlba menti az alábbiakról:

### Vasútvonalanként:

- 5 percnél kisebb késéssel közlekedett járatok száma
- Átlagos késés mértéke
- Legkevesebbet késett járat
- Legtöbbet késett járat
- A legtöbb késő járatban szereplő célállomás  
  (5 perc vagy kevesebb nem számít késésnek)

A felhasználó opcionálisan megadhatja a kimeneti fájl mentési útvonalát.

---

## 🔍 Keresési és szűrési funkciók

- Vasútvonalak listázása
- Alap keresési funkció tulajdonságok alapján
- Több feltételes keresés támogatása
- Részleges szűrés kezelése
  (a felhasználó csak bizonyos mezőket is megadhat)

---

## 🗄 Példa JSON struktúra

```json
{
  "RailwayLines": [
    {
      "LineNumber": "120A",
      "LineName": "BP-Keleti->Szolnok",
      "Services": [
        {
          "From": "Szolnok",
          "To": "Budapest-Keleti",
          "TrainNumber": 3320,
          "DelayAmount": 3,
          "TrainType": "InterCity"
        }
      ]
    }
  ]
}


 
