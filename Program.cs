// See https://aka.ms/new-console-template for more information
using Design_Patterns_in_C_.Exercise.Builder;

Console.WriteLine("Hello, World!");

// Builder Exe 1
var test = new CodeBuilder("Mass").AddFields("HERO", "string").AddFields("Director", "string");
Console.WriteLine(test.ToString());

