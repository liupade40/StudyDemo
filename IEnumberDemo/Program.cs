using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIEnumerable myIEnumerable = new MyIEnumerable(new string[]{ "1", "33" });
            foreach (var item in myIEnumerable)
            {
                Console.WriteLine(item);
            }
        }
    }
    class MyIEnumerable : IEnumerable
    {
        public string[] _strs;
        public MyIEnumerable(string[] strs)
        {
            _strs = strs;
        }
        public IEnumerator GetEnumerator()
        {
           // return new MyIEnumerator(_strs);
            for (int i = 0; i < _strs.Length; i++)
            {
                yield return _strs[i];
            }
        }
    }
    class MyIEnumerator : IEnumerator
    {
        public string[] _strs;
        private int position;
        public MyIEnumerator(string[] strs)
        {
            _strs = strs;
            position = -1;
        }
        public object Current
        {
            get
            {
                return _strs[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            if (position<_strs.Length)
            {
                return true;
            }
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
