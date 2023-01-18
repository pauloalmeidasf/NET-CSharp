using Projeto02_ConstrutorPersonalizado.Class;

//Objeto instanciado com o construtor personalizado
Colaborador c1 = new Colaborador("Sofia","Médica",25000);

//Objeto instanciado com o construtor default (padrão)
Colaborador c2 = new Colaborador();

Console.WriteLine(c1.DadosColaborador());

Console.WriteLine();

Console.WriteLine(new string('-',60));

Console.WriteLine();

Console.WriteLine(c2.DadosColaborador());

Console.ReadKey();