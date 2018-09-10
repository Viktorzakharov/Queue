using System;

namespace Queue
{
    class Test
    {
        public static void QueueCheck(dynamic queue)
        {
            var rnd = new Random();

            for (int i = 0; i < 5; i++)
                queue.Enqueue(rnd.Next(255));
            ChooseWriteType(queue);

            queue.Enqueue(rnd.Next(255));
            ChooseWriteType(queue);
            queue.Dequeue();
            ChooseWriteType(queue);

            for (int i = 0; i < 6; i++)
                queue.Dequeue();

            for (int i = 0; i < 5; i++)
                queue.Enqueue(rnd.Next(255));
        }

        public static void TurnAround(dynamic queue)
        {
            if(queue is Queue ) queue.Write();
            else queue.stack.Write();

            queue.TurnAround(3);

            if (queue is Queue) queue.Write();
            else queue.stack.Write();

            Console.WriteLine();
        }

        public static void ChooseWriteType(dynamic queue)
        {
            if (queue is Queue) queue.Write();
            else queue.stack.Write();
        }
    }
}
