using System;

namespace Queue
{
    class Test
    {
        public static void QueueCheck(Deque queue)
        {
            var rnd = new Random();

            for (int i = 0; i < 5; i++)
                queue.AddFront(rnd.Next(255));
            queue.Write();

            queue.RemoveTail();
            queue.Write();
            queue.RemoveFront();
            queue.Write();
            queue.AddTail(rnd.Next(255));
            queue.Write();

            for (int i = 0; i < 5; i++)
                queue.RemoveTail();

            for (int i = 0; i < 5; i++)
                queue.AddTail(rnd.Next(255));
        }

        public static void TurnAround(Deque queue)
        {
            queue.Write();
            queue.TurnAroundToFront(3);
            queue.Write();
            queue.TurnAroundToTail(4);
            queue.Write();
            Console.WriteLine();
        }
    }
}
