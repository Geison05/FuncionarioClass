using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F = new Funcionario();

            Console.WriteLine("Dados do Funcionario: ");
            Console.Write("\nNome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine();
            Console.WriteLine("Funcionário: "+F);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double qte = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + F);
        }
    }
}