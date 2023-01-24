/*
 * Try: executa o código se não houver exceção 
 * 
 * Catch: captura qualquer exceção encontrada no bloco try
 * 
 * Finaly: sempre executado ao final do bloco. Opcional
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

    Console.WriteLine();

    //mensagem personalizada
    Console.WriteLine("Erro personalizado: Erro ao realizar a operação\n\n");

    //mensagem com os destalhes do erro
    Console.WriteLine($"Detalhes técnicos: {ex.Message}\n\n");
    
}
finally
{

    //é executado independentemente de ter ocorrido uma execeção ou não
    Console.WriteLine("Operação finalizada.\n");

}

Console.WriteLine("teste final bloco try");

Console.ReadKey();