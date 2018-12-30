using System;

namespace AlgorithmsDataStructures
{
    class Program
    {
        static void Main()
        {

            var random = new Random();
            var queue = new Queue<int>();
            for (int i = 0; i < 7; i++)
                queue.Enqueue(random.Next(255));
            Write(queue);
        }

        public static void Write(Queue<int> queue)
        {
            foreach (var item in queue.list)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
