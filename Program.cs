using V7_Uppgift1.Class;

namespace V7_Uppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Testa klassen genom att skapa en instans av
            var intLista = new GeneriskLista<int>(); //GeneriskLista<int>
            intLista.Add(1);
            intLista.Add(2);
            intLista.Remove(1);
            intLista.Get(0); //bort och hämta värden.

            var stringLista = new GeneriskLista<string>(); //GeneriskLista<string>
            stringLista.Add("hej");
            stringLista.Add("Hejdå");
            stringLista.Remove("hej");
            stringLista.Get(0); //bort och hämta värden.
        }
    }
}
