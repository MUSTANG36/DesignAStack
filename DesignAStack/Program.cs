using System;
using System.Collections.Generic;

namespace DesignAStack
{
    class Program
    {
        private object[] stack;
        private int top;

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
                mystack.Pop();
            }

        }

        public void Push(object obj) {
            if (obj == null)
            {
                throw new InvalidOperationException("Null");
            }
            else {
                stack[++top] = obj;
            }

         
            
        }
        public object Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
            else {
                return stack[top--];
            }

        }
        public void Clear() {
            for (int i=0; i <= stack.Length ; i++) {
                Console.WriteLine(stack[--top]);
            }

        }
       
    }
}
