using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class TestQueueStack
    {
        private static QueueStack<int> queueTest = new QueueStack<int>();

        [TestMethod]
        public void TestDequeueNone()
        {
            var startCountStack = queueTest.stack.Size();
            var startCountStackRev = queueTest.stackRev.Size();
            Assert.AreEqual(startCountStack, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size());
            Assert.AreEqual(default(int), queueTest.Dequeue());
            Assert.AreEqual(startCountStack, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size());
        }

        [TestMethod]
        public void TestAroundNone()
        {
            var startHead = queueTest.stack.Peek();
            queueTest.Rewrite(queueTest.stack, queueTest.stackRev);
            var startTail = queueTest.stackRev.Peek();
            queueTest.TurnAround(7);
            Assert.AreEqual(startTail, queueTest.stackRev.Peek());
            queueTest.Rewrite(queueTest.stackRev, queueTest.stack);
            Assert.AreEqual(startHead, queueTest.stack.Peek());
        }

        [TestMethod]
        public void TestEqueue()
        {
            var startCountStack = queueTest.stack.Size();
            var startCountStackRev = queueTest.stackRev.Size();
            Assert.AreEqual(startCountStack, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size());
            var item = 999;
            queueTest.Enqueue(item);
            Assert.AreEqual(startCountStack + 1, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size() - 1);
            Assert.AreEqual(item, queueTest.stack.Peek());
        }

        [TestMethod]
        public void TestDeueue()
        {
            var startCountStack = queueTest.stack.Size();
            var startCountStackRev = queueTest.stackRev.Size();
            Assert.AreEqual(startCountStack, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size() - 1);
            queueTest.Rewrite(queueTest.stack, queueTest.stackRev);
            var item = queueTest.stackRev.Peek();
            queueTest.Rewrite(queueTest.stackRev, queueTest.stack);
            Assert.AreEqual(item, queueTest.Dequeue());
            Assert.AreNotEqual(item, queueTest.stackRev.Peek());
            Assert.AreEqual(startCountStack - 1, queueTest.Size());
            Assert.AreEqual(startCountStackRev, queueTest.Size());
        }

        [TestMethod]
        public void TestAround()
        {
            var headValue = 999;
            var tailValue = 888;
            GenerateQueue(queueTest, 2);
            queueTest.Enqueue(headValue);
            queueTest.Enqueue(tailValue);
            GenerateQueue(queueTest, 3);
            queueTest.TurnAround(3);
            Assert.AreEqual(headValue, queueTest.stack.Peek());
            queueTest.Rewrite(queueTest.stack, queueTest.stackRev);
            Assert.AreEqual(tailValue, queueTest.stackRev.Peek());
            queueTest.Rewrite(queueTest.stackRev, queueTest.stack);
        }

        public void GenerateQueue(QueueStack<int> queueTest, int count)
        {
            var random = new Random();
            for (int i = 0; i < count; i++)
                queueTest.Enqueue(random.Next(255));
        }
    }
}

