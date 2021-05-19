# Voorbeeld unit testing in C#
Deze applicatie betreft de receptie van een hotel en een aantal kamers die worden beheerd door deze receptie.

## Toevoegen test project
Voeg een "Unit Test Project" toe aan de solution. Dit geeft je een project waarin je de unit tests kunt plaatsen en van waaruit deze tests gedraaid kunnen worden.
!(Create test project)[Screenshots/Testing1.PNG]

Voordat je de classes en methods van je project kunt testen moet je een referentie toevoegen in je test project naar het project dat je wilt testen. Dit kan door via het "Add" menu op "Reference..." te klikken. 
!(Add reference)[Screenshots/Testing3.PNG]

In de reference manager, ga naar projects en vink het project dat je wilt testen aan.
!(Add reference in reference manager)[Screenshots/Testing4.PNG]

Nu kun je de unit tests voor je project gaan schrijven. In de Test explorer kun je de tests draaien, kun je zien welke tests succesvol zijn uitgevoerd en welke tests gefaald zijn. Ook is hier te zien hoe lang (in ms) iedere test nodig heeft. 
!(Add unit tests)[Screenshots/Testing5.PNG]
!(Failing unit tests)[Screenshots/Testing6.PNG]

In de code van het project dat je wilt testen staat ook bij iedere methode hoeveel tests van toepassing zijn om deze methode. Hierdoor is het makkelijk te zien welke methodes nog geen tests hebben.