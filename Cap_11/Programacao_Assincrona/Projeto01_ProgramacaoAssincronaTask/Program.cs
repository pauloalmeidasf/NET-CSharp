
/*
 * Programação Assíncrona
 * 
 * Usa-se métodos assíncronos em operações que podem demorar para produzir um resultado esperado (Consulta Bancos de Dados, Webservices etc)
 * 
 * Permite a execução do programa na thread principal enquanto uma tarefa de longa duração é executada em uma thread independente
 * 
 * Thread: uma sequência de instruções que podem ser executadas simultaneamente com outras sequências de instruções
 * 
 * Retorno de métodos assíncronos: Task e também Task<T>
 * 
 * Task: usado em métodos assíncronos que não retorna um valor. É a promessa de execução de uma tarefa no futuro
 * 
 * Task<T>: usado em métodos assíncronos que retorna um valor
 * 
 * async: define métodos assíncronos
 * 
 * await: pausa a execução da thread atual até que o método assíncrono seja concluído
 * 
 */

class Program
{

    private static async Task Aguardar(int tempo)
    {

        Console.WriteLine("Iniciando tempo de espera...");

        await Task.Delay(tempo);

        Console.WriteLine("Fim do tempo de espera.");

    }

    static async Task Main(string[] args)
    {

        Console.WriteLine("Iniciando o programa, tecle algo para continuar...");

        Console.ReadKey();

        int tempo = 6000;

        await Aguardar(tempo); //milisegundos

        Console.WriteLine($"Passaram-se {tempo} milisegundos");

        Console.WriteLine("Fim do programa.");

        Console.ReadKey();  

    }

}