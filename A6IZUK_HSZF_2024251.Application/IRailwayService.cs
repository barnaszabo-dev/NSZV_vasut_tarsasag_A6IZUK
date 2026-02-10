using A6IZUK_HSZF_2024251.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK_HSZF_2024251.Application
{
    // Az IRailwayService interfész definiálja a vasúti vonalakkal és szolgáltatásokkal
    // kapcsolatos alapvető üzleti logikát biztosító funkciókat.
    public interface IRailwayService
    {
        // Új vasúti vonal hozzáadása az adatbázishoz.
        void AddRailwayLines(RailwayLine line);

        // Új szolgáltatás (járat) hozzáadása egy adott vasútvonalhoz.
        // Paraméterek:
        // - lineNumber: a vasútvonal azonosítója.
        // - service: az új járat adatai.
        void AddServiceToRailWayLine(string lineNumber, Service service);

        // Az összes vasútvonal lekérése.
        // Visszatérés: egy lista az összes tárolt RailwayLine objektummal.
        List<RailwayLine> GetAllRailwayLines();

        // Egy vasútvonal adatainak frissítése.
        // Paraméterek:
        // - line: a frissített vasútvonal objektuma.
        void UpdateRailwayLine(RailwayLine line);

        // Egy vasútvonal törlése a megadott azonosító alapján.
        // Paraméterek:
        // - lineNumber: a törlendő vasútvonal azonosítója.
        void DeleteRailwayLine(string lineNumber);

        // Egy vasútvonal adatainak módosítása dinamikusan meghatározott tulajdonságok alapján.
        // Paraméterek:
        // - railwayLine: a módosítandó vasútvonal objektuma.
        // - property: a módosítandó tulajdonság neve.
        // - value: az új érték.
        // Visszatérés: a frissített RailwayLine objektum.
        RailwayLine ModifyRailway(RailwayLine railwayLine, string property, string value);

        // Egy adott szolgáltatás adatainak módosítása.
        // Paraméterek:
        // - railwayLine: a módosítandó szolgáltatás objektuma.
        // - index: a szolgáltatás indexe a listában.
        // - property: a módosítandó tulajdonság neve.
        // - value: az új érték.
        // Visszatérés: a frissített Service objektum.
        public Service ModifyService(Service railwayLine, int index, string property, string value);

        // Vasúti vonalak keresése különböző kritériumok alapján.
        // Paraméterek:
        // - commands: egy keresési feltételeket tartalmazó lista.
        // Visszatérés: a keresési feltételeknek megfelelő RailwayLine objektumok listája.
        public List<RailwayLine> SearchinRailway(List<CommandSearch> commands);

        // Statisztikai adatok generálása és mentése egy fájlba.
        // Paraméterek:
        // - outputPath: az eredmény fájl elérési útja.
        void CreateStatistics(string outputPath);
    }

}
