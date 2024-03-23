// See https://aka.ms/new-console-template for more information

using Zad3.Models;

Gaz gaz = new Gaz(23,20,100,20,"GGC");
Ship ship = new Ship("Name",13,100,50000);
ship.LoadShip(gaz);
ship.ToString();