// See https://aka.ms/new-console-template for more information
using Design_Patterns_in_C_.Exercise.Builder;
using static Design_Patterns_in_C_.Exercise.Factory.Exercise1;

Console.WriteLine("Hello, World!");

// Builder Exe 1
//var test = new CodeBuilder("Mass").AddFields("HERO", "string").AddFields("Director", "string");
//Console.WriteLine(test.ToString());

// Factory Exe 1
var factoryTest = new PersonFactory().CreatePerson("mike");
Console.WriteLine(factoryTest.ToString());