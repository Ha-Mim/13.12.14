using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack <int> aStack = new Stack<int>();
            aStack.Push(12);
            aStack.Push(23);
            aStack.Push(34);
            //Console.WriteLine(aStack.Pop());
            //Console.WriteLine(aStack.Pop());
            //Console.WriteLine(aStack.Peek());
            foreach (var item in aStack)
            {
                Console.WriteLine(item);
               

            }
            Console.ReadLine();
        }
    }
}
