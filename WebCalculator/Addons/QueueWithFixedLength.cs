using System;
using System.Collections.Generic;

namespace Addons
{
    public class QueueWithFixedLength<T>
    {
        private List<T> lvi = new List<T>();
        public int FixedCount {get; private set;}
        public int CurrentCount => lvi.Count;
        public QueueWithFixedLength(int countElementsInQueue)
        {
            FixedCount = countElementsInQueue;
        }

        public T[] GetElements()
        {
            return lvi.ToArray();
        }

        public void Push(T element)
        {
            if(lvi.Count==FixedCount)
            {
                T firstElement = lvi[0];
                lvi.Remove(firstElement);
                lvi.Add(element);
            }
            else
            {
                lvi.Add(element);
            }
        }
    }
}
