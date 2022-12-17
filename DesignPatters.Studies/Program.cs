// See https://aka.ms/new-console-template for more information

using DesignPatters.Studies.CreationalPatterns.AbstractFactory;
using DesignPatters.Studies.MazeObjects;

var mazeGame = new MazeGame();

Console.WriteLine("Creation of the Maze Game with the basics...");
mazeGame.CreateMaze();

Console.WriteLine("Creation of the Maze Game with the AbstractFactory...");
var enchantedMazeFactory = new EnchantedAbstractMazeFactory();
var enchatedWithAbstracFactoryMaze = mazeGame.CreateMazeWithAbstractFactory(enchantedMazeFactory);

var basicMazeFactory = new AbstractMazeFactory();
var abstracWithFactoryMaze = mazeGame.CreateMazeWithAbstractFactory(basicMazeFactory);
