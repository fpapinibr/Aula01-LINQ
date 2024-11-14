// See https://aka.ms/new-console-template for more information
using Aula01_LINQ;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inicio do Processamento");
        var people = Adm.LoadData();

        Console.WriteLine("\nToda a Lista:");
        Adm.PrintData(people);

        Console.WriteLine("\nApenas maiores de idade:");
        Adm.PrintData(Adm.FilterByAge(people));

        Console.WriteLine("\nApenas nome que começam com a Letra a ser definida:");
        string letter = Console.ReadLine();
        Adm.PrintData(Adm.FilterByNameStartWith(people, letter[0]));

        Console.WriteLine("\nReordenado por Nome:");
        Adm.PrintData(Adm.OrderByName(people));
    }
}