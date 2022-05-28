Console.WriteLine("=============================================================");
Console.WriteLine("Atividade 3 - Verifica maioridade por quantidade de pessoas.");
int quantidade = 0;
int idade = 0;
int i = 0;
while(i < 10)
{
    i++;
    Console.Write("Informe a idade da pessoa: ");
    idade = Convert.ToInt32(Console.ReadLine());
    if(idade >= 18)
    {
        quantidade++;
    }
}
Console.WriteLine("O número de pessoas maiores de 18 é: " + quantidade);
Console.ReadKey();