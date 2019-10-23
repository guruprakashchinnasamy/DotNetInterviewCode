using System;

namespace ConsoleApp_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Account a = new Amount();
            System.Console.WriteLine(a.balance());

            Account b = new Amount2();
            System.Console.WriteLine(b.balance());

            Account c = new Account();
            System.Console.WriteLine(c.balance());
        }
    }
    public class Account
    {
        public virtual int balance()
        {
            return 10;
        }
    }
    public class Amount : Account
    {
        public override int balance()
        {
            return 500;
        }
    }
    public class Amount2 : Account
    {
        public override int balance()
        {
            return 300;
        }
    }
}
