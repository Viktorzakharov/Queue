using System;

namespace Queue
{
    class Test
    {
        public static void QueueCheck(Queue queue)
        {
            var rnd = new Random();

            for (int i = 0; i < 5; i++)
                queue.Enqueue(rnd.Next(255));
            queue.Write();

            queue.Enqueue(rnd.Next(255));
            queue.Write();
            queue.Dequeue();
            queue.Write();

            for (int i = 0; i < 6; i++)
                queue.Dequeue();

            for (int i = 0; i < 5; i++)
                queue.Enqueue(rnd.Next(255));
        }

        public static void TurnAround(Queue queue)
        {
            queue.Write();
            queue.TurnAround(3);
            queue.Write();
            Console.WriteLine();
        }
    }
}
