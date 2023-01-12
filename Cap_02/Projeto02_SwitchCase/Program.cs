/*
 * Switch Case
 * 
 * Pode ser utlizado com expressões do tipo inteiro, char, string, enumerados
 * 
 */

Console.Write("Informe um valor entre 1 e 7: ");

int diaSemana = Convert.ToInt32(Console.ReadLine());

string resultado = string.Empty;

switch (diaSemana)
{

    case 1:

        resultado = "Domingo";
        break;

    case 2:

        resultado = "Segunda-Feira";
        break;

    case 3:

        resultado = "Terça-Feira";
        break;

    case 4:

        resultado = "Quarta-Feira";
        break;

    case 5:

        resultado = "Quinta-Feira";
        break;

    case 6:

        resultado = "Sexta-Feira";
        break;

    case 7:

        resultado = "Sábado";
        break;

    default:

        resultado = "O dia informado é inválido";
        break;

}

Console.WriteLine($"Dia informado: {resultado}");

Console.WriteLine(new string('-', 80));

/*
 * Executar as mesmas instruções para mais de um valor
 * 
 */

string classificacaoDia = "";

switch (resultado)
{

    case "Segunda-Feira":
    case "Terça-Feira":
    case "Quarta-Feira":
    case "Quinta-Feira":
    case "Sexta-Feira":

        classificacaoDia = $"{resultado} é Dia Útil";
        break;

    case "Sábado":
    case "Domingo":

        classificacaoDia = $"{resultado} é Fim de Semana";
        break;

    default:

        classificacaoDia = $"O dia informado é inválido";
        break;

}

Console.WriteLine(classificacaoDia);

Console.ReadKey();