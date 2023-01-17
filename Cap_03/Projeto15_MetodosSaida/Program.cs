/*
 * Método de saída: out
 * 
 * O método atribui valor ao parâmetro
 * 
 */

static void RetornaPI(out double valorPi)
{

    double pi = Math.PI; //3.1415...

    valorPi = pi;

}

double constantePi;

RetornaPI(out constantePi);

Console.WriteLine($"Valor de pi: {constantePi}");

Console.ReadKey();