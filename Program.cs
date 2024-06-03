using System;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]);

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

Console.WriteLine("-------------");

foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente:{chave}");
}
else
{
   Console.WriteLine($"Valor não exixtente. É seguro adicionar a chave: {chave}");
}