using Projeto07_Enumeradores.Enum;

Console.WriteLine("Todos os estados civis");

Console.WriteLine();

//Loop para ler todos os estados civis
foreach(var i in Enum.GetValues(typeof(EstadosCivis)))
{

    Console.WriteLine($"Estado Civil: {i}");

}

Console.WriteLine();

Console.WriteLine(new string('-',50));

Console.WriteLine();

Console.WriteLine("Estado civil individual");

Console.WriteLine();

//Enum para string
string casado = $"Estado civil: {EstadosCivis.Casado}";

Console.WriteLine(casado);

Console.ReadKey();
