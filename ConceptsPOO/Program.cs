// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Hello, World!");

try
{
    Console.WriteLine(new Date(2022, 2, 28));
    Console.WriteLine(new Date(1974, 9, 23));
    Console.WriteLine(new Date(1985, 11, 30));
}
catch (Exception error)
{
    Console.WriteLine(error.Message);
}