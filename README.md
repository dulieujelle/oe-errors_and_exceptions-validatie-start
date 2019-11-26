oe-errors_and_exceptions-validatie-start
# Validatie van getalinput
De bedoeling van deze oefening is via het gebruik van exceptions te voorkomen dat verkeerde input verwerkt zou worden.
Op basis van de check wordt er feedback gegeven aan de gebruiker.
## Check op het moment van de input
### Toevoegen van event handlers in runtime
Bij het opstarten van het programma worden aan de textboxen event handlers toegevoegd. 
Aan de property TextChanged wordt een event handler method toegevoegd.
### Checken of de input van een textbox geldig is
We proberen de input van een textbox die een integer moet bevatten om te zetten naar een geldig getal.
Als dit mislukt, wordt er een exception gegooid met een passende tekst.
#### Feedback naar de user
Bij een fout wordt:
- de focus naar de textbox met de fout gebracht en alles geselecteerd.
- de textbox gemarkeerd met een dikke, rode rand. Die verdwijnt als de fout opgelost is.
- in de tbkFeedback de message van de exception getoond met een rode achtergrond. tbkFeedback verdwijnt als de fout opgelost is.
### Checken met andere datatypes
Pas je code aan, zodat je ook kunt checken of de input en geldige float of decimal is.
## Check bij klik op btnBevestig
Er wordt nagegaan of alle input geldig is.
Bij Ok verschijnt er een gepaste melding in tbkFeedback. De achtergrond is dan groen.
Bij fouten verschijnt er een foutmelding in tbkFeedback. De achtergrond is rood.




