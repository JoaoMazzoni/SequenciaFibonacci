
long numeroPos;
long penultimo = -1, ultimo = 1,  atual;

do
{
    Console.Write("Digite o número da posição limite: ");
    numeroPos = long.Parse(Console.ReadLine());
    if (numeroPos <= 0 )
    {
        Console.WriteLine("\nO número não pode ser menor ou igual a zero.");
    }
} while (numeroPos <= 0);

Console.WriteLine("\n Sequencia Fibonacci: ");

for (int i = 0; i < numeroPos; i++)
{
    atual = penultimo + ultimo;
    Console.WriteLine(atual);
    penultimo = ultimo;
    ultimo = atual;
}

Console.ReadKey();

