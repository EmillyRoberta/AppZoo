// See https://aka.ms/new-console-template for more information
using ConsoleAppZoo;

Animal frog = new Amphibian("Frog", 2, "Amphibian");
frog.MakeSound();

Bird eagle = new Bird("Eagle", 3, "Bird");
eagle.MakeSound();
eagle.TakeOff();
eagle.Land();

Fish shark = new Fish("Shark", 8, "Fish", 1000);
shark.MakeSound();
shark.Dive(500);
shark.Surface(200);
