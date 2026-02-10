using A6IZUK_HSZF_2024251.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A6IZUK_HSZF_2024251.Persistence.MsSql
{
    // Ez az osztály az XML formátumú fájlokból történő vasútvonal-adatok betöltését valósítja meg.
    public static class XmlDataLoader
    {
        // Vasútvonalak betöltése egy XML fájlból.
        // Paraméter:
        // - filePath: Az XML fájl elérési útja, amely tartalmazza a vasútvonalak adatait.
        // Visszatérés: Egy lista RailwayLine objektumokkal.
        public static List<RailwayLine> LoadRailwayLinesFromXml(string filePath)
        {

            var railwayLines = new List<RailwayLine>();
            try
            {
                // Az XML dokumentum betöltése az adott fájl útvonaláról.
                XDocument doc = XDocument.Load(filePath);

                // Az XML dokumentumban található "RailwayLine" elemek feldolgozása.
                foreach (var lineElement in doc.Descendants("RailwayLine"))
                {
                    // Egy RailwayLine objektum létrehozása az aktuális XML elem alapján.
                    var railwayLine = new RailwayLine
                    {
                        LineNumber = lineElement.Element("LineNumber")?.Value,
                        LineName = lineElement.Element("LineName")?.Value,
                        Services = new List<Service>()
                    };

                    // Az adott vasútvonalhoz tartozó "Service" elemek feldolgozása.
                    foreach (var serviceElement in lineElement.Descendants("Service"))
                    {
                        // Egy Service objektum létrehozása az aktuális XML elem alapján.
                        var service = new Service
                        {
                            From = serviceElement.Element("From")?.Value,
                            To = serviceElement.Element("To")?.Value,
                            TrainNumber = int.Parse(serviceElement.Element("TrainNumber")?.Value ?? "0"),
                            DelayAmount = int.Parse(serviceElement.Element("DelayAmount")?.Value ?? "0"),
                            TrainType = serviceElement.Element("TrainType")?.Value
                        };
                        railwayLine.Services.Add(service); // A járat hozzáadása a vasútvonalhoz.
                    }

                    railwayLines.Add(railwayLine); // A vasútvonal hozzáadása az eredménylistához.
                }
            }
            catch (Exception ex)
            {
                // Hiba esetén a kivétel részleteinek kiírása a konzolra.
                Console.WriteLine("An error occurred while loading XML data: " + ex.Message);
            }

            return railwayLines; // A betöltött vasútvonalak listájának visszaadása.
        }
    }
}
