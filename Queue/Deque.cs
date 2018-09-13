using System;
using System.Collections.Generic;

namespace Queue
{
    class Deque
    {
        private LinkedList<object> list;

        public Deque()
        {
            list = new LinkedList<object>();
        }

        public void AddFront(object item)
        {
            list.AddFirst(item);
        }

        public object RemoveFront()
        {
            try
            {
                var result = list.First.Value;
                list.RemoveFirst();
                return result;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Очередь пустая, извлекать нечего!\n");
                return null;
            }
        }

        public void AddTail(object item)
        {
            list.AddLast(item);
        }

        public object RemoveTail()
        {
            try
            {
                var result = list.Last.Value;
                list.RemoveLast();
                return result;
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Очередь пустая, извлекать нечего!\n");
                return null;
            }
        }

        public int Size()
        {
            var count = 0;
            var node = list.First;

            while (node.Next != null)
            {
                node = node.Next;
                count++;
            }
            return count;
        }

        public void TurnAroundToFront(int n)
        {
            for (int i = 0; i < n; i++)
                AddTail(RemoveFront());
        }

        public void TurnAroundToTail(int n)
        {
            for (int i = 0; i < n; i++)
                AddFront(RemoveTail());
        }

        public void Write()
        {
            foreach (var item in list)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        public static void PalindromeCheck(string line)
        {
            var queue = ConvertStringToDeque(line);
            Console.WriteLine(line);

            while (true)
            {
                var front = queue.RemoveFront();
                var tail = queue.RemoveTail();

                if (front is null || tail is null)
                {
                    Console.WriteLine("Строка - палиндром!");
                    break;
                }
                else if ((char)front != (char)tail)
                {
                    Console.WriteLine("Сторока НЕ палиндром!");
                    break;
                }
            }
        }

        public static Deque ConvertStringToDeque(string line)
        {
            var queue = new Deque();   

            foreach (var item in line)
                if (item != ' ') queue.AddFront(char.ToLower(item));

            return queue;
        }
    }
}
