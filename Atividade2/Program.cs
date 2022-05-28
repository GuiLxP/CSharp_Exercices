Console.WriteLine("=============================================================");
int n = 0;
int r = 0;
Console.WriteLine("Determine se o valor do número é ímpar ou par.");
Console.Write("Digite um número: ");
n = Convert.ToInt32(Console.ReadLine());
r = n % 2;
if(r == 1)
{
    Console.WriteLine("O número é ímpar.");
}
else
{
    Console.WriteLine("O número é par.");
}
Console.WriteLine("=============================================================");