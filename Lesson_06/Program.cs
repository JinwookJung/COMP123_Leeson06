using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 myClass = new Class1("Hello");

            myClass.IntegerNumber = 10;
            //myClass.StringVariable = "Hi";


            
            //Console.WriteLine(myClass);

            myClass.show();

            Console.Write("/n");
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Please hit any key to exit...");
            Console.ReadKey();
        }
    }
}
