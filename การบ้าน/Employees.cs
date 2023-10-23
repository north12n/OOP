using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace การบ้าน
{
    public class Employees
    {
        //Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Sales { get; set; }
        public double Rate { get; set; }

        //Method
        List<Employees> GenereteData(int number=1)
        {
            var data = new List<Employees>();
            Random random = new Random();

            for (int i = 1; i <= number; i++)
            {
                data.Add(new Employees()
                {
                    Id = i,
                    Name = "Employees" + i,
                    Salary = random.Next(10_000, 200_000),
                    Sales = random.Next(5_000, 100_000),
                    Rate = random.NextDouble() * 10,
                });
            }
            return data;
        }

        // Method
        public void Display(int person)
        {
            var IncomeData = GenereteData(person); //Add มา ... รายการ

            foreach (var item in IncomeData)
            {
                var Income = item.Salary + item.Sales * item.Rate;
                //var Net = Income - Income * 0.05;

                var tex = Income * 0.05;
                var net = Income - tex;

                Console.WriteLine($"{item.Id} {item.Name } {item.Salary} {item.Sales} {item.Rate} {Income} {tex} {net} ");
            }
        }

    }
}
