using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicGen
{
    class MyDictinory<TKey, TValue>
    {
        private Dictionary<TKey, TValue> _data = new Dictionary<TKey, TValue>();
        public void Add(TKey key, TValue value) 
        {
            _data.Add(key, value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new MyDictinory<string, string>();
            data.Add("Name", "Alice");
        }
    }
}