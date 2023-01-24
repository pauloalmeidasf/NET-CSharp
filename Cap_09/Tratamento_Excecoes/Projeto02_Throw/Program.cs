/*
 * Throw
 * 
 * Dispara um erro criado pelo programa em tempo de execução
 * 
 * A exceção produzida será capturada em um bloco try/catch
 * 
 */

static int CalculaIdade(string dataNascimento)
{

    DateTime nascimento;

    int idade;

    bool dataNacimentoValida = DateTime.TryParse(dataNascimento, out nascimento);

    if(dataNacimentoValida == false)
    {

        throw new Exception("Dado informado inválido");

    }
    else
    {

        idade = (DateTime.Now - nascimento).Days / 365;

    }

    return idade;

}

Console.Write($"Informe a data de nascimento: ");

string dataNascimento = Console.ReadLine();

try
{

    Console.WriteLine($"Idade: {CalculaIdade(dataNascimento)}");

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
   
}

Console.ReadKey();