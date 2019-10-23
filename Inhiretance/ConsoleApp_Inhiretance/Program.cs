using System;

namespace ConsoleApp_Inhiretance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BaseClass bd = new drivClass();
            bd.hello();
            BaseClass b = new BaseClass(); ;
            bd.hello();
            drivClass d = new drivClass();
            d.hello();
            //drivClass e = new BaseClass(); can not create a instance like this. Compailer error

        }
    }
    public class BaseClass
    {
        public BaseClass()
        {

        }
        public int hello()
        {
            return 9;
        }
    }
    public class drivClass : BaseClass
    {
        public drivClass()
        {

        }
        public int hello()
        {
            return 8;
        }
    }
}
