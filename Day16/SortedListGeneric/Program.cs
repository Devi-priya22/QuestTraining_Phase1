using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortedListGeneric
{
    class SortedList<T>
    {
        private List<T> data = new List<T>();
        // public int Count => _data.Count;

        public void Add(T data)
        {
            _data.Add(data);
            _data.Sort();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
        // public int Count => _data.Count;

        public void Add(TKey key, TValue value)
        {
            _data.Add(key, value);
        }
    }

    internal class Program
    {
        static void Main()
        {
            var numberList = new SortedList<int>();
            numberList.Add(10);
            numberList.Add(20);

            var data = new MyDictionary<string, string>();
            data.Add("Name", "Alice");
        }
    }
}