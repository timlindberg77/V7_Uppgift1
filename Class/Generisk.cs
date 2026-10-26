using System;
using System.Collections.Generic;
using System.Text;

namespace V7_Uppgift1.Class
{
    public class GeneriskLista<T>
    {
        //1.Skapa en generisk klass GeneriskLista<T>.
        public List<T> GenericList = new List<T>();

        //2.Implementera metoderna:
        //• Add(T item): Lägger till ett element i listan.

        public void Add(T item)
        {
            GenericList.Add(item);
        }

        //• Remove(T item): Tar bort ett element från listan.
        public void Remove(T item)
        {
            GenericList.Remove(item);
        }

        //• T Get(int index): Hämtar ett element vid en given
        //index.
        public void Get(int index)
        {
            Console.WriteLine(GenericList[index]);
        }
    }
}
