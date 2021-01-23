using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> liste = new MyList<string>();
            liste.Add("Semih");
            liste.Add("Engin");
            Console.WriteLine(liste.Length);

            foreach (var isimler in liste.Items)
            {
                Console.WriteLine(isimler);
            }
        }
    }
}
