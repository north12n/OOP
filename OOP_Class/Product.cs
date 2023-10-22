using System;
using System.Collections.Generic;

namespace Administration
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Sales { get; set; }
        public double Rate { get; set; }
        public double Tax { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id > {Id}\nEmployee Name > " +
                $"{Name}\nSalary > {Salary}\nSales > " +
                $"{Sales}\nRate > {Rate}%\nCompensation > " +
                $"{Sales * (Rate / 100)}\nTax > " +
                $"{Tax}%\nSalary All > " +
                $"{Salary - (Tax / 100) * Salary }\n");
        }
        public static List<Employees> GenerateEmployees(int number = 5)
        {

            var employees = new List<Employees>();
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                employees.Add(new Employees
                {
                    Id = i + 1,
                    Name = "Employee " + (i + 1),
                    Salary = random.Next(10, 20) * 1000,
                    Sales = random.Next(5, 10) * 1000,
                    Rate = random.Next(1, 5) * 10,
                    Tax = 5
                });
            }
            return employees;
        }

    }
}
