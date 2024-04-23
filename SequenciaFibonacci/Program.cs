
long numero;
long n1 = 0, n2 = 1;
long n3;

do
{
    Console.Write("Digite um número: ");
    numero = long.Parse(Console.ReadLine());
    if (numero <= 0 )
    {
        Console.WriteLine("\nO número não pode ser menor ou igual a zero.");
    }
} while (numero <= 0);

Console.WriteLine("\n Sequencia Fibonacci: ");

if (numero == 1)
{
    Console.WriteLine(n1);
}

else if (numero == 2)
{
    Console.WriteLine(n1);
    Console.WriteLine(n2);
}

else
{
    Console.WriteLine(n1);
    Console.WriteLine(n2);

    for (int i = 0; i < numero - 2; i++)
    {
        n3 = n1 + n2;
        n1 = n2;
        n2 = n3;

        Console.WriteLine(n3);
    }
}
Console.ReadKey();

