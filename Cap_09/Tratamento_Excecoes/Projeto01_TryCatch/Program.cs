/*
 * Try: executa o código se não houver execeção 
 * 
 * Catch: captura qualquer exceção encontrada no bloco try
 * 
 * Finaly: sempre executado ao final do bloco
 * 
 */

try
{

    Console.Write("Informe o numerador: ");

    double numerador = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informe o denominador: ");

    double denominador = Convert.ToDouble(Console.ReadLine());

    double resultado = numerador / denominador;

    Console.WriteLine();

    Console.WriteLine($"{numerador} / {denominador}: {resultado}\n\n");

}
catch (Exception ex)
{

    //mensagem personalizada
    Console.WriteLine("Erro personalizado: Erro ao realizar a operação\n\n");

    //mensagem com os destalhes do erro
    Console.WriteLine($"Detalhes técnicos: {ex.Message}\n\n");
    
}
finally
{

    //é executado independentemente de ter ocorrido uma execeção ou não
    Console.WriteLine("Operação finalizada.\n\n");

}

Console.ReadKey();