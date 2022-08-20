using System.Globalization;
using ClassesEMetodosAbstratos.Entities;
using System.Collections.Generic;

namespace ClassesEMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxas> tax = new List<Taxas>();

            Console.Write("Entre o número de pagadores das taxa: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do pagador #{i}: ");
                Console.Write("Pessoa ou Empresa (p/e): ");
                char check = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Ganho anual: ");
                double ganhoAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                if(check == 'p')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    tax.Add(new Pessoa(nome, ganhoAnual, gastosComSaude));
                }
                else
                {
                    Console.Write("Quantidade de funcionários: ");
                    int qtdFunc = int.Parse(Console.ReadLine());
                    tax.Add(new Empresa(nome, ganhoAnual, qtdFunc));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxas pagas:");

            double soma = 0;

            foreach (Taxas tx in tax)
            {
                double taxa = tx.Taxa();
                Console.WriteLine(tx.Nome + ": R$ " + tx.Taxa().ToString("F2", CultureInfo.InvariantCulture));
                soma += taxa;
            }
            Console.WriteLine();
            Console.WriteLine("Total de taxas: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}