using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6IZUK_HSZF_2024251.Model
{
    // Ez az osztály a keresési feltételek reprezentálására szolgál vasútvonalak és szolgáltatások keresése során.
    public class CommandSearch
    {
        // A keresés típusa (pl. "RAILWAY" vagy "SERVICE").
        public string Type { get; set; }

        // Az a tulajdonság, amely alapján keresni szeretnénk (pl. "LINENAME", "TO").
        public string Property { get; set; }

        // A keresési feltételhez tartozó érték (pl. "Budapest", "120A").
        public string Value { get; set; }
    }
}
