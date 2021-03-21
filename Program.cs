using System;
using System.Collections.Generic;

namespace CAGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dersler = new List<string>();
            
            dersler.Add("Matematik");
            dersler.Add("Türkçe");
            dersler.Add("Geometri");
            dersler.Add("Vatandaşlık");
            dersler.Add("Coğrafya");
            dersler.Add("Müzik");
            Console.WriteLine(dersler.Count);

            MyList<string> dersler2 = new MyList<string>();
            
            dersler2.Add("Kimya");
            Console.WriteLine(dersler2.Count);
        }
    }

    class MyList<T>//Generic Class
    {
        T[] _array;
        T[] _temparray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _temparray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _temparray.Length; i++)
            {
                _array[i] = _temparray[i];
            }
            _array[_array.Length - 1] = item;
        }

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
