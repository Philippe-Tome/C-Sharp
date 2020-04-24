using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4._6__exercise
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();


        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You cannot pass a null object.");
            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no elements in the stack to pop.");

            var index = _list.Count - 1;
            var toReturn = _list[index];
            _list.RemoveAt(index);
            return toReturn;
        }

        public void Clear()
        {
            _list.Clear();
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


        }
    }
}
