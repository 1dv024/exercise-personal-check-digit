# <i class="fa fa-laptop"></i> Personlig kontrollsiffra

<figure>
<img src="img/luhnPatent.png" alt="Luhn Patent" />
<figcaption>
Figur 1. Patent för mekanisk dator för beräkning av kontrollsiffra.
</figcaption>
</figure>

[Personnummer](http://www.skatteverket.se/download/18.1e6d5f87115319ffba380001857/1359707375938/70408.pdf), liksom många andra nummer t.ex. artikelnummer och plusgironummer, innehåller en kontrollsiffra som beräknats enligt [Luhns algoritm](https://sv.wikipedia.org/wiki/Luhn-algoritmen/ "Läs om Luhn-algoritmen!"). Du ska skriva en klass, `PersonalIdentityNumber`, som ska validera om ett personnummer är korrekt eller inte. Klassen ska även kunna avgöra om personnumret tillhör en kvinna eller man.

Personnummer består av åtta eller sex siffror följt av ett (eventuellt) bindestreck, eller plustecken, och fyra avslutande siffror. Korrekt formaterade personnummer är på formaten `ÅÅMMDD-FFFK`, där `FFF` är ett löpnummer och `K` är en kontrollsiffra (svenska myndigheter lagrar dock personnummer på formatet `ÅÅÅÅMMDDFFFK`).

Andra tillåtna format är `ÅÅÅÅMMDD-FFFK`, `ÅÅMMDDFFFK` och `ÅÅMMDD+FFFK`, som alla ska kunna valideras. Då formatet `ÅÅMMDD-FFFK`, eller `ÅÅMMDDFFFK`, används så tillhör personnumret en person som inte fyllt 100 år. Förekommer det ett +-tecken i personnumret, `ÅÅMMDD+FFFK`, betyder det att personen har fyllt 100 år.

Eftersom du ska låta klassen `PersonalIdentityNumber` ärva från klassen `LuhnCheckDigit`, som är given, behöver inte din klass ha något ”eget” fält för numret, eller metod för att validera numret. Det tillhandahåller basklassen, och du kan koncentrera dig helt och hållet på valideringen av formatet, datumdelen av personnumret och om personnumret tillhör en kvinna eller man.

Basklassen `LuhnCheckDigit` innehåller en rad medlemmar, och av störst intresse är egenskapen `SantizedNumber` och `IsValid`, som du har användning av vid implementation av klassen `PersonalIdentityNumber`.

<figure>
<img src="img/PersonalIdentityNumber.png" alt="PersonalIdentityNumber" />
<figcaption>
Figur 2. Klassdiagram över <code>PersonalIdentityNumber</code> som ärver från <code>LuhnCheckDigit</code> samt den uppräkningsbara typen <code>Gender</code>.
</figcaption>
</figure>

## Klassen `PersonalIdentityNumber`

### Fält

#### PersonalIdentityNumberRegex

Enklast att kontrollera om ett personnummer har rätt format är att använda ett reguljärt uttryck. Instansiera ett objekt av klassen `Regex` med det reguljära uttrycket `@"^(\d{6}[-+]?|\d{8}-?)\d{4}$"` och undersök därefter om personnumret har rätt format med hjälp av metoden `IsMatch`, som returnerar ett boolskt värde. Det är det statiska privata "read-only" fältet `PersonalIdentityNumberRegex` som ska referera till `Regex`-objektet med det reguljära uttrycket..

### Egenskaper

#### Birthdate

...

#### BirthNumber

...

#### CheckDigit

...

#### Gender
Egenskapen `Gender` är av den uppräkningsbara typen `Gender` och ska returnera `Gender.Female` om personnumret tillhör en kvinna respektive `Gender.Male` om det är en man. Om den näst sista siffran i personnumret är jämn till hör personnumret en kvinna; är den udda en man. Anropas någon av egenskaperna för ett ogiltigt personnummer ska ett undantag kastas. Lämpligt undantag att kasta i detta fall är ett av typen `InvalidOperationException` som ska användas i de fall ”_when a method call is invalid for the object's current state_” som det står i dokumentationen.

#### IsValid

Egenskapen `IsValid`, som är publik och överskuggar (_overrides_) metoden med samma namn i basklassen, ska returnera `true` om formatet, datumet och kontrollsiffrans är korrekta; i övriga fall ska `false` returneras.

### Konstruktor
Klassen `PersonalIdentityNumber` har en konstruktor med en parameter av typen `string`, med standardvärdet "", vars parameter du skickar vidare till basklassen. Basklassen behöver information om hur många siffror, räknade från höger, som ska användas då personnumret valideras (10 siffror används vid valideringen).

### Metoder

#### ToString()

Metoden `ToString` i basklassen ska överskuggas (_overriden_) och ska alltid returnera en sträng med formatet `ÅÅÅÅMMDD-FFFK` oavsett vilket format som användes då personnumret matades in.

Är inte peronnumret giltigt är det lämpligt att du låter metoden returnera det oformaterade numret, d.v.s. det värde egenskapen `Number` har.

#### ToString(string format)

...

### TryParseBirtdate(out DateTime result)

...

## <i class="fa fa-flag-checkered"></i> Mål

Efter att ha gjort uppgiften ska du:

- Känna till hur du skapar en klass och instansierar objekt av den.
- Kunna skriva en klass som ärver från en basklass.
- Veta vad det innebär att överskugga en metod i en basklass.
- Förstå och hantera konstruktorer, egenskaper och metoder.
- Kunna använda reguljära uttryck för att verifiera att en sträng uppfyller ställda krav.
- Veta hur du kastar undantag.

## <i class="fa fa-lightbulb-o"></i> Tips

Läs om:

- ...

## <i class="fa fa-flask"></i> Lösningsförslag
<ul class="fa-ul fa-border exercise-info">
<li><i class="fa-li fa fa-github"></i><a href="https://github.com/1dv024/exercise-solution-proposals/tree/master/exercise-personal-check-digit">https://github.com/1dv024/exercise-solution-proposals/tree/master/exercise-personal-check-digit</a></li>
</ul>
