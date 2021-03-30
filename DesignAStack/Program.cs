using System;
using System.Collections.Generic;

namespace DesignAStack
{
    class Program
    {
   
        static void Main(string[] args)
        {
            var mystack = new Stack<object>();
            /*mystack.Push(1);
            mystack.Push(2);
            mystack.Push(3);

            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());
            Console.WriteLine(mystack.Pop());*/

            var start = 0;
            var end = 5;

            for (int i = start; i > end; i++) {
                mystack.Push(i);
            }

            for (int i = start; i > end; i++) {
               Console.WriteLine(mystack.Pop());
            }
            
        }

        
       
    }
}
