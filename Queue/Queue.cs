using System;

namespace Queue
{
    abstract class Queue
    {
        public abstract int Size();
        public abstract void Enqueue(object item);
        public abstract object Dequeue();
        public abstract void TurnAround(int n);
        public abstract void Write();
        
    }
}
