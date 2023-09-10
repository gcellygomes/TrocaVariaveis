// GicellyGomes

string nome,nome2, auxiliar;

Console.WriteLine("---Troca de Variaveis---\n");

Console.Write("nome..: Tom Riddle");
nome = Console.ReadLine()!;

Console.Write("nome2..:Lord Voldemort");
nome2 = Console.ReadLine()!;

auxiliar = nome;
nome = nome2;
nome2 = auxiliar;


Console.WriteLine("\nApós Trocado os variaveis:\n");
Console.WriteLine($"Tom Riddle = {nome}");
Console.WriteLine($"Lord Voldemort = {nome2}");
