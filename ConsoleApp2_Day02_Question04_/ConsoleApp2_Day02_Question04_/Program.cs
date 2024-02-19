using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Day02_Question04_
{


    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:C}";
        }
    }

    class Program
    {
        static void Main()
        {
            Account account1 = new Account { Id = 1, Name = "John Doe", Salary = 50000.50m };
            Account account2 = new Account { Id = 2, Name = "Jane Smith", Salary = 75000.75m };

            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());

            Console.WriteLine($"Parent class of Account: {typeof(Account).BaseType.Name}");

            Type salaryType = typeof(Account).GetProperty("Salary").PropertyType;
            Console.WriteLine($"Data type of Salary: {salaryType.Name}");
            Console.WriteLine($"Parent class of Salary data type: {salaryType.BaseType.Name}");
        }
    }
}
