using System;
using Enumeração.Entities;
using Enumeração.Entities.Enums;

namespace Enumeração
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter para string

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //Converter para enum

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered"); // igual OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);*/

            // Exercícios

            /*Ler os dados de um trabalhador com N contratos(N fornecido pelo usuário).Depois, solicitar
             do usuário um mês e mostrar qual foi o salário do funcionário nesse mês */

            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("How many contracts to this worker? ");

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department:" + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month));
        }
    }
}
