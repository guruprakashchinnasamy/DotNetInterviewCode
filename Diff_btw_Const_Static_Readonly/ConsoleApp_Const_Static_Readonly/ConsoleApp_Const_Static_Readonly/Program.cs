using System;

namespace ConsoleApp_Const_Static_Readonly
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test t = new Test();
            t.Execute();
        }
    }
    public class Test {

        static string string_static = "string_static Init";
        static string string_static_null = null;

        const string string_const = "string_const Init";
        const string string_const_null = null;

        readonly string string_readonly = "string_readonly Init";
        readonly string string_readonly_null = null;

        public Test() {

            string_static = "string_static Constructor";
            string_static_null = "string_static_null Constructor";

            //Const Value can not be changed in any other place (Compiler Error)  
            //string_const = "string_const Constructor";
            //string_const_null = "string_const_null Constructor";

            string_readonly = "string_readonly Constructor";
            string_readonly_null = "string_readonly_null Constructor";
        }
        public void Execute() {

            string_static = "string_static Execute";
            string_static_null = "string_static_null Execute";

            //Const Value can not be changed in any other place (Compiler Error) 
            //string_const = "string_const Execute";
            //string_const_null = "string_const_null Execute";

            //Readonly value can not be changed in Function/Method (Compiler Error)
            //string_readonly = "string_readonly Execute";
            //string_readonly_null = "string_readonly_null Execute";

        }
    }
}
