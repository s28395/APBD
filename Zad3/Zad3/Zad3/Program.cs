// See https://aka.ms/new-console-template for more information

using Zad3.Models;

Ship ship = new Ship("Tanker",13,10,50000);
Ship ship2 = new Ship("Tanker2",13,100,50000);


Plyny paliwo = new Plyny("paliwo", 10,20,100,5);
Plyny mleko = new Plyny("mleko", 10,20,100,5);
Plyny mleko2 = new Plyny("mleko2", 10,20,100,5);
Gaz gaz = new Gaz(40,23,100,4);
Chlodniczy banany = new Chlodniczy("bananas", 10, 45, 10, 100, 56);

ship.LoadShip(paliwo);
ship.LoadShip(mleko);
ship.LoadShip(mleko2);
ship.LoadShip(gaz);
ship.LoadShip(banany);

Console.WriteLine(ship.ToString());

paliwo.Load(20);
Console.WriteLine(ship.ToString());