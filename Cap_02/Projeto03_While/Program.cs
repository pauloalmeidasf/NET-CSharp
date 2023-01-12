/*
 * Quando não é sabido quantas vezes um determinado bloco de instruções deverá ser executado, utiliza-se o loop while
 * 
 */

int num = 1000;

while(num <= 5000)
{

    if(num == 3000)
    {

        num += 1000;

        //retorna para a verificação da expressão, ou seja, retorna para while(expressão)
        continue;

    }

    if(num == 5000)
    {

        //finaliza o loop
        break;

    }

    Console.WriteLine($"Número {num}");

    num += 1000; //num = num + 1000

}

Console.ReadKey();