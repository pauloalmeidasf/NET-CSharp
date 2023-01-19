using Projeto01_Heranca.Class;

Vendedor vendedor = new Vendedor();

vendedor.Nome = "João";
vendedor.Cargo = "Departamento Masculino";
vendedor.Salario = 3500;

vendedor.PercentualComissão = 0.15m;

Console.WriteLine($"Nome do Vendedor: {vendedor.Nome}\nSalário Final: {vendedor.SalarioFinal()}");

Console.ReadKey();