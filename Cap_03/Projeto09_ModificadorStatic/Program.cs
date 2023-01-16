using Projeto09_ModificadorStatic;

Automovel automovel = new Automovel();

Automovel.Fabricante = "VolksWagen";
Automovel.Modelo = "T-Cross";

Automovel.Fabricante = "Chevrolet";
Automovel.Modelo = "Onix";

Console.WriteLine(automovel.ExibirDados());

Console.ReadKey();