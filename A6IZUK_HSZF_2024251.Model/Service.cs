namespace A6IZUK_HSZF_2024251.Model
{
    // Az osztály egy vasúti járat adatait reprezentálja.
    public class Service
    {
        // A járat kiindulási állomásának neve (pl. "Budapest-Keleti").
        public string From { get; set; }

        // A járat célállomásának neve (pl. "Szolnok").
        public string To { get; set; }

        // A vonatszám, amely az adott járatot azonosítja (pl. 3320).
        public int TrainNumber { get; set; }

        // A járat késésének mértéke percekben (pl. 10).
        public int DelayAmount { get; set; }

        // A vonat típusa (pl. "InterCity", "Passenger").
        public string TrainType { get; set; }
    }
}
