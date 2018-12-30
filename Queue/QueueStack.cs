namespace AlgorithmsDataStructures
{
    public class QueueStack<T>
    {
        public Stack<T> stack;
        public Stack<T> stackRev;

        public QueueStack()
        {
            stack = new Stack<T>();
            stackRev = new Stack<T>();
        }

        public int Size()
        {
            if (stack.Size() <= 0) return stackRev.Size();
            return stack.Size();
        }

        public void Enqueue(T item)
        {
            if (stack.Size() <= 0) Rewrite(stackRev, stack);
            stack.Push(item);
        }

        public T Dequeue()
        {
            if (stackRev.Size() <= 0) Rewrite(stack, stackRev);
            if (stackRev.Size() <= 0) return default(T);
            return stackRev.Pop();
        }

        public void TurnAround(int n)
        {
            if (Size() > 1)
                for (int i = 0; i < n; i++)
                    Enqueue(Dequeue());
        }

        public void Rewrite(Stack<T> stackFrom, Stack<T> stackTo)
        {
            while (stackFrom.Size() > 0)
                stackTo.Push(stackFrom.Pop());
        }
    }
}
