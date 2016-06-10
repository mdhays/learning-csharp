using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //The 'del' in this delegate invocation is just a name. You can rename it if need be.

        delegate int del(int i);
        delegate int twodel(int a);
        delegate void TestDelegate(string s);
        delegate void thirddel(string t);


        static void Main(string[] args)
        {   
            //Generic types
            GenericList<int> list1 = new GenericList<int>();
            GenericList<string> list2 = new GenericList<string>();
            GenericList<bool> list3 = new GenericList<bool>();

            list1.Evaluate(1);
            list2.Evaluate("Hello, as you can see, I'm a string.");
            list3.Evaluate(true);

            //The lambda expression x => x * x specifies a parameter that’s named x and returns the value of x squared.
            //A lambda expression with an expression on the right side of the => operator is called an expression lambda. Expression lambdas are used extensively in the construction of Expression Trees (C# and Visual Basic).
            //An expression lambda returns the result of the expression and takes the following basic form: (input parameters) => expression

            del myDelegate = x => x * x;

            twodel mySecondDelegate = y => y * y;

            int c = mySecondDelegate(5);

            int j = myDelegate(6);

            Console.WriteLine("c = " + c);
            Console.WriteLine("j = " + j);

            Console.ReadLine();
        }
    }
}
