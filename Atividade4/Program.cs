Console.WriteLine("=============================================================");
Console.WriteLine("Atividade 4 - Algoritmo de reajuste de salários!");
int quantidadeFunc = 0;
double salario = 0;
double salarioNovo = 0;
int qtdFunc = 10;

int i = 0;

for (i = 0; i < qtdFunc; i++)
{
    Console.Write("Informe o salário do funcionário: ");
    salario = Convert.ToDouble(Console.ReadLine());
    if(salario <= 300)
    {
        salarioNovo = salario * 1.50;
    }
    else
    {
        salarioNovo = salario + ((salario * 30) / 100);
    }
    Console.WriteLine("Salário novo: " + salarioNovo);
    Console.WriteLine("========================================");
}
