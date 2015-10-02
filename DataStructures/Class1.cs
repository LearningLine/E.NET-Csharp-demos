using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class MyQueue<T>
    {
        private List<T> items = new List<T>();
        public int Count { get { return items.Count; } }

        public void Enqueue(T i)
        {
            this.items.Add(i);
        }

        public T Dequeue()
        {
            var result = items[items.Count - 1];
            items.RemoveAt(items.Count-1);
            return result;
        }
    }
}
