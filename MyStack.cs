using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharphw4
{
    public class MyStack<T>
    {
        public List<T> List { get { return List; } }
        public int number = 0;

        public int Count()
            { return number; }
        public T Pop()
        {
            if(number == 0)
            {
                throw new Exception("No item to pop.");
            }T temp = List[List.Count - 1]; 
            List.RemoveAt(List.Count-1);
            --number;
            return temp;
        }
        public void Push(T val)
        {
            List.Add(val);
        }
    }
}
