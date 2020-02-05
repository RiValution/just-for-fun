using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SortedDeque<T>
    {
        List<T> list = new List<T>();
        T Head => list.Last();
        T Tail => list.First();
        public int Count => list.Count;

        public SortedDeque()
        {

        }

        public void PushBack(T data)
        {
            list.Add(data);
        }
        public void PushFront(T data)
        {
            list.Insert(0, data);
        }
        public T PopFront()
        {
            var item = Tail;
            list.Remove(item);
            return item;
        }

        public T PopBack()
        {
            var item = Head;
            list.Remove(item);

            return item;
        }

        public void Reset()
        {
            list.Clear();
        }

    }
}
