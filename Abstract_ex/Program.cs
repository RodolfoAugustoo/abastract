using System;
using System.Globalization;
using System.Collections.Generic;
using Abstract_ex.Entities;

namespace Abstract_ex
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TaxPayer> payers = new List<TaxPayer>();
            
            Console.WriteLine("Enter the number of payers: ");
            int num = int.Parse(Console.ReadLine());

            for(int i=0; i<num; i++)
            {
                Console.Write("Individual or company (i / c): ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Annual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'i')
                {
                    Console.Write("Health expanditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new Individual(health, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new Company(numEmployees, name, anualIncome));
                }
            }

            Console.WriteLine("\r\nTAXES PAID");
            double sum = 0;
            foreach(TaxPayer t in payers)
            {
                Console.WriteLine(t.ToString());
                sum += t.Tax();
            }
            Console.WriteLine("\r\nTotal taxes: $" + sum);
        }
    }
}
