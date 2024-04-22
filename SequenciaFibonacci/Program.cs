
long numero;
long n1, n2;
long n3; 

Console.WriteLine("Digite um número: ");
numero = long.Parse(Console.ReadLine());

Console.WriteLine("\n Sequencia Fibonacci: ");

n1 = 0;
n2 = 1;
Console.WriteLine(n1);
Console.WriteLine(n2);

for (int i = 0; i < numero - 2; i++)
{
    n3 = n1 + n2;
    n1 = n2;
    n2 = n3;

    Console.WriteLine(n3);
}
