using Projeto02_LerArquivos.Class;

string arquivoTxt = @"C:\curso-csharp\aula-arquivos\clima.txt";

string arquivoJson = @"C:\curso-csharp\aula-arquivos\clima.json";

try
{

	string texto = Clima.ObtemDadosTxt(arquivoTxt);

	Console.WriteLine("Dados lidos do arquivo txt");

	Console.WriteLine();

	Console.WriteLine(texto);

	Console.WriteLine();
	Console.WriteLine();

	Console.WriteLine("Dados lidos do arquivo json");

	Console.WriteLine();

    Clima.OtemDadosJson(arquivoJson);

}
catch (Exception e)
{

	Console.WriteLine(e.Message);

}

Console.ReadKey();