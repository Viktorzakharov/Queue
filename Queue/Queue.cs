using System;
using System.Collections.Generic;

namespace Queue
{
    class Queue
    {
        private List<object> QueueArray;

        public Queue()
        {
            QueueArray = new List<object>();
        }

        public int Size()
        {
            return QueueArray.Count;
        }

        public void Enqueue(object item)
        {
            QueueArray.Add(item);
        }

        public object Dequeue()
        {
            try
            {
                var result = QueueArray[0];
                QueueArray.RemoveAt(0);
                return result;
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Очередь пустая, извлекать нечего!\n");
                return null;
            }
        }

        public void TurnAround(int n)
        {
            for (int i = 0; i < n; i++)
                Enqueue(Dequeue());
        }

        public void Write()
        {
            foreach (var item in QueueArray)
                Console.Write(item+" ");
            Console.WriteLine();
        }
    }
}
