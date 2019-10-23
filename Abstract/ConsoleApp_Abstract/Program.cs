using System;

namespace ConsoleApp_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle1 R = new Rectangle1();
            R.GetLB();
            Calculate(R);

            Console.WriteLine("from abs =" + R.hello());

            Console.WriteLine();

            Circle1 C = new Circle1();
            C.GetRadius();
            Calculate(C);
        }
        public static void Calculate(Shape1 S)
        {
            Console.WriteLine("Area : {0}", S.Area());
            Console.WriteLine("Circumference : {0}", S.Circumference());
        }
    }
    

    abstract class Shape1
    {

        protected float R, L, B;
        //Abstract methods can have only declarations
        public abstract float Area();
        public abstract float Circumference();
        public string hello()
        {
            return "from abstract";
        }
    }
    class Rectangle1 : Shape1
    {
        public void GetLB()
        {
            Console.Write("Enter  Length  :  ");
            L = float.Parse(Console.ReadLine());
            Console.Write("Enter Breadth : ");
            B = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return L * B;
        }
        public override float Circumference()
        {
            return 2 * (L + B);
        }

    }
    class Circle1 : Shape1
    {

        public void GetRadius()
        {
            Console.Write("Enter  Radius  :  ");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            return 3.14F * R * R;
        }
        public override float Circumference()
        {
            return 2 * 3.14F * R;

        }
    }
}
