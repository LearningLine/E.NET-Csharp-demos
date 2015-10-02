using System;
using System.Collections.Generic;
using System.Linq;
using DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private MyQueue<int> q;

        [TestInitialize]
        public void Init()
        {
            q = new MyQueue<int>();
        }
        [TestMethod]
        public void WhenCreatingQueue_CountShouldBeZero()
        {
            Assert.AreEqual(0, q.Count);
        }
        [TestMethod]
        public void AfterAddOne_CountShouldBeOne()
        {
            q.Enqueue(1);
            Assert.AreEqual(1, q.Count);
        }
        [TestMethod]
        public void AfterQueueAndDequeue_ItemsShouldMatch()
        {
            q = new MyQueue<int>();
            var item = 42;
            q.Enqueue(42);
            var dequeued = q.Dequeue();
            Assert.AreEqual(dequeued, item, "items should be the same");
        }
    }
}
