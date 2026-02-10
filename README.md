NSZV 

Az NSZV vasúttársaság annak érdekében, hogy bebizonyítsa a vonataik igenis pontosak felbérelték Önt, a HSZF szoftverfejlesztő cég egyik alkalmazottját, hogy segítsen feldolgozni az adatokat. 
Adott egy JSON formátum, amelyben az egyes vasútvonalak és a vonalhoz tartozó járatok találhatóak. A program képes legyen a felhasználótól egy ilyen formátumú fájlt betölteni és a benne lévő adatokat elmenteni egy adatbázisba. Az ehhez szükséges adatbázis sémát, valamint az egyes táblák létrehozása az Ön feladata. 
További követelmény ha egy újabb fájl betöltésekor, ha már létezik az adott vonal, akkor csak az új járatokat adjuk hozzá! 
Legyen mód vasútvonalat létrehozni, módosítani, törölni a program futása alatt 
Arra is legyen mód, hogy kézzel is új járatokat tudjunk hozzáadni. Ha az adott járat kevesebbet késett, mint az adott vonalon bármelyik akkor erről a tényről esemény formájában értesítsük a felhasználót. 

Generáljon statisztikát a következőkről és mentse el egy fájlba: 
Vasútvonalanként az 5 percnél kisebb késéssel leközlekedett vonatok számát. 
Vasútvonalanként az átlagos késések mértékét, a legkevesebb és legtöbbet késett járatok adataival 
Vasútvonalanként a legtöbb késő járatban szereplő célállomást. (az 5 perc vagy alatti “késést” nem vesszük késésnek) 
Opcionálisan legyen lehetőség egy elérési útvonalat megadni ahova a kimeneti fájl elmentésre kerül. 
Legyen lehetőség listázni az egyes vasútvonalakat, de arra is legyen mód, hogy keressünk, illetve szűkítsük a lista eredményét.Ehhez a funkcionalitáshoz hozzon létre egy alap keresési funkciót, amely az egyes tulajdonságok alapján képes keresni. Előfordulhat az, hogy a felhasználó csak egy bizonyos tulajdonság alapján akar keresni, de lehet az összeset megadja, ezt kezelje a program! 

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

                }, 

                { 

                    "From": "Budapest-Keleti", 

                    "To": "Sülysáp", 

                    "DelayAmount": 10, 

                    "TrainType": "Passenger", 

                    "TrainNumber": 3210 

                } 

            ] 

        }, 

        { 

            "LineName": "BP-Nyugati->Szolnok", 

            "LineNumber": "100A", 

            "Services": [ 

                { 

                    "From": "BP-Nyugati", 

                    "To": "Cegléd", 

                    "TrainNumber": 4320, 

                    "DelayAmount": 25, 

                    "TrainType": "Passenger" 

                } 

            ] 

        } 

    ] 

} 

 
