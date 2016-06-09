using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Generic types
            GenericList<int> list1 = new GenericList<int>();
            GenericList<string> list2 = new GenericList<string>();
            GenericList<bool> list3 = new GenericList<bool>();

            list1.Evaluate(1);
            list2.Evaluate("Hello, as you can see, I'm a string.");
            list3.Evaluate(true);

            Console.ReadLine();
        }
    }
}
