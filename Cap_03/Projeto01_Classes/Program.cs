using Projeto01_Classes.Class;

Console.WriteLine("Primeiro Carro");

Console.WriteLine();

Automovel carro = new Automovel();

carro.Ano = 2021;
carro.Cor = "Branco";
carro.Fabricante = "Honda";
carro.Modelo = "Civic";
carro.Placa = "ABC1D23";

Console.WriteLine($"Fabricante: {carro.Fabricante}");
Console.WriteLine($"Modelo: {carro.Modelo}");
Console.WriteLine($"Placa: {carro.Placa}");
Console.WriteLine($"Cor: {carro.Cor}");
Console.WriteLine($"Ano: {carro.Ano}");

Console.WriteLine(new string('-',60));

Console.WriteLine();

Console.WriteLine("Segundo Carro");

Console.WriteLine();

Automovel carro2 = new Automovel
{

    Ano = 2022,
    Cor = "Prata",
    Fabricante = "Toyota",
    Modelo = "Corolla",
    Placa = "FGH5X65"

};

Console.WriteLine($"Fabricante: {carro2.Fabricante}");
Console.WriteLine($"Modelo: {carro2.Modelo}");
Console.WriteLine($"Placa: {carro2.Placa}");
Console.WriteLine($"Cor: {carro2.Cor}");
Console.WriteLine($"Ano: {carro2.Ano}");

Console.ReadKey();