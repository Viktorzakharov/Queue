using System;

namespace Queue
{
    class Program
    {
        static void Main()
        {
            var queue = new Deque();

            Test.QueueCheck(queue);
            Test.TurnAround(queue);

            Deque.PalindromeCheck("Там холм лохмат");
        }
    }
}
