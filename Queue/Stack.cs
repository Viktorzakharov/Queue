using System;
using System.Collections.Generic;

namespace Queue
{
    class Stack
    {
        private List<object> StackArray;

        public Stack()
        {
            StackArray = new List<object>();
        }

        public int Size()
        {
            return StackArray.Count;
        }

        public void Push(object item)
        {
            StackArray.Add(item);
        }

        public object Pop()
        {
            try
            {
                var lastItem = StackArray[StackArray.Count - 1];
                StackArray.RemoveAt(StackArray.Count - 1);
                return lastItem;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Стэк пуст! Извлекать нечего!\n");
                return null;
            }
        }

        public object Peak()
        {
            try
            {
                return StackArray[StackArray.Count - 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Стэк пуст! Последнего элемента не существует!\n");
                return null;
            }
        }

        public void Write()
        {
            foreach (var e in StackArray)
                Console.Write(e + " ");
            Console.WriteLine();
        }
    }
}
