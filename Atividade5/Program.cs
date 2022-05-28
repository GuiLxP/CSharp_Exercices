Console.WriteLine("=============================================================");
Console.WriteLine("Atividade 5 - Algoritmo leitura de matrículas.");

string maiorMatricula;
double maiorAltura;

string menorMatricula;
double menorAltura;

string matricula;
double altura;

Console.Write("Informe a matrícula do Aluno: ");
matricula = Console.ReadLine();
Console.Write("Informe a altura do Aluno: ");
altura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

maiorMatricula = matricula;
maiorAltura = altura;
menorMatricula = matricula;
menorAltura = altura;

int i = 1;
while(i < 10)
{
    Console.Write("Informe a matricula do Aluno: ");
    matricula = Console.ReadLine();
    Console.Write("Informe a altura do Aluno: ");
    altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("");

    if(maiorAltura < altura)
    {
        maiorAltura = altura;
        maiorMatricula = matricula;
    }

    if(menorAltura > altura)
    {
        menorAltura = altura;
        menorMatricula = matricula;
    }
    i++;
}
Console.WriteLine("");
Console.WriteLine("Maior Aluno: ");
Console.WriteLine("Matrícula: {0}\nAltura: {1}", maiorMatricula, maiorAltura);
Console.WriteLine("");
Console.WriteLine("Menor Aluno: ");
Console.WriteLine("Matrícula: {0}\nAltura: {1}", menorMatricula, menorAltura);
