using System;
using System.Collections.Generic;
using System.Text;

namespace V7_Uppgift1.Class
{
    public class GeneriskLista<T>
    {
        public List<T> GenericList = new List<T>();
        //Uppgift: Skapa en generisk klass som representerar en lista och
        //implementera några grundläggande funktioner(Add, Remove,
        //Get).
        //Steg:
        //1.Skapa en generisk klass GeneriskLista<T>.
        //2.Implementera metoderna:
        //• Add(T item): Lägger till ett element i listan.
        //• Remove(T item): Tar bort ett element från listan.
        //• T Get(int index): Hämtar ett element vid en given
        //index.
        public void Add(T item)
        {
            GenericList.Add(item);
        }

        public void Remove(T item)
        {
            GenericList.Remove(item);
        }

        public void Get(int index)
        {
            Console.WriteLine(GenericList[index]);
        }
    }
}
