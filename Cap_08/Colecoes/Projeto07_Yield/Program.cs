/*
 * 
 * Yield
 * 
 */

static IEnumerable<string> ListarPaises()
{

    string[] paises = { "Brasil", "França", "Portugal", "Japão", "Alemanha", "Austrália", "África do Sul" };

    foreach(var pais in paises)
    {

        if (pais.StartsWith("A") || pais.StartsWith("Á"))
        {

            yield return pais;

        }

    }

}

IEnumerable<string> paises = ListarPaises();

foreach (var pais in paises)
{

    Console.WriteLine(pais);

}

Console.ReadKey();
