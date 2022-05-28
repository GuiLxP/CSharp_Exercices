Console.WriteLine("=============================================================");
double media = 0;
double idade1 = 0;
double idade2 = 0;
double idade3 = 0;
double idade4 = 0;
double idade5 = 0;
Console.WriteLine("Programa que calculará a média de 5 alunos");
Console.Write("Informe a idade do Aluno 1: ");
idade1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do Aluno 2: ");
idade2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do Aluno 3: ");
idade3 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do Aluno 4: ");
idade4 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a idade do Aluno 5: ");
idade5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

media = ((idade1 + idade2 + idade3 + idade4 + idade5) / 5);
Console.WriteLine("A média de idade dos 5 alunos é: " + media);

Console.WriteLine("=============================================================");
