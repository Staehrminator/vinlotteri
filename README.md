Her er readme-fila til vinlotteriet!

<br>

Det vi har:

En Azure Functions app med swagger og noe mock data.

<br>

Det vi vil ha:

Bruke globale JSON serializer settings så vi slipper å spesifisere dem i hvert POST endepunkt.
Unit tester for ILotteryService - nå er dette imidlertid et demoprosjekt.
Flere endepunkter - vi skal gjøre mer enn å bare se på vin og kjøpe billett.

<br>

Senere:

En måte å persiste state. For eksempel, et lotteri kan representeres av en Lottery-klasse med CreatedAt og ExpiresAt. Objekter som Tickets og Wines blir da knyttet opp mot et Lottery. Jeg ville satt opp noe sånt i Entity Framework med Azure SQL.