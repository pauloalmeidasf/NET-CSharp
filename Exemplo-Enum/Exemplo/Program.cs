using Aula;

List<string> listaEstados = new();

foreach (Estados e in Enum.GetValues(typeof(Estados)))
{

    //Armazena a enumeração em uma lista
    listaEstados.Add(e.ToString());
 
}

Console.ReadKey();