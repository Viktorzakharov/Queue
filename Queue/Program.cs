using System;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            var queue = new Queue();
            var queueStack = new QueueStack();

            Test.QueueCheck(queue);
            Test.TurnAround(queue);

            Test.QueueCheck(queueStack);
            Test.TurnAround(queueStack);
        }
    }
}
