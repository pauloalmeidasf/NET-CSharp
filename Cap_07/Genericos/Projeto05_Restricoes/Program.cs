/*
 * Restrições ao uso dos genéricos
 * 
 * where T: class
 * where T: struct
 * where T: notnull
 * where T: new();
 * where T: <nome da classe>
 * where T: <nome da interface>
 * 
 */

using Projeto05_Restricoes.Class;
using Projeto05_Restricoes.Interface;

Teste<ITeste> teste = new Teste<ITeste>();

Console.ReadKey();