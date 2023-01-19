using Projeto03_Polimorfismo.Class;

Produto produto1 = new Produto();

produto1.Nome = "Notebook";
produto1.Preco = 5000;

Produto produto2 = new Produto();

produto2.Nome = "Monitor";
produto2.Preco = 1500;

Console.WriteLine($"Produto\n\n{produto1.ExibirDados()}");

Console.WriteLine();

Console.WriteLine($"Produto\n\n{produto2.ExibirDados()}");

Console.WriteLine();

Livro livro1 = new Livro();

livro1.Nome = "Microsoft Visual C# Step by Step - 10th";
livro1.Preco = 278.39m;
livro1.NumeroPaginas = 796;

Console.WriteLine($"Livro\n\n{livro1.ExibirDados()}");

Console.WriteLine();

Livro livro2 = new Livro();

livro2.Nome = "Microsoft Visual C# Step by Step - 9th";
livro2.Preco = 190.39m;
livro2.NumeroPaginas = 790;

Console.WriteLine($"Livro\n\n{livro2.ExibirDados()}");

Console.ReadKey();