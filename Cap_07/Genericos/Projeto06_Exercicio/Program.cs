using Projeto06_Exercicio.Class;

int i = 10;
int j = 10;
string s = "10";

//Usando sobrecarga

Console.WriteLine("Exemplo usando sobrecarga");

Console.WriteLine();

Compara compara = new Compara();

Console.WriteLine($"Os valores {s} ({s.GetType()}) e {i} ({i.GetType()}) são iguais: {compara.ComparaValores(s,i)}");
Console.WriteLine($"Os valores {i} ({i.GetType()}) e {j} ({j.GetType()}) são iguais: {compara.ComparaValores(i,j)}");

Console.WriteLine();

Console.WriteLine(new string('-',70));

Console.WriteLine();

Console.WriteLine("Exemplo usando método genérico");

Console.WriteLine();

var comparaGenericoStringInt = new ComparaGenerico<string, int>();

Console.WriteLine($"Os valores {s} ({s.GetType()}) e {i} ({i.GetType()}) são iguais: {comparaGenericoStringInt.ComparaValores(s,i)}");

var comparaGenericoIntInt = new ComparaGenerico<int, int>();

Console.WriteLine($"Os valores {i} ({i.GetType()}) e {j} ({j.GetType()}) são iguais: {comparaGenericoIntInt.ComparaValores(i,j)}");

Console.ReadKey();
