using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class TestQueue
    {
        private static Queue<int> queueTest = new Queue<int>();

        [TestMethod]
        public void TestDequeueNone()
        {
            var startCount = queueTest.list.Count;
            Assert.AreEqual(startCount, queueTest.Size());
            Assert.AreEqual(default(int), queueTest.Dequeue());
            Assert.AreEqual(startCount, queueTest.Size());
        }

        [TestMethod]
        public void TestAroundNone()
        {
            var startHead = queueTest.list.First;
            var startTail = queueTest.list.Last;
            queueTest.TurnAround(7);
            Assert.AreEqual(startHead, queueTest.list.First);
            Assert.AreEqual(startTail, queueTest.list.Last);
        }

        [TestMethod]
        public void TestEqueue()
        {
            var startCount = queueTest.list.Count;
            Assert.AreEqual(startCount, queueTest.Size());
            var item = 999;
            queueTest.Enqueue(item);
            Assert.AreEqual(startCount + 1, queueTest.Size());
            Assert.AreEqual(item, queueTest.list.First.Value);
        }

        [TestMethod]
        public void TestDeueue()
        {
            var startCount = queueTest.list.Count;
            var item = queueTest.list.Last;
            Assert.AreEqual(startCount, queueTest.Size());
            Assert.AreEqual(item.Value, queueTest.Dequeue());
            Assert.AreNotEqual(item, queueTest.list.Last);
            Assert.AreEqual(startCount - 1, queueTest.Size());
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
            Assert.AreEqual(headValue, queueTest.list.First.Value);
            Assert.AreEqual(tailValue, queueTest.list.Last.Value);
        }

        public void GenerateQueue(Queue<int> queueTest, int count)
        {
            var random = new Random();
            for (int i = 0; i < count; i++)
                queueTest.Enqueue(random.Next(255));
        }
    }
}
