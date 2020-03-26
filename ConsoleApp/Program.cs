using ConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employess: ");
            int number = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value por hour? ");
                double valuePorHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(outsourced == 'y')
                {
                    Console.Write("Additional charge? ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutsourcedEmployee(name, hours, valuePorHour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePorHour));
                }   
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            foreach (var item in employees)
            {
                Console.WriteLine(item.Name + " - $ " + item.Payment().ToString("F2"));
            }

        }
    }
}
