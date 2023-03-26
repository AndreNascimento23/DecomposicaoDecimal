Console.Clear();

Console.WriteLine("--- Decomposição Decimal ---");

Console.Write("\nDigite um número inteiro...: ");
int numero = Convert.ToInt32(Console.ReadLine());

int restante = numero; 

int unidades = restante % 10; // Pega o numero digitado e mostra apenas o resto da Divisao por 10.
restante /= 10;

int desenas = restante % 10;
restante /= 10;

int centenas = restante;

Console.WriteLine($"\nO número {numero} possui:");
Console.WriteLine($"{unidades,10} unidades(s)");
Console.WriteLine($"{desenas,10} desena(s)");
Console.WriteLine($"{centenas,10} centena(s)");

