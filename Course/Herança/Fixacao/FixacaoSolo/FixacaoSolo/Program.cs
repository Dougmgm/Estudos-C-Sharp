using System;
using System.Collections.Generic;
using FixacaoSolo.Entities;

namespace FixacaoSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> list = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double income = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, income, healthExpenditures));
                } else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, numberOfEmployees));
                }
            }

            Console.WriteLine();
            double sum = 0;
            foreach(TaxPayers taxpayers in list)
            {
                double tax = taxpayers.Tax();
                Console.Write(taxpayers.Name + ": " + taxpayers.Tax());
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString());
        }
    }
}
