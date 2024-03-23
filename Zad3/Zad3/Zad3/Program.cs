// See https://aka.ms/new-console-template for more information

using Zad3.Models;

Ship ship = new Ship("Tanker",13,100,50000);
Ship ship2 = new Ship("Tanker2",13,100,50000);


Plyny paliwo = new Plyny("paliwo", 10,20,100,5,"WRT");
Plyny mleko = new Plyny("mleko", 10,20,100,5,"QQQ");
Plyny mleko2 = new Plyny("mleko2", 10,20,100,5,"GLL");
Gaz gaz = new Gaz(40,23,100,4,"DRT");

/*ship.LoadShip(paliwo);
ship.LoadShip(mleko);
ship.LoadShip(mleko2);

Console.WriteLine(ship);
ship.UnloadShip(mleko);
Console.WriteLine(ship);*/



/*gaz.Load(0);
Console.WriteLine(gaz.NumerSeryjny + " " + gaz.MasaLadunku);
gaz.Load(10);
Console.WriteLine(gaz.NumerSeryjny + " " + gaz.MasaLadunku);
gaz.Unload();
gaz.Load(80);
Console.WriteLine(gaz.NumerSeryjny + " " + gaz.MasaLadunku);*/


//Chlodniczy chlodniczy = new Chlodniczy("jablko",45,45,4,100,32,"BGF");
Chlodniczy chlodniczy1 = new Chlodniczy("bananas",16,45,4,100,32,"BGF");

//Console.WriteLine("|" + chlodniczy.Rodzaj + "|" + chlodniczy.temperatura);
Console.WriteLine("|" + chlodniczy1.Rodzaj + "|" + chlodniczy1.temperatura);
