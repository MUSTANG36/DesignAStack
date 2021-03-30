using System;
using System.Collections.Generic;
using System.Text;

namespace DesignAStack
{
    public class Stack
    {
        // we don't want to re-initialize that list anywhere else in the class
        private readonly List<Object> stack = new List<Object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("Null");
            }
            else
            {
                stack.Add(obj);
                //stack[++top] = obj;
            }



        }
        public object Pop()
        {
            if (stack.Count == 0)
            {
                throw new InvalidOperationException("There's no new elements");
                
            }

            var top = stack.Count - 1;
            var index = stack[top];

            stack.RemoveAt(top);

            return index;


        }
        public void Clear()
        {
            stack.Clear();
       

        }
    }
}
