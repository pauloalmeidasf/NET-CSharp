/*
 * Valores de entrada no clube
 * 
 * Pessoas até 17 anos, pagam R$30,00
 * Pessoas acima de 17 e até 59 anos, pagam R$40,00
 * A partir de 60 anos, pagam R$20,00
 * 
 * Escrever um programa que vai receber a idade e apresentar o valor a ser pago
 * 
 */

Console.Write("Informe a idade: ");

string idadeInformada = Console.ReadLine();

decimal valorIngresso;

int idade;

try
{

    idade = Convert.ToInt32(idadeInformada);

    if (idade <= 17)
    {

        valorIngresso = 30;

    }
    else if (idade > 17 && idade <= 59)
    {

        valorIngresso = 40;

    }
    else
    {

        valorIngresso = 20;

    }

    string resposta = $"Valor do ingresso: {valorIngresso:c}";

    Console.WriteLine(resposta);

}
catch (Exception e)
{

    Console.WriteLine(e.Message);

}

Console.ReadKey();