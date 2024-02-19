using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Account 
    {
        string name;
        int id;
        double balance;
        public Account(string name, int id, double balance) {
            this.name = name;
            this.id = id;
            this.balance = balance;
        
        }
        public void deposit(int amt)
        {
            balance = balance + amt;
           // Console.WriteLine(balance);
        }
        public void Withdraw(int amt)
        {
            balance = balance - amt;
           // Console.WriteLine(balance);
        }
        public void disp() 
        {
            Console.WriteLine(this.name+" "+id+" "+balance);
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account("Sham", 10, 50000);
           
            ac.Withdraw(20000);
            ac.disp();
            Account ac1 = new Account("Ghansham", 20, 100000);
            ac.Withdraw(10000);
            ac.deposit(2000);
            ac.disp();
        }
    }
}
