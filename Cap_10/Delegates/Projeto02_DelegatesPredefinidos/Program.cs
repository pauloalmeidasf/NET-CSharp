/*
 * Delegates Predefinidos
 * 
 * Predicate
 * 
 * Func
 * 
 */

using System.Reflection.Metadata;

Console.WriteLine("Delegates predefinidos");

static double Media(double x, double y, double z)
{

    return (x + y + z) / 3;

}

//Predicate

List<string> cidades = new List<string> { "São Paulo", "Madri", "Tóquio", "Nova Iorque", "São Petersburgo" };

string cidade = cidades.Find(p => p == "São Paulo");

Console.WriteLine($"Cidade selecionada: {cidade}");

List<int> numeros = new List<int> { 1,2,3,4,5,6,9};

//Func

Func<double, double, double, double> mediaFunc;

mediaFunc = Media;

Console.WriteLine($"Média: {mediaFunc(3,6,9)}");

//Exercitando expressão lambda

int numerosSelecionados = numeros.Count(p => p % 2 == 0 || p > 8);

Console.WriteLine($"Total de números selecionados: {numerosSelecionados}");

Console.ReadKey();