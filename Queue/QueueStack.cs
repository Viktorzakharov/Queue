using System;

namespace Queue
{
    class QueueStack : Queue
    {
        public Stack stack;
        public Stack stackReserve;

        public QueueStack()
        {
            stack = new Stack();
            stackReserve = new Stack();
        }

        public override int Size()
        {
            return stack.Size();
        }

        public override void Enqueue(object item)
        {
            stack.Push(item);
        }

        public override object Dequeue()
        {
            while (stack.Size() > 1)
                stackReserve.Push(stack.Pop());

            var result = stack.Pop();

            while (stackReserve.Size() > 0)
                stack.Push(stackReserve.Pop());

            return result;
        }

        public override void TurnAround(int n)
        {
            for (int i = 0; i < n; i++)
                Enqueue(Dequeue());
        }

        public override void Write()
        {
            stack.Write();
        }
    }
}
