using NomesEstados;

List<string> listaEstados = new();

foreach (Estados e in Enum.GetValues(typeof(Estados)))
{

    //Armazena a enumeração em uma lista
    listaEstados.Add(e.ToString());

}

string estado = "SP";

int registros = 0;

foreach (var e in listaEstados)
{

    if (estado == e)
    {

        registros++;

    }

}

Console.WriteLine($"Registros encontrados: {registros}");

Console.ReadKey();