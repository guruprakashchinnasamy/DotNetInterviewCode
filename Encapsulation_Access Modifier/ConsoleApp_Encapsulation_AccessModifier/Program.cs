using System;

namespace ConsoleApp_Encapsulation_AccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            cls_forAccess cls = new cls_forAccess();
            Console.WriteLine("Created from instant.");
            cls.str_pub = cls.str_pub + ". Can Access from instant";

            //The Private can not able to access from instant, Compiler Error
            //cls.str_private = cls.str_private + ". Can't Access from instant";

            //The Protected can not able to access from instant, Compiler Error
            //cls_forAccess .str_pro = cls.str_pro + ". Can't Access from instant";

            cls.str_internal = cls.str_internal + ". Can Access from instant";
            cls.str_ProInternal = cls.str_ProInternal + ". Can Access from instant";

            Console.WriteLine(cls.str_pub);
            Console.WriteLine("Compiler Error : cls.str_private. Can't Access from instant");
            Console.WriteLine("Compiler Error : cls_forAccess .str_pro. Can't Access from instant;");
            Console.WriteLine(cls.str_internal);
            Console.WriteLine(cls.str_ProInternal);

            cls_ForAccess2 cls2 = new cls_ForAccess2();
        }
    }
    public class cls_forAccess
    {
        public string str_pub = "This is Public";
        private string str_private = "This is Private";
        protected string str_pro = "This is Protected";
        internal string str_internal = "This is internal";
        protected internal string str_ProInternal = "This is Protected internal";
        public cls_forAccess()
        {
            Console.WriteLine("Base Class Called");
            Console.WriteLine(str_private + ". Private can access only in From Base Class..");
        }
    }
    public class cls_ForAccess2 : cls_forAccess
    {
        public string str_Pub2 = String.Empty;
        public cls_ForAccess2()
        {
            Console.WriteLine("Drived Class Called !!!");
            str_pub = str_pub + ". Can Access from Drived Class";

            //The Private can not able to access from the drived class, Compiler Error
            //str_private = str_private + ". Can Access from Drived Class";

            str_pro = str_pro + ". Can Access from Drived Class";
            str_internal = str_internal + ". Can Access from Drived Class";
            str_ProInternal = str_ProInternal + ". Can Access from Drived Class";

            hello();
        }
        void hello()
        {
            Console.WriteLine(str_pub);
            Console.WriteLine(str_pro);
            Console.WriteLine(str_internal);
            Console.WriteLine(str_ProInternal);
        }
    }
}
