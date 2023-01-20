using Projeto02_Exercicio.Class;
using Projeto02_Exercicio.Interfaces;

ILog iLogDisco = new LogDisco("c:\\log\\log.tx");

Log logDisco = new Log(iLogDisco);

logDisco.Registrar("tentativa suspeita de acesso");

Console.ReadKey();