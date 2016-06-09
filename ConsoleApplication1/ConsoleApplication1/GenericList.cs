using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{   
    public class GenericList<T>
    {
        public void Evaluate(T input)
        {
            Console.WriteLine(input);
        }
    }
}
