using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace UnitTestProject2
{
    [TestClass]
    public class TestDeque
    {
        private static Deque<int> queueTest = new Deque<int>();

        [TestMethod]
        public void TestRemoveFrontTailNone()
        {
            var startCount = queueTest.list.Count;
            Assert.AreEqual(startCount, queueTest.Size());
            Assert.AreEqual(default(int), queueTest.RemoveFront());
            Assert.AreEqual(default(int), queueTest.RemoveTail());
            Assert.AreEqual(startCount, queueTest.Size());
        }

        [TestMethod]
        public void TestAroundToFrontToTailNone()
        {
            var startHead = queueTest.list.First;
            var startTail = queueTest.list.Last;
            queueTest.TurnAroundToFront(7);
            queueTest.TurnAroundToTail(7);
            Assert.AreEqual(startHead, queueTest.list.First);
            Assert.AreEqual(startTail, queueTest.list.Last);
        }

        [TestMethod]
        public void TestAddFrontTail()
        {
            var startCount = queueTest.list.Count;
            Assert.AreEqual(startCount, queueTest.Size());
            var item = 999;
            var item2 = 888;
            queueTest.AddFront(item);
            queueTest.AddTail(item2);
            Assert.AreEqual(startCount + 2, queueTest.Size());
            Assert.AreEqual(item, queueTest.list.First.Value);
            Assert.AreEqual(item2, queueTest.list.Last.Value);
        }

        [TestMethod]
        public void TestRemoveFrontTail()
        {
            var startCount = queueTest.list.Count;
            var item = queueTest.list.First;
            var item2 = queueTest.list.Last;
            Assert.AreEqual(startCount, queueTest.Size());
            Assert.AreEqual(item.Value, queueTest.RemoveFront());
            Assert.AreEqual(item2.Value, queueTest.RemoveTail());
            Assert.AreNotEqual(item, queueTest.list.First);
            Assert.AreNotEqual(item2, queueTest.list.Last);
            Assert.AreEqual(startCount - 2, queueTest.Size());
        }

        [TestMethod]
        public void TestIsPalindrom()
        {
            var line1 = "";
            var line2 = "a";
            var line3 = "Там холм лохмат";
            var line4 = "пара мам орап";
            Assert.IsTrue(Deque<object>.IsPalindrom(line1));
            Assert.IsTrue(Deque<object>.IsPalindrom(line2));
            Assert.IsTrue(Deque<object>.IsPalindrom(line3));
            Assert.IsFalse(Deque<object>.IsPalindrom(line4));
        }

        [TestMethod]
        public void TestAroundToFrontToTail()
        {
            var newHeadValue = 999;
            var newTailValue = 888;
            GenerateQueue(queueTest, 2);
            queueTest.AddFront(newHeadValue);
            queueTest.AddFront(newTailValue);
            GenerateQueue(queueTest, 3);
            var headValue = queueTest.list.First.Value;
            var tailValue = queueTest.list.Last.Value;
            queueTest.TurnAroundToTail(3);
            Assert.AreEqual(newHeadValue, queueTest.list.First.Value);
            Assert.AreEqual(newTailValue, queueTest.list.Last.Value);
            queueTest.TurnAroundToFront(3);
            Assert.AreEqual(headValue, queueTest.list.First.Value);
            Assert.AreEqual(tailValue, queueTest.list.Last.Value);
        }

        public void GenerateQueue(Deque<int> queueTest, int count)
        {
            var random = new Random();
            for (int i = 0; i < count; i++)
                queueTest.AddFront(random.Next(255));
        }
    }
}
