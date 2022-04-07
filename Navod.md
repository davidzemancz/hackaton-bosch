# Navod
## Projekty
### Client
* Cast aplikace, ktera se stahne k uzivateli a tam se spusti v prohlizeci pomoci neceho, co se jmenuje WebAssembly.
* Jsou v ni tyto dulezite slozky a soubory
    * Pages - zde jsou razor komponenty v souborech s priponou .razer.
    * Shared - zde jsou take komponenty, ovsem ty, u kterych se predpoklada opakovane pouziti. Realne ale neni technicky rozdil mezi temi zde a v Pages.
    * _Imports.razor - soubor s usingy, ktere jsou platne pro vsechny soubory v projektu.
    * Program.cs - vstupni bod programu. Zde vyuzijeme atribut **builder.Services**, ktere se pak @inject do razor komponent, udelam na to nejaky priklad.
### Server
* Cast aplikace, ktera bezi permanentne na serveru a "ceka" na pozadavky (realne nasloucha na konkretnim portu). To ze je spolecna ma urcite dusleky, jako napriklad ze staticka promenna je spolecna pro vsehcny potencialni uzivatele a da se tak vyuzit jako databaze.
* Opet nejake dulezite slozky a soubory
    * Controllers - v teto sloze jsou tzv. controllery. Controller je proste trida, ktera zpracovava pozadavky z konkretni URI (viz atribut Route). Napriklad WeatherForecastController zpracovava pozadavky z route [controller], coz realne znamena z route "jmeno tridy" bez "controller", tedy "weatherforecast". V controller tride jsou metody, ktere zpracovavaji ruzne pozadavky z ruznych route a ruznych typu (HttpGet, HttpPost, HttpDelete...). Btw, route je myslenou tou casti za / v uri, napr pro localhost:57770/weatherforecast/list je route weatherforecast/list.
    * Startup.cs - zde opet vyuzijeme **Services**, ktere se pak daji predvat do controlleru, opet pripravim nejaky priklad.
### Shared
* Tady jsou veci, ktere jsou spolecne jako pro Server tak Client, tedy modely objektu apod.