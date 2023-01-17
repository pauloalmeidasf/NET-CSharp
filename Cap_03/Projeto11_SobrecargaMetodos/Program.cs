using Projeto11_SobrecargaMetodos.Class;

Pessoa pessoa = new Pessoa();

pessoa.Nome = "Andrea";
pessoa.Idade = 25;

Console.WriteLine(pessoa.ExibirDados());

Console.WriteLine();

Console.WriteLine(new string('-',50));

Console.WriteLine();

Console.WriteLine(pessoa.ExibirDados("Aluna do curso de CSharp"));

Console.ReadKey();