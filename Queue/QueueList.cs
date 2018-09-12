using System;
using System.Collections.Generic;

namespace Queue
{
    class QueueList : Queue
    {
        private List<object> QueueArray;

        public QueueList()
        {
            QueueArray = new List<object>();
        }

        public override int Size()
        {
            return QueueArray.Count;
        }

        public override void Enqueue(object item)
        {
            QueueArray.Add(item);
        }

        public override object Dequeue()
        {
            try
            {
                var result = QueueArray[0];
                QueueArray.RemoveAt(0);
                return result;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Очередь пустая, извлекать нечего!\n");
                return null;
            }
        }

        public override void TurnAround(int n)
        {
            for (int i = 0; i < n; i++)
                Enqueue(Dequeue());
        }

        public override void Write()
        {
            foreach (var item in QueueArray)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
