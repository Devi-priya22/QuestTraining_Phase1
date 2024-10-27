using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        class ShoppingList
        {
            private List<string> _item = new List<string>();
            public string this[ int index]
            {
                get
                {
                    if (index >= _item.Count)
                    {
                        throw new IndexOutOfRangeException("Index out of range");
                    }
                    return _item[index];
                }
                set 
                {
                    if (index >= _item.Count)
                    {
                        _item.Add(value);
                    }
                    else
                    {
                        _item[index] = value;
                    }
                }      
            }
            public int TotalItems => _item.Count;
        }
        static void Main(string[] args)
        {
            try
            {
                var list = new ShoppingList();
                //list[0] = "apple";
                //list[1] = "banana";
                Console.WriteLine(list[0]);
                Console.WriteLine(list.TotalItems);
            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}