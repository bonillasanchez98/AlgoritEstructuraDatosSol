using System;
using System.Collections.Generic;

namespace OtherCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== HASHSET =====");
            //HashSet, funciona igual que una lista, solo que los valores repetidos los omite
            Console.ForegroundColor = ConsoleColor.Green;
            HashSet<string> hashSet1= new HashSet<string>();
            hashSet1.Add("a");
            hashSet1.Add("b");
            hashSet1.Add("c");
            hashSet1.Add("a");
            foreach (var item in hashSet1){Console.WriteLine(item);}
            Console.WriteLine("\n");

            ///////////////////////////////////////////////////////////////////////
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== SORTEDSET=====");
            //SorteSet, organiza los elementos de forma ascendente
            Console.ForegroundColor = ConsoleColor.Red;
            SortedSet<int> sortedSet = new SortedSet<int>();
            
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(3);
            sortedSet.Add(4);
            sortedSet.Add(1);
            foreach (var item in sortedSet) { Console.WriteLine(item); }
            Console.WriteLine("\n");

            ///////////////////////////////////////////////////////////////////////

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== DICTONARY =====");
            //Dictionary, es una lista de tipo clave:valor
            Console.ForegroundColor= ConsoleColor.Yellow;
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Add(4, "four");

            //Para leer los elementos de una lista de tipo Dictionary se usa la variable de tipo KeyValuePair<key, value>
            foreach (KeyValuePair<int,String> item in dictionary){Console.WriteLine(item);}
            Console.WriteLine("\n");

            ///////////////////////////////////////////////////////////////////////
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===== SORTEDLIST =====");
            //El SortedList es un lista de clave valor, pero viene ordenada de forma ascendente
            Console.ForegroundColor= ConsoleColor.Cyan;
            SortedList<double, string> studentScore = new SortedList<double, string>();
            studentScore.Add(3.33, "Jose");
            studentScore.Add(3.84, "Elizabeth");
            studentScore.Add(2.97, "Juan");
            studentScore.Add(4.00, "Pedro");

            foreach (var item in studentScore) { Console.WriteLine(item); }

            Console.ReadKey();
        }

        
    }
}
